using System;

class Chapter6
{
    Overload ovld;

    public Chapter6()
    {
        ovld = new Overload();
        ovld.OvlDemo("adasd", 5); // перегрузка 2 методов
        ovld.OvlDemo(5, "asdasd");//
        Console.WriteLine("\n\n");

        OverloadConstr obj1 = new OverloadConstr("test"); //перегрузка конструктора
        OverloadConstr obj2 = new OverloadConstr(4, 3);
        OverloadConstr obj3 = new OverloadConstr(obj2);
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
} //перегрузка методов

class OverloadConstr
{
    public int a, b;

    /*первый*/
    public OverloadConstr(string str)  //сперва происходит вызов 2 контруктора
        : this(5, 5)                   //затем выполняется тело этого 
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("constr 1");
        Console.WriteLine(str + "\n");
        Console.ResetColor();
    }

    /*второй*/
    public OverloadConstr(int a, int b)
    {
        this.a = a;
        this.b = b;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("constr 2");
        Console.WriteLine("   {0},  {1}\n", a, b);
        Console.ResetColor();
    }

    /*третий*/
    public OverloadConstr(OverloadConstr obj)
        : this(obj.a, obj.b)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("constr 3");
        Console.ResetColor();
    }
} //перегрузка конструкторов с this.