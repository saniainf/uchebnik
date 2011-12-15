using System;

interface IEven
{
    bool IsOdd(int x);
    bool IsEven(int x);
}

class MyClass : IEven
{
    /* явная реализация метода
     * метод privat по умолчанию
    */
    bool IEven.IsOdd(int x)
    {
        if ((x % 2) != 0) return true;
        else return false;
    }

    /* обычная реализация */
    public bool IsEven(int x)
    {
        IEven o = this; // ссылка типа интерфейса на вызывающий объект

        return !o.IsOdd(x);
    }
}

class Chapter2
{
    public Chapter2()
    {
        MyClass ob = new MyClass();
        bool result;

        result = ob.IsEven(4);
        if (result) Console.WriteLine("4 is even.");

        // result = ob.IsOdd(4); // Error, IsOdd not exposed. 
        /* ссылке типа интерфейса присваиваем
         * объект класса реализующкго интерфейс
        */
        IEven iRef = ob;
        result = iRef.IsOdd(3);
        if (result) Console.WriteLine("3 is odd.");
    }
}