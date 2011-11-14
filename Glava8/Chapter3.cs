using System;

class Chapter3
{
    public Chapter3()
    {
        OtherClass obj1 = new OtherClass(1, 3, ConsoleColor.Red);
        OtherClass obj2 = new OtherClass(4, 6, ConsoleColor.Green);
        OtherClass obj3 = new OtherClass(7, 9, ConsoleColor.Blue);

        Console.ForegroundColor = obj1.color;
        Console.Write("odj1 - ");
        obj1.Draw();

        Console.ForegroundColor = obj2.color;
        Console.Write("obj2 - ");
        obj2.Draw();

        Console.ForegroundColor = obj3.color;
        Console.Write("obj3 - ");
        obj3.Draw();

        obj1.Copy(obj2); // в поля obj1 компируются значения obj2

        Console.ForegroundColor = obj1.color;
        Console.Write("odj1 - ");
        obj1.Draw();

        obj1.alpha = 25; // изменяем поля obj1
        obj1.beta = 25;

        Console.ForegroundColor = obj1.color;
        Console.Write("odj1 - ");
        obj1.Draw();

        Console.ForegroundColor = obj2.color;
        Console.Write("obj2 - ");
        obj2.Draw(); // поля obj2 при этом не меняются

        obj1 = obj3; // теперь ссылку obj3 присваеваем obj1
        
        /*
         * obj1 и obj2 ссылаются на один объект
         * */

        Console.ForegroundColor = obj1.color;
        Console.Write("odj1 - ");
        obj1.Draw();

        obj1.alpha = 25; //// изменяем поля obj1
        obj1.beta = 25;

        Console.ForegroundColor = obj3.color; //поля obj3 "тоже меняются" так как объект один с obj1 
        Console.Write("obj3 - ");
        obj3.Draw();
    }
}

class OtherClass
{
    public int alpha, beta;
    public ConsoleColor color;

    public OtherClass(int a, int b, ConsoleColor color)
    {
        alpha = a;
        beta = b;
        this.color = color;
    }

    public void Copy(OtherClass obj)
    {
        this.alpha = obj.alpha;
        this.beta = obj.beta;
        this.color = obj.color;
    }

    public void Draw()
    {
        Console.ForegroundColor = color;
        Console.WriteLine("alpha {0}, beta {1}\n", alpha, beta);
    }
}