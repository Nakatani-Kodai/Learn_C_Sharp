using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_C_Sharp.Classes.Chapter4
{
    public class YearMonth
    {
        public int Year { get; private set;}

        public int Month { get; private set;}

        public void YearMont(int year, int month)
        {
            this.Year = year;
            this.Month = month;
        }


        public YearMonth AddOneMonth()
        {
            
        }
    }
}
