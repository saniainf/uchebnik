using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

delegate int CountIt(int end);

class Chapter3
{
    public Chapter3()
    {
        CountIt count = delegate(int end)
        {
            int sum = 0;
            for (int i = 0; i <= end; i++)
            {
                Console.WriteLine(i);
                sum += i;
            }
            return sum;
        };

        Console.WriteLine(count(15));
    }
}
