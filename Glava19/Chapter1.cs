using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Glava19
{
    namespace Chap1
    {
        class Chapter1
        {
            public Chapter1()
            {
                int[] nums = { 3, 8, 1, -2, 3, 0, -4, 5, 13, 45, 54, 785 };
                string[] str = { "q", "w", "e", "r", "t", "y" };

                var posNums = from n in nums // откуда извлекать
                              where n > 0 && n < 10 // условие
                              orderby n descending // сортировка по убывающей
                              select n; // выдать

                Console.Write("положительные значения меньше 10 из nums: ");

                foreach (var i in posNums) Console.Write(i + " ");

                Console.WriteLine();
            }
        }
    }
}
