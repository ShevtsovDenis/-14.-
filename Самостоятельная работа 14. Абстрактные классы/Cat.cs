using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Самостоятельная_работа_14.Абстрактные_классы
{//создаем класс, который наследует архитектуру родительского класса
    class Cat : Animal
    {//создаем поля для названия
        string title;
        //переопределяем свойство названия 
        public override string Title
        {
            get => title;
            set => title = value;
        }
        //переопределяем абстрактный метод, который выводит звук 
        public override void Say()
        {
            Console.WriteLine("Мяу");
        }
    }
}
