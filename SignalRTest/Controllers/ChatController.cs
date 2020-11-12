using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SignalRTest.Hubs;

namespace SignalRTest.Controllers
{
    public class ChatController : Controller
    {
        private IHubContext<ChatHub> _context;
        public ChatController(IHubContext<ChatHub> context)
        {
            _context = context;
        }
        public IActionResult Send()
        {
            return View();
        }
    }
}
