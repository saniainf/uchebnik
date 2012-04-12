﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Glava19.Chap1;


namespace Glava19
{
    class Examples
    {
        static int Main()
        {
            string numb;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("1. простой запрос\n" +
                "2. варианты Select и Group\n" +
                "3. переменая в запросе let\n" +
                "4. оператор join & анонимные типы LINQ\n" +
                "5. груповое объединение\n" +
                "6. методы запроса\n" +
                //"7. event .NET\n" +
                //"8. EventHandler<TEventArgs>\n" +
                //"9. event win\n" +
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
                //case "7":
                //    Console.Clear();
                //    Chap7();
                //    break;
                //case "8":
                //    Console.Clear();
                //    Chap8();
                //    break;
                //case "9":
                //    Console.Clear();
                //    Chap9();
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
            Chapter1 chapter1 = new Chapter1();
        }

        static void Chap2()
        {
            Chapter2 chapter2 = new Chapter2();
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

        //static void Chap7()
        //{
        //    Chapter7 chapter7 = new Chapter7();
        //}

        //static void Chap8()
        //{
        //    Chapter8 chapter8 = new Chapter8();
        //}

        //static void Chap9()
        //{
        //    Chapter9 chapter9 = new Chapter9();
        //}
    }
}
