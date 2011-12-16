using System;
using System.Threading;
using System.Collections.Generic;

class Example
{
    public static void Main()
    {
        ConsoleKeyInfo cki = new ConsoleKeyInfo();
        List<string> asdasd = new List<string>();

        do
        {
                Console.WriteLine("\nPress a key to display; press the 'x' key to quit.");

                // Your code could perform some useful task in the following loop. However, 
                // for the sake of this example we'll merely pause for a quarter second.
                Thread.Sleep(250); // Loop until input is entered.
                if (Console.KeyAvailable == true)
                {
                    cki = Console.ReadKey(true);
                    Console.WriteLine("You pressed the '{0}' key.", cki.Key);
                }

        } while (cki.Key != ConsoleKey.X);

        //for (int i = 0; i < 20; i++)
        //{
        //    for (int j = 0; j < 60; j++)
        //    {
        //        Console.CursorLeft = j;
        //        Console.CursorTop = i;
        //        Console.Write("x");
        //    }
        //}

        //Console.ReadLine();

        //Main();


        //ConsoleKeyInfo cki;
        //// Prevent example from ending if CTL+C is pressed.
        //Console.TreatControlCAsInput = true;

        //Console.WriteLine("Press any combination of CTL, ALT, and SHIFT, and a console key.");
        //Console.WriteLine("Press the Escape (Esc) key to quit: \n");
        //do
        //{
        //    cki = Console.ReadKey();
        //    Console.Write(" --- You pressed ");
        //    if ((cki.Modifiers & ConsoleModifiers.Alt) != 0) Console.Write("ALT+");
        //    if ((cki.Modifiers & ConsoleModifiers.Shift) != 0) Console.Write("SHIFT+");
        //    if ((cki.Modifiers & ConsoleModifiers.Control) != 0) Console.Write("CTL+");
        //    Console.WriteLine(cki.Key.ToString());
        //} while (cki.Key != ConsoleKey.Escape);

        //int[,] maas = new int[10, 20];
        //int zzz = 0;

        //for (int a = 0; a < maas.GetLength(0); a++)
        //{
        //    for (int b = 0; b < maas.GetLength(1); b++)
        //    {
        //        maas[a, b] = zzz++;
        //    }
        //}

        //for (int a = 0; a < maas.GetLength(0); a++)
        //{
        //    for (int b = 0; b < maas.GetLength(1); b++)
        //    {
        //        Console.Write(maas[a, b] + " ");
        //    }
        //    Console.WriteLine();
        //}

    }
}

