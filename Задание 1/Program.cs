using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Staff> staffs = new List<Staff>();
            staffs.Add(new Staff("Артем", "Колесников", 3000, 3));
            List<Engineer> engineers = new List<Engineer>();
            staffs.Add(new Engineer("Егор", "Никифоров", 4000, 15,12));
            foreach(var st in staffs)
            {
                st.Print();
                Console.WriteLine($"Доход:{st.Income()}");
            }
            foreach (var en in engineers)
            {
                en.Print();
                Console.WriteLine($"Доход:{en.Income()}");
            }

            Console.ReadKey();
        }
    }
}
