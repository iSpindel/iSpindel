using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Client.Connecting;
using MQTTnet.Client.Disconnecting;
using MQTTnet.Client.Options;
using iSpindel.App.Clients;
using iSpindel.App.Hubs;

namespace iSpindel.App.Services
{
    public class MqttClientService : IMqttClientService
    {
        private readonly IMqttClient mqttClient;
        private readonly ILogger<MqttClientService> logger;
        private readonly IHubContext<MqttBridgeHub, IMqttBridgeClient> hubContext;
        private readonly IMqttClientOptions options;

        public MqttClientService(ILogger<MqttClientService> logger, IHubContext<MqttBridgeHub, IMqttBridgeClient> hubContext, IMqttClientOptions options)
        {
            this.logger = logger;
            this.hubContext = hubContext;
            this.options = options;
            this.mqttClient = new MqttFactory().CreateMqttClient();
            ConfigureMqttClient();
        }

        private void ConfigureMqttClient()
        {
            this.mqttClient.ConnectedHandler = this;
            this.mqttClient.DisconnectedHandler = this;
            this.mqttClient.ApplicationMessageReceivedHandler = this;
        }

        public async Task HandleApplicationMessageReceivedAsync(MqttApplicationMessageReceivedEventArgs e)
        {
            var payload = Encoding.UTF8.GetString(e.ApplicationMessage.Payload);

            await this.RelayMessage(e.ApplicationMessage.Topic, payload);
        }

        public async Task HandleConnectedAsync(MqttClientConnectedEventArgs e)
        {
            this.logger.LogInformation("connected to mqtt server");


            // TODO subscribe to topics
            await this.mqttClient.SubscribeAsync("cmnd/chaosSwitch1/power");
        }

        public async Task HandleDisconnectedAsync(MqttClientDisconnectedEventArgs e)
        {
            this.logger.LogInformation("lost connection to mqtt server");

            await Task.Delay(TimeSpan.FromSeconds(5));

            await this.ConnectAsync(CancellationToken.None);
        }

        public async Task RelayMessage(string topic, string payload)
        {
            await this.hubContext.Clients.Group(topic).ReceiveMessage(payload);
            //await this.hubContext.Clients.All.ReceiveMessage(payload);
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            await this.ConnectAsync(cancellationToken);
        }

        private async Task ConnectAsync(CancellationToken cancellationToken)
        {
            try
            {
                await this.mqttClient.ConnectAsync(this.options, cancellationToken);
            }
            catch (Exception ex)
            {
                this.logger.LogWarning(ex, "could not connect to mqtt server");
            }
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            if(cancellationToken.IsCancellationRequested)
            {
                var disconnectOption = new MqttClientDisconnectOptions
                {
                    ReasonCode = MqttClientDisconnectReason.NormalDisconnection,
                    ReasonString = "NormalDiconnection"
                };
                await mqttClient.DisconnectAsync(disconnectOption, cancellationToken);
            }
            await mqttClient.DisconnectAsync();
        }
    }
}