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
                Console.Write(board[i, j].chr);
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
                ChrArray[i, j].chr = 'G';
                ChrArray[i, j].color = (ConsoleColor)(5);
            }
    }

    void Rnd()
    {
        Random rnd = new Random();
        int size = Height * Width;

        int[] arrColor = new int[size];

        for (int i = 0; i < size / 15; i++)
        {
            for (int j = 0; j < 15; j++)
            {

            }
        }

        List<int> ar = new List<int>();
        for (int i = 0; i < 15; i++)
            ar.Add(i);

        int[] result = new int[15];
        for (int i = 0; i < 15; i++)
        {
            int pos = rnd.Next(0, ar.Count);
            result[i] = ar[pos];
            ar.RemoveAt(pos);
        }

        foreach (int num in result)
            Console.Write(num + " ");
        Console.WriteLine();
    }
}

struct Symbol
{
    public ConsoleColor color;
    public char chr;
}