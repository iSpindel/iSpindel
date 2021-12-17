
using iSpindel.Server.gRPC;
using iSpindel.Shared;
using System;
using System.Threading.Tasks;

namespace iSpindel.App.Services
{
    public class SpindelClient : ISpindelClient
    {
        private readonly RecordingService.RecordingServiceClient _grpcClient;

        public SpindelClient(RecordingService.RecordingServiceClient grpcClient)
        {
            _grpcClient = grpcClient;
        }

        private StatusCode TranslateStatusCode(iSpindel.Server.gRPC.ServerStatusCode grpcStatus)
        {
            if (grpcStatus == ServerStatusCode.Idle)
                return StatusCode.IDLE;
            if (grpcStatus == ServerStatusCode.Recording)
                return StatusCode.RECORDING;

            return StatusCode.UNKNOWN;

        }

        public async Task<StatusCode> GetStatusAsync()
        {
            try
            {
                var rc = await _grpcClient.GetRecordingStatusAsync(new StatusRequest());

                return TranslateStatusCode(rc.ServerStatusCode);

            }
            catch (Exception) { }
            return StatusCode.UNKNOWN;
        }

        public async Task<int?> GetRecordingIdAsync()
        {
            try
            {
                var rc = await _grpcClient.GetCurrentRecordingIdAsync(new CurrentRecordingIdRequest());

                return rc.Id;
            }
            catch (Exception) { }
            return null;
        }

        public async Task<bool> StartAsync(int id)
        {
            try
            {
                var rc = await _grpcClient.StartRecordingAsync(new StartRequest()
                {
                    Id = id
                });

                return rc.Rc;
            }
            catch (Exception) { }
            return false;
        }

        public async Task<bool> StopAsync()
        {
            try
            {
                var rc = await _grpcClient.StopRecordingAsync(new StopRequest());

                return rc.Rc;
            }
            catch (Exception) { }

            return false;
        }

    }
}