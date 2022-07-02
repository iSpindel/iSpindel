using Grpc.Core;
using iSpindel.Database.Job;
using iSpindel.Server.gRPC;

namespace iSpindel.Server.Services;

public class RecordingService : gRPC.RecordingService.RecordingServiceBase
{
  private readonly ISpindelService _spindelService;

  public RecordingService(ISpindelService spindelService)
  {
    this._spindelService = spindelService;
  }

  public override async Task<CurrentRecordingIdReply> GetCurrentRecordingId(CurrentRecordingIdRequest request, ServerCallContext context)
  {
    return new CurrentRecordingIdReply() { Id = await _spindelService.GetRecordingIdAsync() };
  }

  public override async Task<StatusReply> GetRecordingStatus(StatusRequest request, ServerCallContext context)
  {
    return new StatusReply() { ServerStatusCode = (ServerStatusCode)await _spindelService.GetStatusAsync() };
  }

  public override Task<StartReply> StartRecording(StartRequest request, ServerCallContext context)
  {
    _spindelService.StartAsync(request.Id);
    return Task.FromResult(new StartReply() { Rc = true });
  }

  public override Task<StopReply> StopRecording(StopRequest request, ServerCallContext context)
  {
    _spindelService.StopAsync();
    return Task.FromResult(new StopReply() { Rc = true });
  }
}
