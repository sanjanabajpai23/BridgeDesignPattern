using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgeDesignPattern.Implementor;

namespace BridgeDesignPattern.ConcreteImplementor
{
    public class IDBIPaymentSystem : IPaymentSystem
    {
        public void ProcessPayment(string paymentSystem)
        {
            Console.WriteLine("Using IDBI Bank Gateway for " + paymentSystem);
        }
    }
}
 