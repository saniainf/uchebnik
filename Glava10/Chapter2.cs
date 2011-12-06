using System;

class Chapter2
{
    public Chapter2()
    {
        PwrOfTwo pwr = new PwrOfTwo();

        Console.Write("First 8 powers of 2: ");
        for (int i = 0; i < 8; i++)
            Console.Write(pwr[i] + " ");
        Console.WriteLine();

        Console.Write("Here are some errors: ");
        Console.Write(pwr[-1] + " " + pwr[17]);

        Console.WriteLine(); 
    }
}


class PwrOfTwo
{

    /* Access a logical array that contains 
       the powers of 2 from 0 to 15. */
    public int this[int index]
    {
        // Compute and return power of 2. 
        get
        {
            if ((index >= 0) && (index < 16)) return pwr(index);
            else return -1;
        }

        // There is no set accessor. 
    }

    int pwr(int p)
    {
        int result = 1;

        for (int i = 0; i < p; i++)
            result *= 2;

        return result;
    }
}