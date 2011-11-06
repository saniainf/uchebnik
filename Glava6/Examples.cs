using System;

class Example
{
    static void Main()
    {
        /* старая конструкция
        Tanks KV = new Tanks(); //создаем объект класса Tanks и заполняем поля
        KV.nameTank = "КВ";
        KV.healtPoint = 986; // 15 shoot from Tiger
        KV.damage = 94.28;
        KV.shootinMin = 7.34; //sim 8.2

        Tanks Tiger;
        Tiger = new Tanks(); //создаем объект класса Tanks и заполняем поля
        Tiger.nameTank = "Тигр";
        Tiger.healtPoint = 1200; // 13 shoot from KV
        Tiger.damage = 68.57;
        Tiger.shootinMin = 6.67; //sim 8.9
         * */

        /*объект с конструктором*/
        Tanks KV = new Tanks("КВ", 986, 94.28, 7.34); //создаем объект класса Tanks и заполняем поля
        Tanks Tiger = new Tanks("Тигр", 1200, 68.57, 6.67); //создаем объект класса Tanks и заполняем поля

        Console.WriteLine("Танк:\t\tHP:\t\tУрон:\t\tВыст/мин.:\tПерезарядка:\n");
        Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}\t\t{4:#.#}", KV.nameTank, KV.healtPoint, KV.damage, KV.shootinMin, KV.reloadTime);
        Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}\t\t{4:#.#}", Tiger.nameTank, Tiger.healtPoint, Tiger.damage, Tiger.shootinMin, Tiger.reloadTime);
        Console.WriteLine();

        Console.WriteLine("Танк {0} уничтожит танк {1} за {2} выстрелов за {3:####.#} сек.", KV.nameTank, Tiger.nameTank, KV.KillShoot(Tiger.healtPoint), KV.KillTime(Tiger.healtPoint));
        Console.WriteLine("Танк {0} уничтожит танк {1} за {2} выстрелов за {3:####.#} сек.", Tiger.nameTank, KV.nameTank, Tiger.KillShoot(KV.healtPoint), Tiger.KillTime(KV.healtPoint));
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Танк {0} ПОБЕДИЛ!!!", (Tiger.KillTime(KV.healtPoint) > KV.KillTime(Tiger.healtPoint)) ? KV.nameTank : Tiger.nameTank);
        Console.ResetColor();
        Console.WriteLine();
    }
}

class Tanks
{
    // поля класса
    public string nameTank;
    public int healtPoint;
    public double damage;
    public double shootinMin;
    public double reloadTime;

    public Tanks(string nameTank, int healtPoint, double damage, double shootinMin)
    {
        this.nameTank = nameTank;
        this.healtPoint = healtPoint;
        this.damage = damage;
        this.shootinMin = shootinMin;
        reloadTime = 60 / shootinMin;
    }

    public double KillShoot(int HP)
    {
        return Math.Round(HP / damage);
    }

    public double KillTime(int HP)
    {
        return Math.Round(HP / damage) * reloadTime;
    }
}