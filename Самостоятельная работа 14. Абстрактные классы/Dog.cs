using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Самостоятельная_работа_14.Абстрактные_классы
{
    class Dog:Animal
    {
        string title;

        public override string Title
        {
            get => title;
            set => title = value;
        }

        public override void Say()
        {
            Console.WriteLine("Гав");
        }

    }
}
