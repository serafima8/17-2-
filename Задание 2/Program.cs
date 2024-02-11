using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Bus> buses = new List<Bus>();
            buses.Add(new Bus("LOTOS", 40, 25));
            List<Tourist> tourists = new List<Tourist>();
            tourists.Add(new Tourist("HIGER", 45, 30,15));
            foreach (var bs in buses)
            {
                bs.Print();
                Console.WriteLine($"Общая стоимость всех мест:{bs.Cost()}");
            }
            foreach (var tr in tourists)
            {
                tr.Print();
                Console.WriteLine($"Общая стоимость всех мест:{tr.Cost()}");
            }
            Console.ReadKey();
        }
    }
}
