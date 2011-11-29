using System;

class Chapter7
{
    public Chapter7()
    {
        /* инициализация полей объекта без контруктора
         * можно использовать вместе с контруктором
         * */
        //InicialObj obj1 = new InicialObj(9, 4) { alpha = 99, beta = 33 };
        InicialObj obj1 = new InicialObj { alpha = 99, beta = 33 };
        Console.WriteLine(obj1.alpha + " " + obj1.beta);

        obj1.OptionalArg(33, 66, "nine");
        obj1.OptionalArg(33);
        obj1.OptionalArg(33, 8);
        obj1.OptionalArg(33, 9, "\n\n");
        
        /* необязатльные аргументы*/
        obj1.PrintF("тестовый текст типа");
        obj1.PrintF("тестовый текст типа", 9);
        obj1.PrintF("тестовый текст типа", 9, 15);

        /*именованные аргументы*/
        obj1.PrintF(stop: 15, start: 9, str: "тестовый текст типа");
        obj1.PrintF("тестовый текст типа", stop: -1, start: 9);
        obj1.PrintF("тестовый текст типа", stop: 15);
        obj1.PrintF(stop: 15, str: "тестовый текст типа");
    }
}

class InicialObj
{
    public int alpha;
    public int beta;

    //public InicialObj(int a, int b)
    public InicialObj()
    {
        //this.alpha = a;
        //this.beta = b;
        Console.WriteLine(alpha + " " + beta);
    }

    /* необязательные аргументы при вызове
     * a - обязательный
     * b - по умолчанию 33 можно не указывать при вызове
     * str - по умолчанию "default" можно не указывать при вызове
     * */
    public void OptionalArg(int a, int b = 33, string str = "default")
    {
        Console.WriteLine("a: {0}, b: {1}, str: {2}", a, b, str);
    }

    public void PrintF(string str, int start = 0, int stop = -1)
    {
        if (stop < 0)
            stop = str.Length;

        if (stop > str.Length | start > stop | start < 0)
            return;

        for (int i = start; i < stop; i++)
            Console.Write(str[i]);

        Console.WriteLine();
    }
}

class ReversStr
{

}