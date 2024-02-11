using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    class Staff
    {
        /// <summary>
        /// Создание поля имени 
        /// </summary>
        private string name;
        /// <summary>
        /// создание поля фамилии
        /// </summary>
        private string surname;
        /// <summary>
        /// создание поля Минимальная зарплата
        /// </summary>
        private double p;
        /// <summary>
        /// создание поля Повышающий коэффициент
        /// </summary>
        private double k;
        /// <summary>
        /// свойство поля name
        /// </summary>
        public string Name { get { return name; } set { name = value; } }
        /// <summary>
        /// свойство поля surname
        /// </summary>
        public string Surname { get { return surname; } set { surname = value; } }
        /// <summary>
        /// свойство поля p
        /// </summary>
        public double P { get { return p; } set { p = value; } }
        /// <summary>
        /// свойство поля k
        /// </summary>
        public double K { get { return k; } set { k = value; } }
        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="p"></param>
        /// <param name="k"></param>
        public Staff(string name, string surname, double p, double k)
        {
            this.name = name;
            this.surname = surname;
            this.p = p;
            this.k = k;
        }
        /// <summary>
        /// Метод, который выводит доход
        /// </summary>
        /// <returns></returns>
        public double Income()
        {
            return k * p;
        }
        /// <summary>
        /// Метод, который выводит всю информацию 
        /// </summary>
        virtual public void Print()
        {
            Console.WriteLine($"Имя: {name}\nФамилия: {surname}\nМинимальная зарплата: {p}\nПовышающий коэффициент: {k}");
        }
    }
}
