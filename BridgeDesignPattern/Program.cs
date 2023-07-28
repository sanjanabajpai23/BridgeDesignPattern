using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgeDesignPattern.Abstraction;
using BridgeDesignPattern.ConcreteImplementor;
using BridgeDesignPattern.RefinedAbstraction;

namespace BridgeDesignPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Payment order = new CardPayment();
            order._PaymentSystem = new CityPaymentSystem();
            order.MakePayment();

            order._PaymentSystem = new IDBIPaymentSystem();
            order.MakePayment();

            order = new NetBankingPayment();
            order._PaymentSystem = new CityPaymentSystem();
            order.MakePayment();
        }
    }
}
