using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;

namespace SignalRTest.Hubs
{
    [Authorize]
    public class ChatHub : Hub
    {
        public void SendText(string text)
        {
            var message = Context.User.Claims.Select(x => x.Value) + " " + text;
            Clients.All.SendAsync("ReceiveText", message);
        }
    }
}
