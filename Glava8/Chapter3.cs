using System;

class Chapter3
{
    public Chapter3()
    {
        OtherClass obj1 = new OtherClass(1, 3, ConsoleColor.Red);
        OtherClass obj2 = new OtherClass(4, 6, ConsoleColor.Green);
        OtherClass obj3 = new OtherClass(7, 9, ConsoleColor.Blue);

        Console.Write("odj1 - ");
        obj1.Draw();

        Console.Write("obj2 - ");
        obj2.Draw();

        Console.Write("obj3 - ");
        obj3.Draw();

        obj1.Copy(obj2); // в поля obj1 копируются значения obj2
        
        Console.Write("odj1 - ");
        obj1.Draw();

        // obj2 передается по ссылке, и изменения в методе будут влиять на сам объект
        obj1.Change(obj2);

        Console.Write("obj2 - ");
        obj2.Draw();

        obj1.alpha = 25; // изменяем поля obj1
        obj1.beta = 25;

        Console.Write("odj1 - ");
        obj1.Draw();

        Console.Write("obj2 - ");
        obj2.Draw(); // поля obj2 при этом не меняются

        obj1 = obj3; // теперь ссылку obj3 присваеваем obj1
        
        /*
         * obj1 и obj2 ссылаются на один объект
         * */
        Console.Write("odj1 - ");
        obj1.Draw();

        obj1.alpha = 25; // изменяем поля obj1
        obj1.beta = 25;

        Console.Write("obj3 - ");//поля obj3 "тоже меняются" так как объект один с obj1 
        obj3.Draw();
    }
}

