using System;

class Example
{
    static void Main()
    {
        int count;
        Destruct ob = new Destruct(0);

        for (count = 1; count < 100000; count++)
            ob.Generator(count);

        Console.WriteLine("готово");
    }
}

class Destruct
{
    public int x;

    public Destruct(int i)
    {
        x = i;
    }

    ~Destruct()
    {
        Console.WriteLine("Destroy " + x);
    }

    public void Generator(int i)
    {
        Destruct o = new Destruct(i);
    }
}