using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgeDesignPattern.Abstraction;

namespace BridgeDesignPattern.RefinedAbstraction
{
    public class NetBankingPayment : Payment
    {
        public override void MakePayment()
        {
            _PaymentSystem.ProcessPayment("Net Banking Payment");
        }
    }
}
