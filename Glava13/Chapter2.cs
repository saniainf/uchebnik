using System;

class Chapter2
{
    public Chapter2()
    {

        for (int i = 0; i < 3; i++)
        {
            UseFinally.GenException(i);
            Console.WriteLine();

        }
    }
}

class UseFinally
{
    public static void GenException(int what)
    {
        int t;
        int[] nums = new int[2];

        Console.WriteLine("Receiving " + what);
        try
        {
            switch (what)
            {
                case 0:
                    t = 10 / what; // generate div-by-zero error 
                    break;
                case 1:
                    nums[4] = 4; // generate array index error. 
                    break;
                case 2:
                    return; // return from try block 
            }
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Can't divide by Zero!");
            return; // return from catch 
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("No matching element found.");
        }
        finally
        {
            Console.WriteLine("Leaving try.");
        }
    }
}

