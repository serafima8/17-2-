using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    class Engineer : Staff
    {
        /// <summary>
        /// создание поля Количество разработанных проектов
        /// </summary>
        private double n;
        /// <summary>
        /// свойство поля n
        /// </summary>
        public double N { get { return n; } set { n = value; } }
        /// <summary>
        /// конструктор с параметрами 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="p"></param>
        /// <param name="k"></param>
        /// <param name="n"></param>
        public Engineer(string name, string surname,double p,double k,double n):base(name,surname,p,k)
        {
            this.n = n;
        }
        /// <summary>
        /// Метод, который выводит информацию о доходе, при условии 
        /// </summary>
        /// <returns></returns>
        new public double Income()
        {
            if (n > 10)
            {
                return base.Income() * (n / 10);
            }
            else
            {
                return base.Income();
            }
        }
        /// <summary>
        /// Метод, который выводит всю информацию
        /// </summary>
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Количество разработанных проектов: {n}");
        }
    }
}
