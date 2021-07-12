using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class SeatChart // Class name
    {
        public SeatChart(string PaidSeat) : this(PaidSeat, 10) // Paid seat for movie goer
        {

        }
        public SeatChart(string PaidSeat, int Payment) // Payment of seat
        {
            string CustSeating = PaidSeat; // String of customer's seat
            int Price = Payment;
        }
    }
}
