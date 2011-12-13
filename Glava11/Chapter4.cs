using System;

class Chapter4 : AbsrtClass
{
    public Chapter4()
        : base(34, 56)
    {
        AbstrTest();
    }

    sealed public override void AbstrTest() //запечатаный метод sealed, его нельзя далее переопределить 
    {
        PrintF();
        Console.WriteLine(alpha + beta);
    }
}

abstract class AbsrtClass
{
    public int alpha;
    public int beta;

    public AbsrtClass(int a, int b)
    {
        this.alpha = a;
        this.beta = b;
    }

    public void PrintF()
    {
        Console.WriteLine("a {0}, b {1}", alpha, beta);
    }

    public abstract void AbstrTest();
}

class Derived:Chapter4
{
    public Derived()
    {

    }

    /*
    override public void AbstrTest()
    {
        тут ошибка, метод запечатан
    }
    */
}