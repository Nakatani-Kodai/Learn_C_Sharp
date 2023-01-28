using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_C_Sharp.Classes
{
    public class InchToMeter
    {
        private double Inch { get; set; }

        private double Meter { get; set; }


        public void ConsoleResult()
        {
            var inchToMeter = 0.025;

            for (var num = 0; num <= 10; num++)
            {
                System.Console.WriteLine("{0}インチ⇒{1}メートル", num, Math.Round(num * inchToMeter, 5));
            }

        }
    }
}
