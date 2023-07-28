using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgeDesignPattern.Implementor;

namespace BridgeDesignPattern.ConcreteImplementor
{
    public class CityPaymentSystem : IPaymentSystem
    {
        public void ProcessPayment(string paymentSystem)
        {
            Console.WriteLine("Using CityBank Gateway for " + paymentSystem);
        }
    }
}
