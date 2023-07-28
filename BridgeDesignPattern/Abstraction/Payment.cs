using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgeDesignPattern.Implementor;

namespace BridgeDesignPattern.Abstraction
{
    public abstract class Payment
    {
        public IPaymentSystem _PaymentSystem; 
        public abstract void MakePayment();
    }
}
