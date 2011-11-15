using System;

class Chapter4
{
    public Chapter4()
    {
        int a = 999, b = 333;
        double d; //без инициализации
        OtherClass obj1 = new OtherClass(1, 3, ConsoleColor.Red);

        Console.WriteLine("a: {0}, b: {1}", a, b);
        obj1.Swap(ref a, ref b); //принудительный вызов по ссылке, передаваемые аргументы должны быть инициализированны
        Console.WriteLine("a: {0}, b: {1}", a, b);

        /* возврат значения из метода out,
         * только возврат в метод ничего не передается,
         * поэтому инициализация переменной ненужна
         * */
        b = obj1.GetParts(24.8877, out d); 
        Console.WriteLine("целая: {0}, дробная: {1}", b, d);
    }
}