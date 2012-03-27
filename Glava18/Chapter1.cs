using System;

class Chapter1
{
    public Chapter1()
    {
        Gen<int> iOb = new Gen<int>(108); //Gen iOb = new Gen(108);
        iOb.ShowTypeOdj();
        int intValue = iOb.GetTValue();
        Console.WriteLine("Значение: " + intValue + "\n");

        Gen<string> strOb = new Gen<string>("text type");
        strOb.ShowTypeOdj();
        string strValue = strOb.GetTValue();
        Console.WriteLine("Значение: " + strValue + "\n");

        // два параметра типа

        TwoGen<string, int> striOb = new TwoGen<string, int>("test text", 847);
        striOb.ShowTypeOdj();
        Console.WriteLine("tValue1: {0}", striOb.GetTvalue1());
        Console.WriteLine("tValue2: {0}", striOb.GetTvalue2());
    }
}

class Gen<Tkey>
{
    Tkey tValue; // string | int typeObj

    public Gen(Tkey tValue) // public Gen(string | int tValue)
    {
        this.tValue = tValue;
    }

    public Tkey GetTValue()
    {
        return tValue;
    }

    public void ShowTypeOdj()
    {
        Console.WriteLine("Тип в tValue " + typeof(Tkey));
    }
}

class TwoGen<Tkey1, Tkey2>
{
    Tkey1 tValue1;
    Tkey2 tValue2;

    public TwoGen(Tkey1 tValue1, Tkey2 tValue2)
    {
        this.tValue1 = tValue1;
        this.tValue2 = tValue2;
    }

    public Tkey1 GetTvalue1()
    {
        return tValue1;
    }

    public Tkey2 GetTvalue2()
    {
        return tValue2;
    }

    public void ShowTypeOdj()
    {
        Console.WriteLine("Тип в tValue1 " + typeof(Tkey1));
        Console.WriteLine("Тип в tValue2 " + typeof(Tkey2));
    }
}