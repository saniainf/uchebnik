using System;

class Chapter5
{
    public Chapter5()
    {
        PointConvert a = new PointConvert(1, 2, 3);
        PointConvert b = new PointConvert(10, 10, 10);
        PointConvert c = new PointConvert();
        int i;

        Console.Write("coord a: ");
        a.PrintF();
        Console.Write("coord b: ");
        b.PrintF();

        Console.Write("a + b:   ");
        c = a + b;
        c.PrintF();

        Console.Write("a -> int ");
        i = a;
        Console.WriteLine(i);

        Console.Write("a*2-b\t");
        i = a * 2 - b;
        Console.WriteLine(i);
    }
}

class PointConvert
{
    int X, Y, Z;

    public PointConvert()
    {
        X = Y = Z = 0;
    }

    public PointConvert (int x, int y, int z)
    {
        this.X = x;
        this.Y = y;
        this.Z = z;
    }

    public static PointConvert operator +(PointConvert obj1, PointConvert obj2)
    {
        PointConvert result = new PointConvert();

        /*сложить поля 2 объектов*/
        result.X = obj1.X + obj2.X;
        result.Y = obj1.Y + obj2.Y;
        result.Z = obj1.Z + obj2.Z;
        /*возврат объекта*/
        return result;
    }

    public static implicit operator int(PointConvert obj1)
    {
        return obj1.X * obj1.Y * obj1.Z;
    }

    public void PrintF()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("X: {0},\tY: {1},\tZ: {2}", X, Y, Z);
        Console.ResetColor();
    }
}


