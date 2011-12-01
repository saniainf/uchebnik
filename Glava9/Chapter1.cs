using System;

class Chapter1
{
    public Chapter1()
    {
        Vector3 alpha = new Vector3(1, 2, 3);
        Vector3 beta = new Vector3(10, 10, 10);
        Vector3 c;


    }
}

class Vector3
{
    int X, Y, Z;

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

    public void PrintF()
    {
        Console.WriteLine("X: {0}, Y: {1}, Z: {2}", X, Y, Z);
    }
}