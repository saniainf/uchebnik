using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;


class Chapter2
{
    public Chapter2()
    {
        Type t = typeof(MyClass); // извлечь объект типа Type из MyClass
        MethodInfo[] mi = t.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly); // занести в массив все методы объекта

        #region print

        Console.WriteLine("Анализ методов в " + t.Name);
        Console.WriteLine();

        Console.WriteLine("Поддерживаемые методы: ");

        // цикл переборки методов
        foreach (MethodInfo m in mi)
        {
            // возвращаемый тип и имя 
            Console.Write("   " + m.ReturnType.Name + " " + m.Name + "(");

            // параметры 
            ParameterInfo[] pi = m.GetParameters();

            for (int i = 0; i < pi.Length; i++)
            {
                Console.Write(pi[i].ParameterType.Name + " " + pi[i].Name);
                if (i + 1 < pi.Length) Console.Write(", ");
            }

            Console.WriteLine(")");

            Console.WriteLine();
        }
        #endregion

        #region invoke methods

        MyClass reflectOb = new MyClass(10, 20);
        int val;

        Console.WriteLine("Вызов методов в " + t.Name);
        Console.WriteLine();

        // переборка всех методов 
        foreach (MethodInfo m in mi)
        {
            // извлекание параметров 
            ParameterInfo[] pi = m.GetParameters();

            if (m.Name.Equals("Set", StringComparison.Ordinal) &&
               pi[0].ParameterType == typeof(int))
            {
                object[] args = new object[2];
                args[0] = 9;
                args[1] = 18;
                m.Invoke(reflectOb, args);
            }
            else if (m.Name.Equals("Set", StringComparison.Ordinal) &&
                    pi[0].ParameterType == typeof(double))
            {
                object[] args = new object[2];
                args[0] = 1.12;
                args[1] = 23.4;
                m.Invoke(reflectOb, args);
            }
            else if (m.Name.Equals("Sum", StringComparison.Ordinal))
            {
                val = (int)m.Invoke(reflectOb, null);
                Console.WriteLine("сумма равна " + val);
            }
            else if (m.Name.Equals("IsBetween", StringComparison.Ordinal))
            {
                object[] args = new object[1];
                args[0] = 14;
                if ((bool)m.Invoke(reflectOb, args))
                    Console.WriteLine("14 находится между x and y");
            }
            else if (m.Name.Equals("Show", StringComparison.Ordinal))
            {
                m.Invoke(reflectOb, null);
            }
        }

        #endregion
    }
}

class MyClass
{
    int x;
    int y;

    public MyClass(int i, int j)
    {
        x = i;
        y = j;
    }

    public int Sum()
    {
        return x + y;
    }

    public bool IsBetween(int i)
    {
        if ((x < i) && (i < y)) return true;
        else return false;
    }

    public void Set(int a, int b)
    {
        Console.Write("в методе Set(int, int). ");
        x = a;
        y = b;
        Show();
    }

    // перегрузка метода 
    public void Set(double a, double b)
    {
        Console.Write("в методе Set(double, double). ");
        x = (int)a;
        y = (int)b;
        Show();
    }

    public void Show()
    {
        Console.WriteLine("Значение x: {0}, y: {1}", x, y);
    }
}