using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

delegate int Incr(int v);
delegate bool IsEven(int v);
delegate bool InRange(int lower, int upper, int v);
delegate int IntOp(int end);

class Chapter4
{
    public Chapter4()
    {
        Incr incr = (int count) => count + 2;
        IsEven isEven = n => n % 2 == 0;
        InRange inRange = (int low, int high, int val) => (val >= low && val <= high);
        IntOp fact = n =>
        {
            int r = 1;
            for (int i = 1; i <= n; i++)
                r = i * r;
            return r;
        };


        int x = -10;
        while (x <= 0)
        {
            Console.Write(x + " ");
            x = incr(x);
        }

        Console.WriteLine("\n");

        for (int i = 1; i <= 10; i++)
            if (isEven(i)) Console.WriteLine(i + " true");

        Console.WriteLine("\n");

        if (inRange(1, 5, 3))
        {
            Console.WriteLine("true");
        }

        Console.WriteLine("\n");

        Console.WriteLine("factorial 5: " + fact(5));
    }
}

