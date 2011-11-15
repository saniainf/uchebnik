using System;

class MainProgramm
{
    static void Main()
    {
        int alpha = 0;
        int beta = 0;
        OtherClass[] arrray1 = new OtherClass[10];
        for (int a = 0; a < 10; a++)
            arrray1[a] = new OtherClass(alpha++, beta++);

        foreach (OtherClass obj in arrray1) //перебор массива объектов и вызов метода каждого объекта
            obj.PrintActiv();

    }
}

class OtherClass
{
    int alpha, beta;
    public OtherClass(int a, int b)
    {
        this.alpha = a;
        this.beta = b;
    }

    public void PrintActiv()
    {
        Console.WriteLine("a: {0} , b: {1}", alpha, beta);
    }
}