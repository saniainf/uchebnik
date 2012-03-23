using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


class Chapter1
{
    public Chapter1()
    {
        class1 obj1 = new class1();
        class2 obj2 = new class2();
        Type type = typeof(StreamReader); // typeof - извлечь объект типа Type из StreamReader

        if (obj1 is class1)
            Console.WriteLine("obj1 type class1"); //тру - типы одинаковые

        if (obj2 is class1)
            Console.WriteLine("obj2 type class2 : class1"); //тру - наследование 

        if (obj1 is object)
            Console.WriteLine("obj1 type class1 : object"); //тру - object базовый класс

        obj2 = obj1 as class2; //сделать приведение типов если это возможно, иначе null
        if (obj2 == null)
            Console.WriteLine("приведение типов невозможно");

        Console.WriteLine(type.FullName); //название типа
        if (type.IsClass)
            Console.WriteLine("относится к классу"); //является ли классом
        if (!type.IsAbstract)
            Console.WriteLine("является конкретным классом"); //абстрактный ?
    }
}

class class1
{

}

class class2 : class1
{

}