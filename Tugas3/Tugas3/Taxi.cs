using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas3
{
    class Taxi
    {
        public string driver { get; set; }
        public string onduty { get; set; }
        public string number { get; set; }

        public void taxiinfo()
        {
            Console.WriteLine("Driver Name  : {0}", driver);
            Console.WriteLine("Onduty       : {0}", onduty);
            Console.WriteLine("Numpassenger : {0}", number);
            Console.WriteLine("--------------------------");
        }
        public void pickuppassenger()
        {
            Console.WriteLine("Sedang menjemput penumpang\n", driver);
        }
        public void dropofpassenger()
        {
            Console.WriteLine("Selesai mengantar penumpang\n");
        }

    }
}
