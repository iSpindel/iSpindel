using Grpc.Core;
using iSpindel.Server.gRPC;

namespace iSpindel.Server.Services;

public class RecordingService : gRPC.RecordingService.RecordingServiceBase
{
    private readonly ILogger<RecordingService> _logger;
    public RecordingService(ILogger<RecordingService> logger)
    {
        _logger = logger;
    }

    public override Task<CurrentRecordingIdReply> GetCurrentRecordingId(CurrentRecordingIdRequest request, ServerCallContext context)
    {
        return Task.FromResult(new CurrentRecordingIdReply() {Id = 2});
    }

    public override Task<StatusReply> GetRecordingStatus(StatusRequest request, ServerCallContext context)
    {
        return Task.FromResult(new StatusReply(){ServerStatusCode = ServerStatusCode.Idle});
    }

    public override Task<StartReply> StartRecording(StartRequest request, ServerCallContext context)
    {
        return Task.FromResult(new StartReply(){ Rc = true });
    }

    public override Task<StopReply> StopRecording(StopRequest request, ServerCallContext context)
    {
        return Task.FromResult(new StopReply(){ Rc = true });
    }
}
