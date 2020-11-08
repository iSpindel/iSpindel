using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;
using iSpindel.App.DTO;
using Microsoft.AspNetCore.SignalR;

namespace iSpindel.App.Hubs
{
    public interface IClientSpindelDataHub : IClientProxy
    {
        Task RecordingStatusUpdate(string status);
        Task RecordingChanged(int? dataSeriesId);
        Task NewDataPoint(DataPointDTO point);
    }

    public class NotifyHub : Hub<IClientSpindelDataHub>
    {
        protected ConcurrentDictionary<string, HashSet<string>> openGroups = new ConcurrentDictionary<string, HashSet<string>>();

        public async Task Register(int seriesId)
        {
            var groupName = $"grp{seriesId}";

            await this.Groups.AddToGroupAsync(this.Context.ConnectionId, groupName);

            var clients = this.openGroups.GetOrAdd(groupName, (_) => new HashSet<string>());
            clients.Add(this.Context.ConnectionId);
        }

        public async Task Unregister(int seriesId)
        {
            var groupName = $"grp{seriesId}";

            await this.Groups.RemoveFromGroupAsync(this.Context.ConnectionId, groupName);

            if (this.openGroups.TryGetValue(groupName, out var clients))
            {
                clients.Remove(this.Context.ConnectionId);
                if (clients.Count == 0)
                {
                    this.openGroups.Remove(groupName, out var _);
                }
            }
            else
            {
                //cannot unregister from group as the group does not exist
            }
        }

        public async override Task OnDisconnectedAsync(Exception exception)
        {
            var emptyGroups = new List<string>();
            var connectionId = this.Context.ConnectionId;

            foreach (var kv in this.openGroups)
            {
                if (!kv.Value.Contains(connectionId))
                    continue;
                await this.Groups.RemoveFromGroupAsync(connectionId, kv.Key);
                kv.Value.Remove(connectionId);
                if (kv.Value.Count == 0)
                    emptyGroups.Add(kv.Key);
            }

            foreach (var emptyGroup in emptyGroups)
            {
                this.openGroups.Remove(emptyGroup, out var _);
            }
        }
    }
}