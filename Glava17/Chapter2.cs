using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;


class Chapter2
{
    public Chapter2()
    {
        int val;
        Type t = typeof(MyClass); // извлечь объект типа Type из MyClass
        MethodInfo[] mi = t.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly); // занести в массив все методы объекта
        ConstructorInfo[] ci = t.GetConstructors();

        #region print construct

        Console.WriteLine("Доступные конструкторы в " + t.Name);
        foreach (ConstructorInfo c in ci)
        {
            Console.Write(" " + t.Name + "("); // имя
            ParameterInfo[] pi = c.GetParameters(); // параметры
            for (int i = 0; i < pi.Length; i++)
            {
                Console.Write(pi[i].ParameterType.Name + " " + pi[i].Name);
                if (i + 1 < pi.Length) Console.Write(", ");
            }
            Console.WriteLine(")");
        }
        Console.WriteLine();

        #endregion

        #region print methods

        Console.WriteLine("Доступные методы в " + t.Name);

        // цикл переборки методов
        foreach (MethodInfo m in mi)
        {
            // возвращаемый тип и имя 
            Console.Write("  " + m.ReturnType.Name + " " + m.Name + "(");

            // параметры 
            ParameterInfo[] pi = m.GetParameters();

            for (int i = 0; i < pi.Length; i++)
            {
                Console.Write(pi[i].ParameterType.Name + " " + pi[i].Name);
                if (i + 1 < pi.Length) Console.Write(", ");
            }

            Console.WriteLine(")");
        }
        Console.WriteLine();

        #endregion

        #region construct

        int x;
        for (x = 0; x < ci.Length; x++)
        {
            ParameterInfo[] pi = ci[x].GetParameters();
            if (pi.Length == 2) break;
        }
        
        if (x == ci.Length)
        {
            Console.WriteLine("Нет нужного конструктора");
            return;
        }
        else
            Console.WriteLine("Есть конструктор с 2 параметрами \n");

        // сконструировать объект
        object[] consargs = new object[2];
        consargs[0] = 10;
        consargs[1] = 20;
        object reflectOb = ci[x].Invoke(consargs);

        #endregion

        #region invoke methods

        Console.WriteLine("Вызов методов в " + t.Name);

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
                Console.WriteLine("   " + "сумма равна " + val);
            }
            else if (m.Name.Equals("IsBetween", StringComparison.Ordinal))
            {
                object[] args = new object[1];
                args[0] = 14;
                if ((bool)m.Invoke(reflectOb, args))
                    Console.WriteLine("   " + "14 находится между x and y");
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

    public MyClass(int i)
    {
        Console.WriteLine("Construct class MyClass(int). ");
        x = y = i;
        Console.WriteLine();
    }

    public MyClass(int i, int j)
    {
        Console.WriteLine("Construct class MyClass(int, int). ");
        x = i;
        y = j;
        Show();
        Console.WriteLine();
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
        Console.Write("   " + "в методе Set(int, int). ");
        x = a;
        y = b;
        Show();
    }

    // перегрузка метода 
    public void Set(double a, double b)
    {
        Console.Write("   " + "в методе Set(double, double). ");
        x = (int)a;
        y = (int)b;
        Show();
    }

    public void Show()
    {
        Console.WriteLine("Значение x: {0}, y: {1}", x, y);
    }
}