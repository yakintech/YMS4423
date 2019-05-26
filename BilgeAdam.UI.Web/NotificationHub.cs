using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace BilgeAdam.UI.Web
{
    public class NotificationHub : Hub
    {
        public void Deleteproductalarm(int id)
        {
            Clients.Others.productalarm(id);
        }

        public override Task OnConnected()
        {
            return base.OnConnected();
        }

        public override Task OnDisconnected(bool stopCalled)
        {
            return base.OnDisconnected(stopCalled);
        }
    }
}