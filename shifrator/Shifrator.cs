using System;

class Shifrator
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Введи строку для шифрования:  ");
        Console.ForegroundColor = ConsoleColor.Green;
        string Stroka = Console.ReadLine();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Введи ключ:  ");
        Console.ForegroundColor = ConsoleColor.Green;
        string Key = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine();

        int key = Convert.ToInt32(Key);
        
        //massiv
        char[] cryptstring = Stroka.ToCharArray();

        for (int a = 0; a < cryptstring.Length; a++)
        {
            Console.Write("{0}", cryptstring[a]);
        }

        Console.WriteLine();

        for (int a = 0; a < cryptstring.Length; a++)
        {
            cryptstring[a] = (char) (cryptstring[a] ^ key);
        }

        Console.WriteLine();

        for (int a = 0; a < cryptstring.Length; a++)
        {
            Console.Write("{0}", cryptstring[a]);
        }

        Console.WriteLine();

        for (int a = 0; a < cryptstring.Length; a++)
        {
            cryptstring[a] = (char)(cryptstring[a] ^ key);
        }

        Console.WriteLine();

        for (int a = 0; a < cryptstring.Length; a++)
        {
            Console.Write("{0}", cryptstring[a]);
        }

        Console.WriteLine();

        /* R1 = X ^ Y
         * R2 = R1 ^ Y
         * R2 == X
         * 
        int r1 = 321321 ^ 539;
        Console.WriteLine("{0}", r1);
        Console.WriteLine("{0}", r1 ^ 549);
         */
    }
}