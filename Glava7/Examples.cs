using System;

class Example
{
    static void Main()
    {
        /*масив без инициализации при объявлении*/
        int[] massive = new int[10]; //new для распределения памяти
        for (int a = 0; a < 10; a++)
            massive[a] = a;
        for (int a = 0; a < 10; a++)
            Console.WriteLine("массив[{0}]: {1}", a, massive[a]);

        Console.WriteLine();
        Console.WriteLine();

        /*масив с инициализацией при объявлении*/
        int[] massive2 = { 99, 10, 100, 18, 78, 23, 63, 9, 87, 49 }; //необходимость в new отпадает
        int avg = 0;
        for (int a = 0; a < 10; a++)
            avg += massive2[a];
        avg /= 10;
        Console.WriteLine("среднее:{0}", avg);

        Console.WriteLine();
        Console.WriteLine();

        /* 3х мерный масив*/
        int[, ,] massive4 = new int[4, 5, 3];

        for (int a = 0; a < 4; a++)
            for (int b = 0; b < 5; b++)
                for (int c = 0; c < 3; c++)
                    massive4[a, b, c] = b+c;

        for (int a = 0; a < 4; a++)
            for (int b = 0; b < 5; b++)
                for (int c = 0; c < 3; c++)
                    Console.WriteLine("масив[{0},{1},{2}]: {3}", a, b, c, massive4[a, b, c]);
    }
}