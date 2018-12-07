using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace CalebCurrySignalRTutorial
{
    public class MyHub : Hub
    {
        public void Announce(string message)
        {
            //when this method gets called we call the announce method on all the clients. 
            Clients.All.Announce(message);
        }
    }
}