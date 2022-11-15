using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Самостоятельная_работа_14.Абстрактные_классы
{
    class Program
    {
        static void Main(string[] args)
        {//создаем экземпляр метода со значением Title по умолчанию
            Cat cat = new Cat();
            //присваиваем новое значение Title
            cat.Title = "Кошка";
            //вызываем неабстрактный метод из родительского абстрактного класса
            cat.ShowInfo();

            Dog dog = new Dog();

            dog.Title = "Собака";
            dog.ShowInfo();

            Console.ReadKey();

        }
    }
}
