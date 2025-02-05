using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playstore
{
    public interface IPayment
    {
        void MakePayment(int acno, int amount);

        void PaymentStatus(int transactions);

        void CancelPayment();
    }



}
