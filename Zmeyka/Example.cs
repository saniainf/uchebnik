using System;

class Example
{
    static char[,] arrr = new char[20, 40]; // {str, stlb}
    static int[,] snake = {
                              {9,7}, // [0, 0][0, 1]
                              {8,7},
                              {7,7},
                              {6,7},
                              {4,7}, // [4, 0][4, 1]
                              {3,7},
                              {2,7},
                              {1,7},
                          };
    static bool draw = true;
    static ConsoleKeyInfo keys;

    static void Main()
    {
        Console.Title = "Super Duper Snake";
        Console.CursorVisible = false;

        do
        {
            InputKey();
            UpDate();
            Draw();
        } while (keys.Key != ConsoleKey.Escape);
    }

    static void InputKey()
    {
        keys = Console.ReadKey();
        if (keys.Key == ConsoleKey.UpArrow)
        {
            --snake[0, 0];
            draw = true;
        }
        if (keys.Key == ConsoleKey.DownArrow)
        {
            ++snake[0, 0];
            draw = true;
        }
        if (keys.Key == ConsoleKey.LeftArrow)
        {
            --snake[0, 1];
            draw = true;
        }
        if (keys.Key == ConsoleKey.RightArrow)
        {
            ++snake[0, 1];
            draw = true;
        }
    }

    static void UpDate()
    {
        int aa = 0;
        for (int a = 0; a < arrr.GetLength(0); a++)
        {
            for (int b = 0; b < arrr.GetLength(1); b++)
            {
                arrr[a, b] = ' ';
            }
        }

        for (int a = 7; a > 0; a--)
        {
            snake[a, 0] = snake[a - 1, 0];
            snake[a, 1] = snake[a - 1, 1]; 
        }

        for (int a = 0; a <= 7 ; a++)
        {
            arrr[snake[a, 0], snake[a, 1]] = '8';
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