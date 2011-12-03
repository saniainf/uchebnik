using System;

class Chapter1
{
    public Chapter1()
    {
        Vector3 alpha = new Vector3(1, 2, 3);
        Vector3 beta = new Vector3(10, 10, 10);
        Vector3 c;

        Console.Write("coord alpha:\t");
        alpha.PrintF();

        Console.Write("coord beta:\t");
        beta.PrintF();

        Console.Write("alpha + beta:\t");
        c = alpha + beta;
        c.PrintF();

        Console.Write("alpha+beta+c:\t");
        c = alpha + beta + c;
        c.PrintF();

        Console.Write("c - alpha:\t");
        c = c - alpha;
        c.PrintF();

        Console.Write("alpha.X + c.X:\t");
        c.X = alpha.X + c.X;
        c.PrintF();

        Console.Write("c++\t\t");
        c++;
        c.PrintF();

        Console.Write("c--\t\t");
        c--;
        c.PrintF();

        Console.Write("alpha + 40\t");
        alpha = alpha + 40;
        alpha.PrintF();

    }
}

class Vector3
{
    public int X, Y, Z;

    public Vector3()
    {
        X = Y = Z = 0;
    }

    public Vector3(int x, int y, int z)
    {
        this.X = x;
        this.Y = y;
        this.Z = z;
    }

    /* перегрузка оператора + */
    public static Vector3 operator +(Vector3 obj1, Vector3 obj2)
    {
        Vector3 result = new Vector3();

        /*сложить поля 2 объектов*/
        result.X = obj1.X + obj2.X;
        result.Y = obj1.Y + obj2.Y;
        result.Z = obj1.Z + obj2.Z;
        /*возврат объекта*/
        return result;
    }

    /* перегрузка оператора - */
    public static Vector3 operator -(Vector3 obj1, Vector3 obj2)
    {
        Vector3 result = new Vector3();

        /*вычесть из полей 1 объекта поля 2*/
        result.X = obj1.X - obj2.X;
        result.Y = obj1.Y - obj2.Y;
        result.Z = obj1.Z - obj2.Z;
        /*возврат объекта*/
        return result;
    }

    /* перегрузка оператора ++ */
    public static Vector3 operator ++(Vector3 obj1)
    {
        Vector3 result = new Vector3();

        /*инкременировать obj1*/
        result.X = obj1.X + 1;
        result.Y = obj1.Y + 1;
        result.Z = obj1.Z + 1;
        /*возврат объекта*/
        return result;
    }

    /* перегрузка оператора -- */
    public static Vector3 operator --(Vector3 obj1)
    {
        Vector3 result = new Vector3();

        /*декременировать obj1*/
        result.X = obj1.X - 1;
        result.Y = obj1.Y - 1;
        result.Z = obj1.Z - 1;
        /*возврат объекта*/
        return result;
    }

    /* перегрузка оператора +
     *  Vector3 + int
     *  */
    public static Vector3 operator +(Vector3 obj1, int a)
    {
        Vector3 result = new Vector3();

        /*прибавить к полям obj1 целое число*/
        result.X = obj1.X + a;
        result.Y = obj1.Y + a;
        result.Z = obj1.Z + a;
        /*возврат объекта*/
        return result;
    }

    public void PrintF()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("X: {0},\tY: {1},\tZ: {2}", X, Y, Z);
        Console.ResetColor();
    }
}