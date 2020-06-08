using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{

    public interface IServer
    {
        void TakeOrder(string order);
        string DeliverOrder();
        void ProcessPayment(string payment);
    }

    class Server : IServer
    {
        private string Order;
        public string DeliverOrder()
        {
            return Order;
        }

        public void ProcessPayment(string payment)
        {
            Console.WriteLine("Payment for order (" + payment + ") processed.");
        }

        public void TakeOrder(string order)
        {
            Console.WriteLine("Server takes order for "+ order);
            Order = order;
        }
    }

    class NewServerProxy : IServer
    {
        private string Order;
        Server _server = new Server();
        public string DeliverOrder()
        {
            return Order;
        }

        public void ProcessPayment(string payment)
        {
            Console.WriteLine("New trainee cannot process payments yet!");
            _server.ProcessPayment(payment);
        }

        public void TakeOrder(string order)
        {
            Console.WriteLine("Server takes order for " + order);
            Order = order;
        }
    }
}
