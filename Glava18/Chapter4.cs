using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Chapter4
{
    public Chapter4()
    {
        TestConstruct<TypeClass> x = new TestConstruct<TypeClass>();
    }
}

class TypeClass
{
    public TypeClass()
    {
        // пустой конструктор
    }
}

class TestConstruct<TKey> where TKey : new() // ограничение на конструктор
{
    TKey obj1;
    public TestConstruct()
    {
        obj1 = new TKey(); // можно получить экземпляр объекта 
    }

    //....
}