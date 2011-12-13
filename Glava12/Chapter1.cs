using System;

class Chapter1
{
    InterfaceRealise1 obj1 = new InterfaceRealise1();
    InterfaceRealise2 obj2 = new InterfaceRealise2();
    IClass baseObj;

    public Chapter1()
    {
        obj1.PrintF();
        obj2.PrintF();

        /* по ссылке на интерфейс можно ссылаться
         * на все объекты реализующие интерфейс
         * */
        baseObj = obj1;
        baseObj.PrintF();

        baseObj = obj2;
        baseObj.PrintF();
    }
}

public interface IClass //интерфейс
{
    int alpha();
    void Reset();
    void PrintF();

    int Value { get; set; }
}

class InterfaceRealise1 : IClass
{
    int i = 1;

    public int Value
    {
        get { return i; }
        set { i = value; }
    }

    public int alpha()
    {
        return 0;
    }

    public void Reset()
    {

    }

    public void PrintF()
    {
        Console.WriteLine("from Realise1 " + i);
    }
}

class InterfaceRealise2 : IClass
{
    int i = 2;

    public int Value
    {
        get { return i; }
        set { i = value; }
    }

    public int alpha()
    {
        return 0;
    }

    public void Reset()
    {

    }

    public void PrintF()
    {
        Console.WriteLine("from Realise2 " + i);
    }
}