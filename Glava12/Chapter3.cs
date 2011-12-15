using System;
using System.Collections.Generic;

class Chapter3
{
    Board board = new Board(30, 20);

    public Chapter3()
    {
        Print();
    }

    void Print()
    {
        for (int i = 0; i < board.Height; i++)
        {
            for (int j = 0; j < board.Width; j++)
            {
                Console.ForegroundColor = board[i, j].color;
                Console.Write(board[i, j].chr + " ");
            }
            Console.WriteLine();
        }
    }
}

class Board
{
    /* размеры поля */
    public int Height { get; private set; }
    public int Width { get; private set; }

    _Random rnd = new _Random();
    Random rndTst = new Random();

    /* массив поля */
    Symbol[,] ChrArray;

    /* конструктор */
    public Board(int h, int w)
    {
        Height = h;
        Width = w;
        ChrArray = new Symbol[h, w];
        FillBoard();
    }

    /* индексатор */
    public Symbol this[int indX, int indY]
    {
        get
        {
            return ChrArray[indX, indY];
        }
    }

    /* наполнение поля */
    void FillBoard()
    {
        for (int i = 0; i < Height; i++)
            for (int j = 0; j < Width; j++)
            {
                //ChrArray[i, j].chr = (char)rnd.NextRnd(65, 91);
                ChrArray[i, j].chr = (char)88;
                //ChrArray[i, j].color = (ConsoleColor)(rnd.NextRnd(1, 15));
                ChrArray[i, j].color = (ConsoleColor)(rndTst.Next(0, 15));
            }
    }
}

struct Symbol
{
    public ConsoleColor color;
    public char chr;
}