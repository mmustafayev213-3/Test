using Odeme.Models;

namespace Odeme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Commerce commerce = new Commerce();
            int choise;
                Console.WriteLine("1-Saatlik paket ucun '1'-secin");
                Console.WriteLine("2-Saatlik paket ucun '2'-secin");
                Console.WriteLine("3-Saatlik paket ucun '3'-secin");
                Console.WriteLine("4-Cixis");
                choise= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Umumi mebleqi daxil edin:");
                commerce.TotalMoney= Convert.ToDouble(Console.ReadLine());
                switch (choise)
                {
                    case 1:
                        commerce.HourValue = 1;
                        //commerce.Payment();
                    commerce.OneHour=DateTime.Now.AddMinutes(20);
                    Console.WriteLine("==================");
                    Console.WriteLine(commerce.OneHour.Minute);
                    
                    DateTime time = DateTime.Now;
                    //DateTime time= commerce.OneHour.AddMinutes(5);
                    Console.WriteLine(time.Minute);
                    if (commerce.OneHour.Minute==DateTime.Now.Minute)
                    {
                        Console.WriteLine("Sizin Vaxtiniz bitmisdir");
                    }
                    else
                    {
                        Console.WriteLine("sizin hele vatiniz var");
                    }
                    //Console.WriteLine(time.ToLocalTime());
                        break;
                    case 2:
                        commerce.HourValue = 3;
                        commerce.Payment();
                    commerce.ThreeHour = 180;
                        break;
                    case 3:
                        commerce.HourValue = 5;
                        commerce.Payment();
                    commerce.FiveHour = 300;
                            break; 
                    case 4:
                        Console.WriteLine("Saqolun");
                        break;
                    default:
                        Console.WriteLine("Bele secim yoxdur");
                        break;
                }
        }
    }
}