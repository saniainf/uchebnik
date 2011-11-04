using System;

class Example
{
    static void Main()
    {
        bool i, j;
        int x = 0, y = 0;

        for (int a = 1; a <= 5; a++)
        {
            for (int b = 1; b <= 5; b++)
            {
                Console.WriteLine("{0} / {1}:\tint: {2}\tostatok: {3}", a, b, a / b, a % b); //деление по модулю %, получается остаток от деления
            }
        }

        for (int a = 1; a <= 5; a++)
        {
            for (int b = 1; b <= 5; b++)
            {
                i = (a % 2 == 0) ? true : false;
                j = (b % 2 == 0) ? true : false;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("first: {0}\ttwo: {1}", i, j);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\timpl: {0}", (!i | j)); // импликация :-) всегда true, если (false true) тогда false

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("x = {0}", (i & (x++ < 100) ? x : x)); //простое И. вторая часть всеравно выполняется и X инкременируется
                Console.WriteLine("\ty = {0}\n", (i && (y++ < 100) ? y : y)); // укороченое И. вторая часть не выполяняется если первая сразу несоответствует.

                Console.ResetColor();
            }
        }

        for (int a = 1; a <= 10; a++)
        {
            x = y = a;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("num: {0}\t", x);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("{0}\t", ((a & 1) == 1) ? "нечет" : "чет"); //сравнивание последнего байта, если == 1 то нечет.
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("чет: {0}\t", x &= 0xFFFE); // изменение последнего байта на 0
            Console.WriteLine("нечет: {0}\n", y |= 1); // изменение последнего байта на 1
            Console.ResetColor();
        }

        /* R1 = X ^ Y
         * R2 = R1 ^ Y
         * R2 == X
         * */
        int r1 = 321321 ^ 549;
        Console.WriteLine("{0}", r1);
        Console.WriteLine("{0}", r1 ^ 549);
        Console.WriteLine();

        /* поразрядный ~ НЕ
         * */
        for (int a = -12; a <= 12; a++)
        {
            int b = a;
            Console.WriteLine("{0}\t~ {1}", a, ~b);
        }


        /* Операторы сдвига >> << побайтово
         * и вывод на консоль в бин форме
         * */
        Console.ForegroundColor = ConsoleColor.Green;
        x = 1;
        for (int a = 0; a < 8; a++)
        {
            for (int razr = 128; razr > 0; razr /= 2)
            {
                Console.Write("{0}", ((x & razr) == 0) ? "0" : "1");
            }
            Console.WriteLine();
            x = x << 1;
        }

        x = 128;
        for (int a = 0; a < 8; a++)
        {
            for (int razr = 128; razr > 0; razr /= 2)
            {
                Console.Write("{0}", ((x & razr) == 0) ? "0" : "1");
            }
            Console.WriteLine();
            x = x >> 1;
        }
        Console.WriteLine();
        Console.ResetColor();

        /* оператор ?: 
         * if ? then : else
         * */
        Console.ForegroundColor = ConsoleColor.Yellow;
        for (int a = -5; a <= 5; a++)
        {
            if (a != 0 ? ((a & 1) == 1) : false)
                Console.WriteLine("100 / {0} = {1}", a, 100 / a);
        }
    }
}