using System;

class Example
{
    static void Main()
    {
        for (int x = 1; x < 100; x++)
        {
            Console.Clear();
            for (int a = 1; a <= 20; a++)
            {
                for (int b = 1; b <= 30; b++)
                {
                    Console.Write("a");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        for (; ; )
        {
            string asd;
            asd = Console.ReadLine();
            if (asd == "1") return;
        }
    }
}