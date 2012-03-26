using System;

class MyClass
{
    int x;
    int y;

    public MyClass(int i)
    {
        Console.WriteLine("Construct class MyClass(int). ");
        x = y = i;
        Console.WriteLine();
    }

    public MyClass(int i, int j)
    {
        Console.WriteLine("Construct class MyClass(int, int). ");
        x = i;
        y = j;
        Show();
        Console.WriteLine();
    }

    public int Sum()
    {
        return x + y;
    }

    public bool IsBetween(int i)
    {
        if ((x < i) && (i < y)) return true;
        else return false;
    }

    public void Set(int a, int b)
    {
        Console.Write("   " + "в методе Set(int, int). ");
        x = a;
        y = b;
        Show();
    }

    // перегрузка метода 
    public void Set(double a, double b)
    {
        Console.Write("   " + "в методе Set(double, double). ");
        x = (int)a;
        y = (int)b;
        Show();
    }

    public void Show()
    {
        Console.WriteLine("Значение x: {0}, y: {1}", x, y);
    }
}

class AnotherClass
{
    string msg;

    public AnotherClass(string str)
    {
        msg = str;
    }

    public void Show()
    {
        Console.WriteLine(msg);
    }
}

class Demo
{
    static void Main()
    {
        Console.WriteLine("Это заполниетль");
    }
}