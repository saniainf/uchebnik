using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Glava19
{
    class Chapter6
    {
        public Chapter6()
        {
            int[] nums = { 3, 8, 1, -2, 3, 0, -4, 5, 13, 45, 54, 7 };

            /*
            var posNums = from n in nums // откуда извлекать
                          where n > 0 && n < 10 // условие
                          orderby n descending // сортировка по убывающей
                          select n; // выдать
            */

            var posNums = nums.Where(n => n > 0 && n < 10).OrderBy(o => o).Select(s => s * 10); // запрос с помощью методов
            Console.Write("положительные значения меньше 10 из nums: ");

            foreach (var i in posNums) Console.Write(i + " ");

            Console.WriteLine("\n");

            // дополнительные методы запросов

            Console.WriteLine("минимальное значение " + nums.Min());
            Console.WriteLine("максимальное значение " + nums.Max());

            Console.WriteLine("первое значение " + nums.First());
            Console.WriteLine("последнее значение " + nums.Last());

            Console.WriteLine("сумма " + nums.Sum());
            Console.WriteLine("среднее значение " + nums.Average());

            if (nums.All(n => n > 0))
                Console.WriteLine("все значение больше 0");

            if (nums.Any(n => (n % 2) == 0))
                Console.WriteLine("есть четное значение");

            if (nums.Contains(3))
                Console.WriteLine("масив содержит значение 3.");
            
            Console.WriteLine();

            // совмесный вызов

            var ltAvg = from n in nums
                        let X = nums.Average()
                        where n < X
                        select n;

            Console.WriteLine("Среднее значение " + nums.Average());

            foreach (int i in ltAvg)
            {
                Console.WriteLine(i + " ");
            }

            Console.WriteLine();
        }
    }
}
