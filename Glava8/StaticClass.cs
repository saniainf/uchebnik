using System;

static class MainService
{
    static int count;

    static public void PrintCount()
    {
        PrintF(count);
    }

    static public void PrintF(string value)
    {
        Console.WriteLine(value);
        count++;
    }

    static public void PrintF(int value)
    {
        Console.WriteLine(value);
        count++;
    }

    static public void PrintF()
    {
        Console.WriteLine();
        count++;
    }
}