using System;
using System.Collections.Generic;

class SnakeGame
{
    static void Main()
    {
        Console.Title = "Super Duper Snake";
        Console.CursorVisible = false;
        DriverGame game = new DriverGame();
    }
}

class DriverGame
{
    private List<Snake> snake = new List<Snake>();
    Snake head = new Snake(5, 5, ConsoleColor.Yellow);
    Snake prev = new Snake(5, 5, ConsoleColor.Black);
    Square[,] square = new Square[20, 40];
    bool draw = true;
    ConsoleKeyInfo keys;

    public DriverGame()
    {
        Initial();
        Run();
    }

    void Run()
    {
        do
        {
            InputKey();
            UpDate();
            if (draw) Draw();
        } while (keys.Key != ConsoleKey.Escape);
    }

    void InputKey()
    {
        keys = Console.ReadKey();
        if (keys.Key == ConsoleKey.UpArrow)
        {
            snake[0].coordY = head.coordY;
            snake[0].coordX = head.coordX;
            head.coordY--;
            draw = true;
        }
        if (keys.Key == ConsoleKey.DownArrow)
        {
            snake[0].coordY = head.coordY;
            snake[0].coordX = head.coordX;
            head.coordY++;
            draw = true;
        }
        if (keys.Key == ConsoleKey.LeftArrow)
        {
            snake[0].coordY = head.coordY;
            snake[0].coordX = head.coordX;
            head.coordX--;
            draw = true;
        }
        if (keys.Key == ConsoleKey.RightArrow)
        {
            snake[0].coordY = head.coordY;
            snake[0].coordX = head.coordX;
            head.coordX++;
            draw = true;
        }
    }

    void UpDate()
    {
        for (int a = snake.Count-1; a > 0; a--)
        {
            snake[a].coordX = snake[a - 1].coordX;
            snake[a].coordY = snake[a - 1].coordY;
        }

        for (int a = 0; a < square.GetLength(0); a++)
        {
            for (int b = 0; b < square.GetLength(1); b++)
            {
                square[a, b].ch = ' ';
            }
        }

        square[head.coordY, head.coordX].ch = '0';
        square[head.coordY, head.coordX].color = head.color;

        for (int a = snake.Count-1; a > 0; a--)
        {
            square[snake[a].coordY, snake[a].coordX].ch = '8';
            square[snake[a].coordY, snake[a].coordX].color = snake[a].color;
        }
    }

    void Draw()
    {
        Console.Clear();
        for (int a = 0; a < square.GetLength(0); a++)
        {
            for (int b = 0; b < square.GetLength(1); b++)
            {
                Console.ForegroundColor = square[a, b].color;
                Console.Write(square[a, b].ch);
            }
            Console.WriteLine();
        }
    }

    void Initial()
    {
        for (int a = 0; a < 10; a++)
        {
            snake.Add(new Snake(5,5, ConsoleColor.Green));
        }

        for (int a = 0; a < square.GetLength(0); a++)
        {
            for (int b = 0; b < square.GetLength(1); b++)
            {
                square[a, b] = new Square(ConsoleColor.Black, ' ');
            }
        }
    }
}

class Snake
{
    public int coordX;
    public int coordY;
    public ConsoleColor color;

    public Snake(int x, int y, ConsoleColor color)
    {
        coordX = x;
        coordY = y;
        this.color = color;
    }
}

class Square
{
    public ConsoleColor color;
    public char ch;

    public Square(ConsoleColor color, char ch)
    {
        this.color = color;
        this.ch = ch;
    }
}