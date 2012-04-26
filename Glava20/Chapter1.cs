using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Glava20
{
    class Chapter1
    {
        public Chapter1()
        {
            int? count = null; // обнуляемый тип

            if (count.HasValue)
                Console.WriteLine("есть значение " + count.Value);
            else
                Console.WriteLine("нет значения");

            count = 100;

            if (count.HasValue)
                Console.WriteLine("есть значение " + count.Value);
            else
                Console.WriteLine("нет значения");
        }
    }
}
