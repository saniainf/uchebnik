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

    static public void PrintF(bool value)
    {
        Console.WriteLine(value);
        count++;
    }

    static public void PrintF()
    {
        Console.WriteLine();
        count++;
    }

    static public bool IsEven(double value)
    {
        return (value % 2) == 0 ? true : false;
    }

    static public bool IsOdd(double value)
    {
        return !IsEven(value);
    }
}