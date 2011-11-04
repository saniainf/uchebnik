/*
 * Многостроковый коментарий
 * еще
 * еще =)
 */

//одностроковый коментарий

using System;

class Example
{
    static void Main()  //static метод может вызываться без создания объекта класса.
    /* static можно использовать с классами, полями, методами, свойствами,
     * операторами, событиями и конструкторами,
     * но нельзя — с индексаторами, деструкторами или типами, отличными от классов
     */
    {
        int x, y;
        double xD, yD;

        x = 100;
        y = x / 3; //в int отсекается дробная часть. !!без округления
        xD = 100d; //присваевается константа тип double
        yD = xD / 3;

        Console.WriteLine("X  " + x);
        Console.WriteLine("Y  " + y);
        Console.WriteLine("X double  " + xD);
        Console.WriteLine("Y double  " + yD);

        for (int a = 1; a <= 10; a++)
        {
            /* старая конструкция
            if (a % 2 == 0) Console.WriteLine("цикл четный : " + a);
            else Console.WriteLine("цикл нечетный : " + a);
             */

            Console.WriteLine((a % 2 == 0) ? ("цикл четный: " + a) : ("цикл нечетный: " + a)); //сокращенный if
            Console.WriteLine("цикл {0}четный {1}", a % 2 == 0 ? "" : "не", a); //сокращенный if
            Console.WriteLine("{0}", a % 2 == 0 ? "цикл четный: " : "цикл нечетный: ", a); //сокращенный if
            Console.WriteLine("sin {0}", Math.Sin(a / 10f));
        }
    }
}