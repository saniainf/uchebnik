using System;
using System.Collections.Generic;

class Example
{
    static int Main() //по завершении возвращает код состояния в систему int
    {
        string numb;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("1. Базовый пример\n"+
                        "2. Stack\n" +
                        "3. Передача объектов по ссылке\n" +
                        "4. ref out params\n" +
                        "5. return object, array\n" +
                        "6. overload\n" +
                        "7. other\n" +
                        "0. Выход\n" +
                        "\n");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Введи номер части: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        numb = Console.ReadLine();
        Console.ResetColor();
        Console.Write("\n\n");

        switch (numb)
        {
            case "1":
                Console.Clear();
                Chap1();
                break;
            case "2":
                Console.Clear();
                Chap2();
                break;
            case "3":
                Console.Clear();
                Chap3();
                break;
            case "4":
                Console.Clear();
                Chap4();
                break;
            case "5":
                Console.Clear();
                Chap5();
                break;
            case "6":
                Console.Clear();
                Chap6();
                break;
            case "7":
                Console.Clear();
                Chap7();
                break;
            case "0":
                Console.Clear();
                return 0; // программа завершилась нормльно
            default:
                Console.WriteLine("не вводи всякую херню\n\n\n");
                Main();
                break;
        }
        return 0; // программа завершилась нормльно
    }

    static void Chap1()
    {
        AccessZero classAccess = new AccessZero();
        /*доступ к полям объекта через методы доступа*/
        classAccess.SetA(Convert.ToInt32(Console.ReadLine()));
        classAccess.SetB(Convert.ToInt32(Console.ReadLine()));
        classAccess.c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("a: {0}, b: {1}, c: {2}", classAccess.GetA(), classAccess.GetB(), classAccess.c);
    }

    static void Chap2()
    {
        StackDrv startStack = new StackDrv();
    }

    static void Chap3()
    {
        Chapter3 chapter3 = new Chapter3();
    }
    
    static void Chap4()
    {
        Chapter4 chapter4 = new Chapter4();
    }
    
    static void Chap5()
    {
        Chapter5 chapter5 = new Chapter5();
    }

    static void Chap6()
    {
        Chapter6 chapter6 = new Chapter6();
    }

    static void Chap7()
    {
        Chapter7 chapter7 = new Chapter7();
    }
}

class AccessZero
{
    /*поля класса*/
    private int a; //явный private доступ
    int b; //private по умолчанию
    public int c; //публик доступ

    /*методы доступа*/
    public void SetA(int a)
    {
        this.a = a;
    }

    public int GetA()
    {
        return a;
    }

    public void SetB(int b)
    {
        this.b = b;
    }

    public int GetB()
    {
        return b;
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
        Console.ResetColor();
    }

    public void Change(OtherClass ob)
    {
        ob.alpha = ob.alpha + ob.beta;
        ob.beta = -ob.beta;
        ob.color = ConsoleColor.White;
    }

    public void Swap(ref int a, ref int b)//принудительный вызов по ссылке
    {
        int swap;
        swap = a;
        a = b;
        b = swap;
    }

    public int GetParts(double n, out double frac)//возврат значения из метода
    {
        int a = (int)n;
        frac = n - a;
        return a;
    }

    public void SwapObj(ref OtherClass obj1, ref OtherClass obj2)
    {
        OtherClass swap;
        swap = obj1;
        obj1 = obj2;
        obj2 = swap;
    }

    /* params произвольное количество аргументов 
     * params в списке параметров всегда последний
     * */
    public int MinVal(string str, params int[] numb) 
    {
        int min;
        if (numb.Length == 0)
        {
            Console.WriteLine("No argument");
            return 0;
        }

        min = numb[0];
        foreach (int a in numb)
            if (a < min) min = a;

        Console.Write(str + "\t");
        return min;
    }

}

class FactoryClass
{
    int alpha, beta;

    public FactoryClass Factory(int a, int b) //метод который возвращает объект этого класса
    {
        FactoryClass obj = new FactoryClass();

        obj.alpha = a;
        obj.beta = b;

        return obj;
    }

    public void Show()
    {
        Console.WriteLine("a: {0} , b: {1}", alpha, beta);
    }

    public int[] FindFactors(int num, out int numfactors) //метод возвращает массив (множители num)
    {
        int[] facts = new int[80];
        int a, b;

        for (a=2, b =0; a<num/2 +1; a++)
            if ((num % a) == 0)
            {
                facts[b] = a;
                b++;
            }
        numfactors = b;
        return facts;
    }
}