using System;

class Chapter4
{
    public Chapter4()
    {
        PointLogic3 a = new PointLogic3(5, 6, 7);
        PointLogic3 b = new PointLogic3(10, 10, 10);
        PointLogic3 c = new PointLogic3(0, 0, 0);

        Console.Write("Here is a: ");
        a.Show();
        Console.Write("Here is b: ");
        b.Show();
        Console.Write("Here is c: ");
        c.Show();
        Console.WriteLine();

        if (a) Console.WriteLine("a is true.");
        if (b) Console.WriteLine("b is true.");
        if (c) Console.WriteLine("c is true.");

        if (!a) Console.WriteLine("a is false.");
        if (!b) Console.WriteLine("b is false.");
        if (!c) Console.WriteLine("c is false.");

        Console.WriteLine();

        Console.WriteLine("Use & and |");
        if (a & b) Console.WriteLine("a & b is true.");
        else Console.WriteLine("a & b is false.");

        if (a & c) Console.WriteLine("a & c is true.");
        else Console.WriteLine("a & c is false.");

        if (a | b) Console.WriteLine("a | b is true.");
        else Console.WriteLine("a | b is false.");

        if (a | c) Console.WriteLine("a | c is true.");
        else Console.WriteLine("a | c is false.");

        Console.WriteLine();

        // Now use short-circuit ops. 
        Console.WriteLine("Use short-circuit && and ||");
        if (a && b) Console.WriteLine("a && b is true.");
        else Console.WriteLine("a && b is false.");

        if (a && c) Console.WriteLine("a && c is true.");
        else Console.WriteLine("a && c is false.");

        if (a || b) Console.WriteLine("a || b is true.");
        else Console.WriteLine("a || b is false.");

        if (a || c) Console.WriteLine("a || c is true.");
        else Console.WriteLine("a || c is false."); 
    }
}

class PointLogic3
{
    int x, y, z; // 3-D coordinates     
   
    public PointLogic3()
    {
        x = y = z = 0; 
    }   

    public PointLogic3(int i, int j, int k)
    {
        x = i; y = j; z = k; 
    }   
 
    // Overload | for short-circuit evaluation.   
    public static PointLogic3 operator |(PointLogic3 op1, PointLogic3 op2)   
    {  
    if( ((op1.x != 0) || (op1.y != 0) || (op1.z != 0)) | 
        ((op2.x != 0) || (op2.y != 0) || (op2.z != 0)) ) 
        return new PointLogic3(1, 1, 1);   
    else   
        return new PointLogic3(0, 0, 0);   
    }   
 
    // Overload & for short-circuit evaluation.   
    public static PointLogic3 operator &(PointLogic3 op1, PointLogic3 op2)   
    {   
    if( ((op1.x != 0) && (op1.y != 0) && (op1.z != 0)) & 
        ((op2.x != 0) && (op2.y != 0) && (op2.z != 0)) ) 
        return new PointLogic3(1, 1, 1);   
    else   
        return new PointLogic3(0, 0, 0);   
    }   
 
    // Overload !.   
    public static bool operator !(PointLogic3 op)   
    {   
    if(op) return false;   
    else return true;   
    }   
 
    // Overload true.   
    public static bool operator true(PointLogic3 op)
    { 
    if((op.x != 0) || (op.y != 0) || (op.z != 0)) 
        return true; // at least one coordinate is non-zero 
    else 
        return false; 
    }   
 
    // Overload false. 
    public static bool operator false(PointLogic3 op)
    { 
    if((op.x == 0) && (op.y == 0) && (op.z == 0)) 
        return true; // all coordinates are zero 
    else 
        return false; 
    }   
 
    // Show X, Y, Z coordinates.   
    public void Show()   
    {   
    Console.WriteLine(x + ", " + y + ", " + z);   
    }   
}