using System;
using System.Collections.Generic;
using System.Threading;

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
    Board[,] board = new Board[20, 40];
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
            UpDate();
            Draw();
            if (Console.KeyAvailable == true)
            {
                keys = Console.ReadKey(true);
                InputKey();
            }
            Thread.Sleep(250); // задержка
        } while (keys.Key != ConsoleKey.Escape);
    }

    void InputKey()
    {
        if (keys.Key == ConsoleKey.UpArrow)
        {
            directY = -1;
            directX = 0;
        }
        if (keys.Key == ConsoleKey.DownArrow)
        {
            directY = 1;
            directX = 0;
        }
        if (keys.Key == ConsoleKey.LeftArrow)
        {
            directY = 0;
            directX = -1;
        }
        if (keys.Key == ConsoleKey.RightArrow)
        {
            directY = 0;
            directX = 1;
        }
    }

    void UpDate()
    {
        for (int a = snake.Count - 1; a >= 0; a--)
        {
            board[snake[a].coordY, snake[a].coordX].ch = snake[a].body;
            board[snake[a].coordY, snake[a].coordX].color = snake[a].color;
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
        for (int a = 0; a < board.GetLength(0); a++)
        {
            for (int b = 0; b < board.GetLength(1); b++)
            {
                Console.ForegroundColor = board[a, b].color;
                Console.Write(board[a, b].ch);
            }
            Console.WriteLine();
        }
    }

    void Initial()
    {
        for (int a = 0; a < 10; a++)
        {
            snake.Add(new Snake(5, 5, ConsoleColor.Green, a.ToString()));
        }
        snake[0].color = ConsoleColor.Yellow;

        for (int a = 0; a < board.GetLength(0); a++)
        {
            for (int b = 0; b < board.GetLength(1); b++)
            {
                board[a, b] = new Board(ConsoleColor.Black, ' ');
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

class Board
{
    public ConsoleColor color;
    public char ch;

    public Board(ConsoleColor color, char ch)
    {
        this.color = color;
        this.ch = ch;
    }
}