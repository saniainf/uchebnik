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
    Square[,] square = new Square[20, 40];
    bool draw = true;
    ConsoleKeyInfo keys;
    int directX = 0;
    int directY = 0;

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
            keys = Console.ReadKey();
        } while (keys.Key != ConsoleKey.Escape);
    }

    void InputKey()
    {
        if (keys.Key == ConsoleKey.UpArrow)
        {
            directY = -1;
            directX = 0;
            draw = true;
        }
        if (keys.Key == ConsoleKey.DownArrow)
        {
            directY = 1;
            directX = 0;
            draw = true;
        }
        if (keys.Key == ConsoleKey.LeftArrow)
        {
            directY = 0;
            directX = -1;
            draw = true;
        }
        if (keys.Key == ConsoleKey.RightArrow)
        {
            directY = 0;
            directX = 1;
            draw = true;
        }
    }

    void UpDate()
    {
        for (int a = 0; a < square.GetLength(0); a++)
        {
            for (int b = 0; b < square.GetLength(1); b++)
            {
                square[a, b].ch = 'X';
            }
        }

        for (int a = snake.Count - 1; a >= 0; a--)
        {
            square[snake[a].coordY, snake[a].coordX].ch = snake[a].body;
            square[snake[a].coordY, snake[a].coordX].color = snake[a].color;
        }

        UpdateSnakeBody();
    }

    void UpdateSnakeBody()
    {
        for (int a = snake.Count - 1; a > 0; a--)
        {
            snake[a].coordX = snake[a - 1].coordX;
            snake[a].coordY = snake[a - 1].coordY;
        }
        snake[0].coordX += directX;
        snake[0].coordY += directY;
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
            snake.Add(new Snake(5,5, ConsoleColor.Green, a.ToString()));
        }
        snake[0].color = ConsoleColor.Yellow;

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
    public char body;

    public Snake(int x, int y, ConsoleColor color, string body)
    {
        coordX = x;
        coordY = y;
        this.color = color;
        this.body = Convert.ToChar(body);
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