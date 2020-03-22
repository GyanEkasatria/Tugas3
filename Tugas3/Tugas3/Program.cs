using System;

namespace Tugas3
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxi driv1 = new Taxi();
            Taxi driv2 = new Taxi();
            Taxi driv3 = new Taxi();

            driv1.driver ="Panda";
            driv1.onduty = "Yes";
            driv1.number = "5";

            driv2.driver = "Grizzly";
            driv2.onduty = "No";
            driv2.number = "6";

            driv3.driver = "Ice Bear";
            driv3.onduty = "Y/N";
            driv3.number = "4";

            driv1.taxiinfo();
            driv1.pickuppassenger();


            driv2.taxiinfo();
            driv2.dropofpassenger();

            driv3.taxiinfo();
            driv3.pickuppassenger();
            driv3.dropofpassenger();


            Console.ReadKey();
        }
    }
}
