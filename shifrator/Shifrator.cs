using System;

class Shifrator
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Введи строку для шифрования:");
        Console.ForegroundColor = ConsoleColor.Green;
        string Stroka = Console.ReadLine();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Введи ключ:");
        Console.ForegroundColor = ConsoleColor.Green;
        string Key = Console.ReadLine();
        //massiv


        /* R1 = X ^ Y
         * R2 = R1 ^ Y
         * R2 == X
         * */
        int r1 = 321321 ^ 549;
        Console.WriteLine("{0}", r1);
        Console.WriteLine("{0}", r1 ^ 549);
    }
}