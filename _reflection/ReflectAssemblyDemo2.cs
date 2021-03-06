﻿using System;
using System.Reflection;

class reflectionAssemblyDemo
{
    static void Main()
    {
        int val;

        // загрузка сборки MyClasses.exe
        Assembly asm = Assembly.LoadFrom("MyClasses.exe");

        // извлечь все типы
        Type[] alltypes = asm.GetTypes();
        foreach (Type temp in alltypes)
            Console.WriteLine("Найдено: " + temp.Name);

        Console.WriteLine();

        Type t = alltypes[0]; // использовать первый найденный класс
        Console.WriteLine("Использован класс: " + t.Name);

        MethodInfo[] mi = t.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly); // занести в массив все методы объекта
        ConstructorInfo[] ci = t.GetConstructors(); // занести в массив конструкторы объекта

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

        ParameterInfo[] cpi = ci[0].GetParameters();
        object reflectOb;

        if (cpi.Length > 0)
        {
            object[] consargs = new object[cpi.Length];
            for (int n = 0; n < cpi.Length; n++)
                consargs[n] = 10 + n * 20;
            reflectOb = ci[0].Invoke(consargs);
        }
        else
        {
            reflectOb = ci[0].Invoke(null);
        }

        #endregion

        #region invoke methods

        Console.WriteLine("Вызов методов в " + t.Name);

        // переборка всех методов 
        foreach (MethodInfo m in mi)
        {
            Console.WriteLine();
            Console.WriteLine("Вызов метода {0} ", m.Name);

            // извлекание параметров 
            ParameterInfo[] pi = m.GetParameters();

            switch (pi.Length)
            {
                case 0: // нет аргументов 
                    if (m.ReturnType == typeof(int))
                    {
                        val = (int)m.Invoke(reflectOb, null);
                        Console.WriteLine("результат " + val);
                    }
                    else if (m.ReturnType == typeof(void))
                    {
                        m.Invoke(reflectOb, null);
                    }
                    break;
                case 1: // один аргумент 
                    if (pi[0].ParameterType == typeof(int))
                    {
                        object[] args = new object[1];
                        args[0] = 14;
                        if ((bool)m.Invoke(reflectOb, args))
                            Console.WriteLine("14 находится между X & Y");
                        else
                            Console.WriteLine("14 не находится между X & Y");
                    }
                    break;
                case 2: // два аргумента 
                    if ((pi[0].ParameterType == typeof(int)) &&
                       (pi[1].ParameterType == typeof(int)))
                    {
                        object[] args = new object[2];
                        args[0] = 9;
                        args[1] = 18;
                        m.Invoke(reflectOb, args);
                    }
                    else if ((pi[0].ParameterType == typeof(double)) &&
                            (pi[1].ParameterType == typeof(double)))
                    {
                        object[] args = new object[2];
                        args[0] = 1.12;
                        args[1] = 23.4;
                        m.Invoke(reflectOb, args);
                    }
                    break;
            }

        }
        #endregion
    }
}