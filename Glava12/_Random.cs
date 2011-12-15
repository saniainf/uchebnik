using System;


class _Random
{
    int Max = 0;
    int Min = 0;

    int tmpMax = 2;
    int tmpMin = 2;

    Random random = new Random();

    public _Random()
    {

    }

    public int NextRnd(int min, int max) // 5 , 15
    {
        if (Max != max & Min != min)
        {
            tmpMax = tmpMin = 1;
            Max = max;
            Min = min;
            return Rnd(min, max);
        }

        if (Max == max & Min == min)
        {
            return Rnd(min, max);
        }
        return 0;    
    }

    int Rnd(int min, int max) // 5 , 15
    {
        int a;
        int b;

        if (max - tmpMax == 2) tmpMax = 1;
        if (tmpMin == Max - 2) tmpMin = 1;

        a = random.Next(Min, max - tmpMax++);
        b = random.Next(Min, min + tmpMin++);

        return (a + b) - min;
    }
}

