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
        {
            Cat cat = new Cat("123","говорит Мяу");
            cat.ShowInfo();
            Console.ReadKey();
        }
    }
}
