using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Glava19
{
    class Chapter4
    {
        public Chapter4()
        {
            // данные
            Item[] items =
            {
                new Item("Кусачки", 1424),
                new Item("Молоток", 7892),
                new Item("Тиски", 8534),
                new Item("Пила", 6411)
            };

            InStockStatus[] statusList =
            { 
                new InStockStatus(1424, true), 
                new InStockStatus(7892, false), 
                new InStockStatus(8534, true), 
                new InStockStatus(6411, true) 
            };

            var inStockList = from item in items // первый запрос
                              join entry in statusList // объеденить со вторым
                                on item.ItemNumber equals entry.ItemNumber // по элементам
                              select new { item.Name, InStock = entry.InStock }; // вывести с созданием анонимного типа
                                // в item.Name свойстве именем становится имя идентефикатора Name

            Console.WriteLine("Товар\tНаличие\n");

            // Execute the query and display the results. 
            foreach (var t in inStockList)
                Console.WriteLine("{0}\t{1}", t.Name, t.InStock);
        }
    }
}

// A class that links an item name with its number. 
class Item
{
    public string Name { get; set; }
    public int ItemNumber { get; set; }

    public Item(string n, int inum)
    {
        Name = n;
        ItemNumber = inum;
    }
}

// A class that links an item number with its in-stock status. 
class InStockStatus
{
    public int ItemNumber { get; set; }
    public bool InStock { get; set; }

    public InStockStatus(int n, bool b)
    {
        ItemNumber = n;
        InStock = b;
    }
}

// класс Temp ненужен, используется анонимный тип
/*
class Temp
{
    public string Name { get; set; }
    public bool InStock { get; set; }

    public Temp(string n, bool b)
    {
        Name = n;
        InStock = b;
    }
}
*/