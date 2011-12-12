using System;

class Chapter2
{
    public Chapter2()
    {
        BaseClass baseObj = new BaseClass();
        DerivedAlpha dObj1 = new DerivedAlpha();
        DerivedBeta dObj2 = new DerivedBeta();

        BaseClass baseRef;

        baseRef = baseObj;
        baseRef.Metod();

        baseRef = dObj1;
        baseRef.Metod();

        baseRef = dObj2;
        baseRef.Metod();
    }
}

class BaseClass
{
    public virtual void Metod()
    {
        Console.WriteLine("Metod BaseClass");
    }
}

class DerivedAlpha : BaseClass
{
    public override void Metod()
    {
        Console.WriteLine("Metod DerivedAlpha");
    }
}

class DerivedBeta : BaseClass
{
    public int a = 20;
    public override void Metod()
    {
        Console.WriteLine("Metod DerivedBeta");
    }
}

