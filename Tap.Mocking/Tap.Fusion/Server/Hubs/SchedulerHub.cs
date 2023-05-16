using Microsoft.AspNetCore.SignalR;
using Tap.Fusion.Shared;

namespace Tap.Fusion.Server.Hubs
{
    public class SchedulerHub : Hub
    {
        public async Task SendData(string user, List<AppData> addedData, List<AppData> changedData, List<AppData> deletedData)
        {
            await Clients.Others.SendAsync("ReceiveData", user, addedData, changedData, deletedData);
        }
    }
}
