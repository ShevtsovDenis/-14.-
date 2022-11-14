using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Самостоятельная_работа_14.Абстрактные_классы
{//создаем класс, который наследует архитектуру родительского класса
    class Cat : Animal
    {//создаем поля для названия и звука
        string title;
        string sound;
        //переопределяем свойство названия 
        public override string Title
        {
            get => title;
            set => title = value;
        }
        //создаем конструктор, который обращается к базовому и добавляем инициализацию поля звук
        public Cat(string title, string sound)
            :base()
        {
            this.sound = sound;
        }
        //переопределяем абстрактный метод, который выводит звук 
        public override void GetSound()
        {
            Console.WriteLine(sound);
        }
    }
}
