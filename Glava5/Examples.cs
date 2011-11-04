using System;

class Example
{
    static void Main()
    {
        string numb;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("1. Цикл For\n2. Цикл While\n3. Break Continue\n\n");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Введи номер части: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        numb = Console.ReadLine();
        Console.ResetColor();
        Console.Write("\n\n");

        switch (numb)
        {
            case "1":
                Console.Clear();
                Chap1();
                break;
            case "2":
                Console.Clear();
                Chap2();
                break;
            case "3":
                Console.Clear();
                Chap3();
                break;
            default:
                Console.WriteLine("не вводи всякую херню\n\n\n");
                Main();
                break;
        }
    }

    static void Chap1()
    {
        bool done = true;

        /* for (x = 0; == true; x++)
         * цикл for может быть с двумя переменными
         * можно использовать вызов
         * прерывание в самом цикле
         * части управления циклом могут отсутствовать
         * for (;;) бесконечный цикл с break
         * */
        for (int a = 0, b = 10; done; b = Decr(b)) 
        {
            done = (a < b);
            Console.WriteLine("a: {0}\tb: {1}", a, b);
            a++;
        }
    }

    static int Decr(int a)
    {
        a--;
        return a;
    }

    static void Chap2()
    {
        int a = 0;
        /* while ( == true)
         * */
        while (a <= 10)
        {
            Console.WriteLine("a = {0}", a);
            a++;
        }

        for (; a <= 20; )  //из for можно сделать тоже while
        {
            Console.WriteLine("a = {0}", a);
            a++;
        }

        a = 123456789;
        int nextdigit;
        Console.WriteLine("Chislo:\t\t" + a);
        Console.Write("naooborot:\t");

        do
        {
            nextdigit = a % 10;
            Console.Write(nextdigit);
            a /= 10;
        } while (a > 0);

        Console.WriteLine();

    }

    static void Chap3()
    {
        for (int a = 4; a <= 1000; a++)
        {
            if ((a % 33 == 0) && a != 33)
            {
                Console.WriteLine("a = {0}", a);
                break;                           //break выход из цикла
            }
        }

        for (int a = 0; a <= 100; a++)
        {
            if ((a % 2) != 0) continue;         //continue преждевременное прерывание шага итерации
            Console.Write("{0} ", a);
        }

        Console.WriteLine("");
    }
}