using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjaxSignalR
{
    public class MyHub : Hub
    {
        public static void UpdateFromServer(string message)
        {
            var hubContext = GlobalHost.ConnectionManager.GetHubContext<MyHub>();
            hubContext.Clients.All.updateClient("Message from the server:" + message);
        }
    }
}