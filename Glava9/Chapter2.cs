using System;

class Chapter2
{
    public Chapter2()
    {
        Point3 a = new Point3(5, 6, 7);
        Point3 b = new Point3(10, 10, 10);
        Point3 c = new Point3(1, 2, 3);
        Point3 d = new Point3(6, 7, 5);

        Console.Write("coord point a: ");
        a.Printf();
        Console.Write("coord point b: ");
        b.Printf();
        Console.Write("coord point c: ");
        c.Printf();
        Console.Write("coord point d: ");
        d.Printf();

        if (a > c) Console.WriteLine("a > c");
        if (a < b) Console.WriteLine("a < b");

        if (a > d) Console.WriteLine("a > d");
        else
            if (a < d) Console.WriteLine("a < d");
            else Console.WriteLine("point a & d na odnoi okrughnosti");
    }
}

class Point3
{
    public int X, Y, Z;

    public Point3()
    {
        X = Y = Z = 0;
    }

    public Point3(int x, int y, int z)
    {
        this.X = x;
        this.Y = y;
        this.Z = z;
    }

    public static bool operator <(Point3 obj1, Point3 obj2)
    {
        if (Math.Sqrt(obj1.X * obj1.X + obj1.Y * obj1.Y + obj1.Z * obj1.Z) <
            Math.Sqrt(obj2.X * obj2.X + obj2.Y * obj2.Y + obj2.Z * obj2.Z))
            return true;
        else return false;
    }

    public static bool operator >(Point3 obj1, Point3 obj2)
    {
        if (Math.Sqrt(obj1.X * obj1.X + obj1.Y * obj1.Y + obj1.Z * obj1.Z) >
            Math.Sqrt(obj2.X * obj2.X + obj2.Y * obj2.Y + obj2.Z * obj2.Z))
            return true;
        else return false;
    }

    public void Printf()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("X: {0},\tY: {1},\tZ: {2}", X, Y, Z);
        Console.ResetColor();
    }
}