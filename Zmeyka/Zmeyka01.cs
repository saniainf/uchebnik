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
    Snake snake;
    BoardPiece[,] boardBase = new BoardPiece[20, 40];
    BoardPiece[,] boardTmp = new BoardPiece[20, 40];
    ConsoleKeyInfo keys;
    //int directX = 0;
    //int directY = 0;
    public Random rnd = new Random();

    public DriverGame()
    {
        Initial();
        Run();
    }

    void Initial()
    {

        snake = new Snake(5, 5, ConsoleColor.Green, "8");

        for (int a = 0; a < boardBase.GetLength(0); a++)
        {
            for (int b = 0; b < boardBase.GetLength(1); b++)
            {
                boardBase[a, b] = new BoardPiece(ConsoleColor.Yellow, '0');
                boardTmp[a, b] = new BoardPiece(ConsoleColor.Yellow, ' ');
            }
        }
    }

    void Run()
    {
        do
        {
            UpDate();
            Draw();
            //if (Console.KeyAvailable == true)
            //{
            //    keys = Console.ReadKey();
            //    InputKey();
            //}
            Thread.Sleep(250); // задержка
            CopyTmp();
        } while (keys.Key != ConsoleKey.Escape);
    }

    //void InputKey()
    //{
    //    if (keys.Key == ConsoleKey.UpArrow)
    //    {
    //        directY = -1;
    //        directX = 0;
    //    }
    //    if (keys.Key == ConsoleKey.DownArrow)
    //    {
    //        directY = 1;
    //        directX = 0;
    //    }
    //    if (keys.Key == ConsoleKey.LeftArrow)
    //    {
    //        directY = 0;
    //        directX = -1;
    //    }
    //    if (keys.Key == ConsoleKey.RightArrow)
    //    {
    //        directY = 0;
    //        directX = 1;
    //    }
    //}

    void UpDate()
    {
        for (int i = 0; i < 7; i++)
        {
            int y = rnd.Next(0, 20);
            int x = rnd.Next(0, 40);
            boardTmp[y, x].ch = '8';
            boardBase[y, x].color = ConsoleColor.Blue;
        }
        //UpdateSnakeBody();
        //board[snake.coordY, snake.coordX].ch = snake.body;
        //board[snake.coordY, snake.coordX].color = snake.color;
    }

    //void UpdateSnakeBody()
    //{
    //    snake.coordX += directX;
    //    snake.coordY += directY;
    //}

    void Draw()
    {
        for (int a = 0; a < boardBase.GetLength(0); a++)
        {
            for (int b = 0; b < boardBase.GetLength(1); b++)
            {
                if (boardBase[a, b].ch == boardTmp[a, b].ch)
                {
                    Console.ForegroundColor = boardBase[a, b].color;
                    Console.CursorLeft = b;
                    Console.CursorTop = a;
                    Console.Write(boardBase[a, b].ch);
                }
            }
        }
    }

    void CopyTmp()
    {
        for (int a = 0; a < boardBase.GetLength(0); a++)
        {
            for (int b = 0; b < boardBase.GetLength(1); b++)
            {
                boardTmp[a, b] = boardBase[a, b];
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

class BoardPiece
{
    public ConsoleColor color;
    public char ch;

    public BoardPiece(ConsoleColor color, char ch)
    {
        this.color = color;
        this.ch = ch;
    }
}