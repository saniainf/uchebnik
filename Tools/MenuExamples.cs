using System;
using System.Collections.Generic;

class Example
{
    static int Main()
    {
        string numb;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("1. string\n" +
            "2. random\n" +
            "3. random test\n" +
            //"4. string\n" +
            //"5. string\n" +
            //"6. string\n" +
            //"7. string\n" +
            //"8. string\n" +
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
            //case "4":
            //    Console.Clear();
            //    Chap4();
            //    break;
            //case "5":
            //    Console.Clear();
            //    Chap5();
            //    break;
            //case "6":
            //    Console.Clear();
            //    Chap6();
            //    break;
            //case "7":
            //    Console.Clear();
            //    Chap7();
            //    break;
            //case "8":
            //    Console.Clear();
            //    Chap8();
            //    break;
            case "0":
                Console.Clear();
                return 0;
            default:
                Console.WriteLine("не вводи всякую херню\n\n\n");
                Main();
                break;
        }
        return 0;
    }

    static void Chap1()
    {
        //_ListS<string> rty = new _ListS<string>(20);
    }

    static void Chap2()
    {
        int[] arTst = new int[50];
        int[] arTst2 = new int[50];
        _Random rnd = new _Random();

        for (int i = 0; i < arTst.Length; i++)
        {
            arTst[i] = rnd.NextRnd(1, 200);
        }

        for (int i = 0; i < arTst.Length; i++)
        {
            arTst2[i] = rnd.NextRnd(1, 200);
        }

        foreach (int a in arTst)
            Console.Write(a);

        Console.WriteLine();

        foreach (int a in arTst2)
            Console.Write(a);

        Console.WriteLine();
    }

    static void Chap3()
    {
        int[] arTst = new int[50];
        int[] arTst2 = new int[50];
        Random rnd = new Random(DateTime.Now.Millisecond);

        for (int i = 0; i < arTst.Length; i++)
        {
            arTst[i] = rnd.Next(1, 200);
        }

        for (int i = 0; i < arTst.Length; i++)
        {
            arTst2[i] = rnd.Next(1, 200);
        }

        foreach (int a in arTst)
            Console.Write(a);
        
        Console.WriteLine();

        foreach (int a in arTst2)
            Console.Write(a);

        Console.WriteLine();
    }

    //static void Chap4()
    //{
    //    Chapter4 chapter4 = new Chapter4();
    //}

    //static void Chap5()
    //{
    //    Chapter5 chapter5 = new Chapter5();
    //}

    //static void Chap6()
    //{
    //    Chapter6 chapter6 = new Chapter6();
    //}

    //static void Chap7()
    //{
    //    Chapter7 chapter7 = new Chapter7();
    //}

    //static void Chap8()
    //{
    //    Chapter8 chapter8 = new Chapter8();
    //}
}