using System;

class Example
{
    static void Main()
    {
        double a, b;

        Tanks KV = new Tanks(); //создаем объект класса Tanks и заполняем поля
        KV.nameTank = "КВ";
        KV.healtPoint = 986;
        KV.dps = 76.28;

        Tanks Tiger;
        Tiger = new Tanks(); //создаем объект класса Tanks и заполняем поля
        Tiger.nameTank = "Тигр";
        Tiger.healtPoint = 1076;
        Tiger.dps = 68.57;

        Console.WriteLine("Танк:\tПрочность:\tУрон в секунду:\n");
        Console.WriteLine("{0}\t{1}\t\t{2}", KV.nameTank, KV.healtPoint, KV.dps);
        Console.WriteLine("{0}\t{1}\t\t{2}", Tiger.nameTank, Tiger.healtPoint, Tiger.dps);
        Console.WriteLine();

        a = KV.healtPoint / Tiger.dps;
        b = Tiger.healtPoint / KV.dps;

        Console.WriteLine("Танк {0} уничтожит танк {1} за {2}сек.", KV.nameTank, Tiger.nameTank, b);
        Console.WriteLine("Танк {0} уничтожит танк {1} за {2}сек.", Tiger.nameTank, KV.nameTank, a);
        Console.WriteLine("Танк {0} ПОБЕДИЛ!!!", (a > b) ? KV.nameTank : Tiger.nameTank);
        Console.WriteLine();
    }
}

class Tanks
{
    // поля класса
    public string nameTank;
    public int healtPoint;
    public double dps;
}