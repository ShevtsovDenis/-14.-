using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Самостоятельная_работа_14.Абстрактные_классы
{
    abstract class Animal
    {
        //создаем абстрактное свойство названия животного
        public abstract string Title { get; set; }
        //создаем конструктор со значением названия по умолчанию
        public Animal()
        {
            Title = "млекопитающее";
        }
        //создаем абстрактный метод для вывода звука, которое произносит животное
        public abstract void Say();
        //создаем неабстрактный метод для вывода информации
        public void ShowInfo()
        {
            Console.WriteLine(Title);
            Say();
        }
    }
}
