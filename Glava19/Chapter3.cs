using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Glava19
{
    class Chapter3
    {
        public Chapter3()
        {
            string[] strs = { "alpha", "beta", "gamma" };

            // запрос 
            var chrs = from str in strs
                       let chrArray = str.ToCharArray()
                       from ch in chrArray
                       orderby ch
                       select ch;

            Console.WriteLine("Символы по порядку");

            foreach (char c in chrs)
            {
                Console.Write(c + " ");
            }
        }
    }
}


