using System;

class Example
{
    static char[,] arrr = new char[20, 30];
    static bool draw = false;
    static ConsoleKeyInfo keys;
    static int x = 0;
    static int y = 0;

    static void Main()
    {
        for (; ; )
        {
            InputKey();
            UpDate();
            if (draw) Draw();
        }
    }

    static void InputKey()
    {
        keys = Console.ReadKey();
        if (keys.Key == ConsoleKey.UpArrow)
        {
            y--;
            draw = true;
        }
        if (keys.Key == ConsoleKey.DownArrow)
        {
            y++;
            draw = true;
        }
        if (keys.Key == ConsoleKey.LeftArrow)
        {
            x--;
            draw = true;
        }
        if (keys.Key == ConsoleKey.RightArrow)
        {
            x++;
            draw = true;
        }
    }

    static void UpDate()
    {
        for (int a = 0; a < arrr.GetLength(0); a++)
        {
            for (int b = 0; b < arrr.GetLength(1); b++)
            {
                arrr[a, b] = '.';
            }
        }

        for (int a = y; a < y + 3; a++)
        {
            for (int b = x; b < x + 3; b++)
            {
                arrr[a, b] = '8';
            }
        }
    }

    static void Draw()
    {
        Console.Clear();
        for (int a = 0; a < arrr.GetLength(0); a++)
        {
            for (int b = 0; b < arrr.GetLength(1); b++)
            {
                Console.Write(arrr[a, b]);
            }
            Console.WriteLine();
        }
        draw = false;
    }
}