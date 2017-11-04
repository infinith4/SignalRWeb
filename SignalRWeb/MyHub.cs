using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalRWeb
{
    public class MyHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }
        public void SendMessage(string message)
        {
            Clients.All.recieveMessage(message);
        }
    }
}