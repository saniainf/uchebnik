using System;

class Example
{
    static void Main()
    {
        byte bt = 10;
        char ch1 = 'a', ch2 = 'b';

        bt = (byte)(bt * bt); //обязательно приведение типов, так как вычесления происходят в int
        ch1 = (char)(ch1 + ch2); //обязательно приведение типов, так как вычесления происходят в int
        Console.WriteLine(bt);
        Console.WriteLine(ch1);

        Console.WriteLine("первый\tвторой\tделение");
        for (int a = 1; a <= 3; a++)
        {
            Console.WriteLine("квадратный корень из: {0} равен: {1}", a, Math.Sqrt(a));
            Console.WriteLine("целая часть: {0}", (int)Math.Sqrt(a));
            Console.WriteLine("дробная часть: {0:#.####}", Math.Sqrt(a) - (int)Math.Sqrt(a)); //результат всеравно в double

            for (int b = 1; b <= 3; b++)
            {
                double d = (double)a / b;  //приведение результата к типу double // (тип результата) (уравнение в скобках) или переменная;
                Console.WriteLine("{0}\t{1}\t{2:#.###}", a, b, d); // форматирование
                Console.WriteLine(@"{0}///////{1}\\\\\\\{2:#.###}", a, b, d); // символ @ позволяет форматировать в коде и использовать символы
            }

        }
    }
}