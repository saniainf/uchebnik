using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Counter1; //использование namespace 
using MyCounter = Counter2.CountDown; //использование псевдонима класса

using Counter3; //порождает неоднозначность
using Counter3_1; //порождает неоднозначность
using Ctr = Counter3; //присвоить псевдоним


class Chapter1
{
    public Chapter1()
    {
        int i;

        // обращение к классу без указания namespace
        CountDown cd1 = new CountDown(10);
        do
        {
            i = cd1.Count();
            Console.Write(i + " ");
        } while (i > 0);
        Console.WriteLine();

        // обращение по псевдониму
        MyCounter cd2 = new MyCounter(8);
        do
        {
            i = cd2.Count();
            Console.Write(i + " ");
        } while (i > 0);
        Console.WriteLine();

        // исключение неоднозначности с помощью псевдонима namespace
        Ctr::CountDown3 cd3 = new Ctr::CountDown3(8);
        do
        {
            i = cd3.Count();
            Console.Write(i + " ");
        } while (i > 0);
        Console.WriteLine();
    }
}


// объявление пространства имен
namespace Counter1
{
    //типа класс счетчика
    class CountDown
    {
        int val;

        public CountDown(int n)
        {
            val = n;
        }

        public int Count() // уменьшает переменную класса
        {
            if (val > 0) return val--;
            else return 0;
        }
    }
}

namespace Counter2
{
    //типа класс счетчика
    class CountDown
    {
        int val;

        public CountDown(int n)
        {
            val = n;
        }

        public int Count() // уменьшает переменную класса
        {
            if (val > 0) return val--;
            else return 0;
        }
    }
}

namespace Counter3
{
    //типа класс счетчика
    class CountDown3
    {
        int val;

        public CountDown3(int n)
        {
            val = n;
        }

        public int Count() // уменьшает переменную класса
        {
            if (val > 0) return val--;
            else return 0;
        }
    }
}

namespace Counter3_1
{
    //типа класс счетчика
    class CountDown3
    {
        int val;

        public CountDown3(int n)
        {
            val = n;
        }

        public int Count() // уменьшает переменную класса
        {
            if (val > 0) return val--;
            else return 0;
        }
    }
}