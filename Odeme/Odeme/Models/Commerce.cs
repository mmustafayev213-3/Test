using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odeme.Models
{
    internal class Commerce
    {
        public DateTime OneHour { get; set; }
        public int HourValue { get; set; }
        public int ThreeHour { get; set; }
        //public int ThreeHourValue { get; set; }
        public int FiveHour { get; set; }
        //public int FiveHourValue { get; set; }
        public double TotalMoney { get; set; }
        public void Payment()
        {
            if (TotalMoney>=HourValue)
            {
                Console.WriteLine($"Sizin secidiyiniz pakete gore {HourValue} bu qeder miqdar cixilacaq ");
                TotalMoney = TotalMoney - HourValue;
                
                Console.WriteLine($"Umumi mebleq:{TotalMoney}");
            }
            else
            {
                Console.WriteLine("Pulunuz Catmir");
            }
        }
    }
}
