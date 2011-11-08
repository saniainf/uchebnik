﻿using System;

class Example
{
    static void Main()
    {
        string numb;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("1. Простые массивы\n2. Ступенчатые массивы\n3. Неявно типизированные массивы\n4. foreach\n5. bubble sort\n6. quicksort\n\n");
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
            default:
                Console.WriteLine("не вводи всякую херню\n\n\n");
                Main();
                break;
        }
    }

    static void Chap1()
    {
        /*масив без инициализации при объявлении*/
        int[] massive = new int[10]; //new для распределения памяти
        for (int a = 0; a < 10; a++)
            massive[a] = a;
        for (int a = 0; a < 10; a++)
            Console.WriteLine("массив[{0}]: {1}", a, massive[a]);

        Console.WriteLine();
        Console.WriteLine();

        /*масив с инициализацией при объявлении*/
        int[] massive2 = { 99, 10, 100, 18, 78, 23, 63, 9, 87, 49 }; //необходимость в new отпадает
        int avg = 0;
        for (int a = 0; a < 10; a++)
            avg += massive2[a];
        avg /= 10;
        Console.WriteLine("среднее:{0}", avg);

        Console.WriteLine();
        Console.WriteLine();

        /* 3х мерный массив без инициализации при объявлении
         * 2х мерный можно объявить при инициализации
         * */
        int[, ,] massive4 = new int[4, 5, 3];
        int x = 1;

        for (int a = 0; a < 4; a++)
            for (int b = 0; b < 5; b++)
                for (int c = 0; c < 3; c++)
                    massive4[a, b, c] = x++;

        for (int a = 0; a < 4; a++)
            for (int b = 0; b < 5; b++)
                for (int c = 0; c < 3; c++)
                    Console.WriteLine("масив[{0},{1},{2}]: {3}", a, b, c, massive4[a, b, c]);

        foreach (int a in massive4) // в переменную 'a' сохраняется текущее значение ячейки
            Console.Write("{0} ", a);
    }

    static void Chap2()
    {
        /* ступенчатый массив или массив массивов
         * */
        int[][] steps = new int[3][];
        steps[0] = new int[4];
        steps[1] = new int[3];
        steps[2] = new int[5];

        int[][,] steps2x = new int[3][,];
    }

    static void Chap3()
    {
        /*инициализируется сразу*/
        string stroka = "asdfghjkl";
        var arrrstr = stroka.ToCharArray();
        for (int a = 0; a < arrrstr.Length; a++)
            Console.WriteLine("{0}", arrrstr[a]);
    }

    static void Chap4()
    {
        string stroka = "abcdefghijklmnopqrstuvwxyz";
        char[] arrstr = stroka.ToCharArray();
        
        foreach (char a in arrstr) // в переменную 'a' сохраняется текущее значение ячейки
            Console.WriteLine("{0}", (int)a);
    }

    static void Chap5()
    {
        Console.Write("Введите массив для сортировки: ");
        string stroka = Console.ReadLine();
        if (stroka == "")
        {
            stroka = "qwertyuiop147asdfghjkl258zxcvbnm369";
            Console.WriteLine("массив данный по умолчанию: {0}", stroka);
        }
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine ("исходный массив данных: {0}", stroka);
        Console.ResetColor();

        char[] sortmassiv = stroka.ToCharArray();
        bool cheak = true;

        while (cheak) //цикл пока истина
        {
            cheak = false; //если небудет ниодного изменения массива то конец цикла
            for (int a = 0; a < sortmassiv.Length-1; a++) //перебор каждой ячейки
            {
                if (sortmassiv[a] > sortmassiv[a+1]) //сверка ячейки и ячейки+1
                {
                    char x = sortmassiv[a]; // если больше то меняем местами
                    sortmassiv[a] = sortmassiv[a + 1];
                    sortmassiv[a + 1] = x;
                    cheak = true; // изменение было
                }
            }
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("отсортированный массив: ");
        foreach (char a in sortmassiv) // в переменную 'a' сохраняется текущее значение ячейки
            Console.Write("{0}", a);
        Console.ResetColor();
        Console.WriteLine();
        Console.WriteLine();
    }

    static void Chap6()
    {
        //qSort(sortmassiv[], 0, sortmassiv.Length);
        int[] mass3 = { 1, 2, 5, 4, 7, 9, 3, 5, 4, 6, 8, 2, 1, 8, 6, 5, 2, 1, 7, 8, 2, 3, 4, 7, 6, 3, 9, 8 };
        qSort(mass3, 0, mass3.Length-1);
    }

    public static void qSort(int[] mass33, int low, int high)
    {
        int i = low;
        int j = high;
        int x = mass33[(low + (high - low) / 2)];
        do
        {
            while (mass33[i] < x)
                ++i;
            while (x < mass33[j])
                --j;
            if (i <= j)
            {
                if (i < j)
                {
                    int t = mass33[i];
                    mass33[i] = mass33[j];
                    mass33[j] = t;
                }
                ++i;
                --j;
            }
        } while (i <= j);
        if (low < j)
            qSort(mass33, low, j);
        if (i < high)
            qSort(mass33, i, high);

        foreach (int ch in mass33) // в переменную 'a' сохраняется текущее значение ячейки
            Console.Write("{0}", ch);
        Console.WriteLine();
    }
}