using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Glava19
{
    class Chapter5
    {
        public Chapter5()
        {

            // массив классификации техники 
            string[] travelTypes =
            {
                "Воздушный",
                "Морской",
                "Наземный"
            };

            // массив видов техники
            Transport[] transports =
            { 
                new Transport("велик", "Наземный"), 
                new Transport("возд шар", "Воздушный"), 
                new Transport("лодка", "Морской"), 
                new Transport("самолет", "Воздушный"), 
                new Transport("каноэ", "Морской"), 
                new Transport("биплан", "Воздушный"), 
                new Transport("машина", "Наземный"), 
                new Transport("корабль", "Морской"), 
                new Transport("поезд", "Наземный") 
            };

            // запрос с груповым объединением
            var byHow = from how in travelTypes
                        join trans in transports
                        on how equals trans.How
                        into lst
                        select new { How = how, Tlist = lst };

            // вывести результат
            foreach (var t in byHow)
            {
                Console.WriteLine("В категории {0} транспорт", t.How);

                foreach (var m in t.Tlist)
                    Console.WriteLine("  " + m.Name);

                Console.WriteLine();
            }
        }
    }
}


// класс вид транспрта, тип транспорта
class Transport
{
    public string Name { get; set; }
    public string How { get; set; }

    public Transport(string n, string h)
    {
        Name = n;
        How = h;
    }
}

