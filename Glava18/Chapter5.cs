using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Chapter5
{
    public Chapter5()
    {
        // int массивы
        int[] nums = { 1, 2, 3 };
        int[] nums2 = new int[4];

        // вывести содержимое nums
        Console.Write("содержимое nums: ");
        foreach (int x in nums)
            Console.Write(x + " ");

        Console.WriteLine();

        // обработать массив типа int
        ArrayUtils.CopyInsert<int>(99, 2, nums, nums2);

        // вывести содержимое nums2
        Console.Write("содержимое nums2: ");
        foreach (int x in nums2)
            Console.Write(x + " ");

        Console.WriteLine();

        // string массивы
        string[] strs = { "обобщения", "это", "сила." };
        string[] strs2 = new string[4];

        // вывести strs. 
        Console.Write("содержимое strs: ");
        foreach (string s in strs)
            Console.Write(s + " ");

        Console.WriteLine();

        // вставить в массив строк 
        ArrayUtils.CopyInsert<string>("в С#", 1, strs, strs2);

        // вывести содержимое strs2. 
        Console.Write("содержимое strs2: ");
        foreach (string s in strs2)
            Console.Write(s + " ");

        Console.WriteLine();
    }
}

// класс управления массивом, необобщенный
class ArrayUtils
{
    // копировать массив, ввести новый элемент, обобщенный 
    public static bool CopyInsert<TKey>(TKey e, uint idx,
                                     TKey[] src, TKey[] target)
    {

        // проверить размер
        if (target.Length < src.Length + 1)
            return false;

        // скопировать src в новый, вставить е в idx
        for (int i = 0, j = 0; i < src.Length; i++, j++)
        {
            if (i == idx)
            {
                target[j] = e;
                j++;
            }
            target[j] = src[i];
        }
        return true;
    }
}
