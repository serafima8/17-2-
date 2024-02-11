using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    class Tourist : Bus
    {
        /// <summary>
        /// создание поля стоимости экскурсии
        /// </summary>
        private double excursion;
        /// <summary>
        /// Свойство поля excursion
        /// </summary>
        public double Excursion { get { return excursion; } set { excursion = value; } }
        /// <summary>
        /// Конструктор с параметрами 
        /// </summary>
        /// <param name="stamp"></param>
        /// <param name="place"></param>
        /// <param name="price"></param>
        /// <param name="excursion"></param>
        public Tourist(string stamp, int place, double price,double excursion):base(stamp, place, price)
        {
            this.excursion = excursion;
        }
        /// <summary>
        /// Метод, который выводит информацию общей стоимости всех мест с учетом увеличения цены билета за экскурсию
        /// </summary>
        /// <returns></returns>
        new public double Cost()
        {
            return Place * (Price + Excursion);
        }
        /// <summary>
        /// Метод, который выводит всю информацию об объекте 
        /// </summary>
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Стоимость экскурсии: {excursion}");
        }
    }
}
