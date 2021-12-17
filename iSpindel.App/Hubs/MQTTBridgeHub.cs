using iSpindel.App.Clients;
using iSpindel.App.Messages.MQTTBridge;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace iSpindel.App.Hubs
{
    public class MqttBridgeHub : Hub<IMqttBridgeClient>
    {
        private readonly ILogger<MqttBridgeHub> logger;

        public MqttBridgeHub(ILogger<MqttBridgeHub> logger)
        {
            this.logger = logger;
        }

        public override Task OnConnectedAsync()
        {
            this.logger.LogDebug($"[{this.Context.ConnectionId}] Connected");
            return Task.CompletedTask;
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            this.logger.LogDebug($"[{this.Context.ConnectionId}] Disconnected {exception?.Message}");
            return Task.CompletedTask;
        }

        public async Task<SubscribedMessage> Subscribe(SubscribeMessage message)
        {
            // TODO check for valid device id
            this.logger.LogDebug($"[{this.Context.ConnectionId}] Subscribe {message?.DeviceId ?? "none"}");
            await this.Groups.AddToGroupAsync(this.Context.ConnectionId, message.DeviceId);
            //await this.Clients.Caller.Subscribed(new SubscribedMessage() { DeviceId = message.DeviceId});
            return new SubscribedMessage() { DeviceId = message.DeviceId };
        }

        public async Task<UnsubscribedMessage> Unsubscribe(UnsubscribeMessage message)
        {
            // TODO check for valid device id
            this.logger.LogDebug($"[{this.Context.ConnectionId}] Unsubscribe {message?.DeviceId ?? "none"}");
            await this.Groups.RemoveFromGroupAsync(this.Context.ConnectionId, message.DeviceId);
            //await this.Clients.Caller.Unsubscribed(new UnsubscribedMessage() { DeviceId = message.DeviceId });
            return new UnsubscribedMessage() { DeviceId = message.DeviceId };
        }
    }
}
