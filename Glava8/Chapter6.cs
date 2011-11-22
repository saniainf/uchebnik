using System;

class Chapter6
{
    Overload ovld;

    public Chapter6()
    {
        ovld = new Overload();
        ovld.OvlDemo("adasd", 5);
        ovld.OvlDemo(5, "asdasd");
    }
}

class Overload
{
    public void OvlDemo(string str, int a)
    {
        Console.WriteLine("string int");
    }

    public void OvlDemo(int a, string str)
    {
        Console.WriteLine("int string");
    }
}