using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Glava20
{
    class Chapter3
    {
        public Chapter3()
        {
            dynamic str; //динамические типы
            dynamic val; //тип переменой проверяется в процессе выполнения

            str = "string";
            val = 234;

            //bool tst = str; // откомпилеца но будет ошибка выполнения

            Console.WriteLine("str: " + str.ToUpper()); // можно использовать методы stringa
            Console.WriteLine("val: " + val);
        }
    }
}
