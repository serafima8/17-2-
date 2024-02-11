using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    class Bus
    {
        /// <summary>
        /// Создание поля марки автобуса
        /// </summary>
        private string stamp;
        /// <summary>
        /// Создание поля кол-во мест 
        /// </summary>
        private int place;
        /// <summary>
        /// Создание поля цены билета 
        /// </summary>
        private double price;
        /// <summary>
        /// Свойство поля stamp
        /// </summary>
        public string Stamp { get { return stamp; } set { stamp = value; } }
        /// <summary>
        /// Свойство поля place
        /// </summary>
        public int Place { get { return place; } set { place = value; } }
        /// <summary>
        /// Свойство поля price
        /// </summary>
        public double Price { get { return price; } set { price = value; } }
        /// <summary>
        /// 
        /// Конструктор с параметрами 
        /// </summary>
        /// <param name="stamp"></param>
        /// <param name="place"></param>
        /// <param name="price"></param>
        public Bus(string stamp, int place, double price)
        {
            this.stamp = stamp;
            this.place = place;
            this.price = price;
        }
        /// <summary>
        /// Метод, который выводит информацию общей стоимости всех мест
        /// </summary>
        /// <returns></returns>
        public double Cost()
        {
            return place * price;
        }
        /// <summary>
        /// Метод, который выводит всю информацию об объекте
        /// </summary>
        virtual public void Print()
        {
            Console.WriteLine($"Марка автобуса: {stamp}\nКоличество мест: {place}\nЦена билета: {price}");
        }
    }
}
