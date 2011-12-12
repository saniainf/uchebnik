using System;

class Chapter5 : ObjectDerived
{
    ObjectDerived obj1;
    object[] massive = new object[10]; //в массиве можно хранить любые типы

    public Chapter5()
    {
        obj1 = new ObjectDerived();
        Console.WriteLine(obj1.ToString()); //вызывается метод Object.ToString()

        massive[1] = "ads";
        massive[2] = 311;
        massive[3] = obj1; //так как object базовый для всех, то ссылке его типа можно присвоить любой объект
        massive[4] = 'H';
        massive[5] = true;

        foreach (object obj in massive)
        {
            Console.WriteLine("massive: {0}", obj);
        }
    }
}

class ObjectDerived
{
    public ObjectDerived()
    {

    }

    /* override метода Object.ToString */
    public override string ToString()
    {
        return base.ToString();
        //return "override ToString";
    }
}

