using JPSAGE_ERP.Application.Models.SiteReporting;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Threading.Tasks;

namespace JPSAGE_ERP.WebAPI.SignalR
{
    [Authorize]
    public class ChatHub : Hub
    { 
        public async Task AddToGroup(string userEmail)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, userEmail);
        }

        public async Task SendNotificationMessage(NotificationDto notification)
        {
            DefaultContractResolver contractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            };

            var response = JsonConvert.SerializeObject(notification, new JsonSerializerSettings
            {
                ContractResolver = contractResolver,
                Formatting = Formatting.Indented
            });

            await Clients.Group(notification.UserEmail).SendAsync("ReceiveMessage", notification.UserEmail, response);
        }
    }
}
