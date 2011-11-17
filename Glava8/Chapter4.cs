using System;

class Chapter4
{
    public Chapter4()
    {
        int a = 999, b = 333;
        double d; //без инициализации
        OtherClass obj1 = new OtherClass(1, 3, ConsoleColor.Red);
        OtherClass obj2 = new OtherClass(4, 6, ConsoleColor.Green);
        OtherClass obj3 = new OtherClass(7, 9, ConsoleColor.Blue);

        Console.WriteLine("a: {0}, b: {1}", a, b);
        obj1.Swap(ref a, ref b); //принудительный вызов по ссылке, передаваемые аргументы должны быть инициализированны
        Console.WriteLine("a: {0}, b: {1}", a, b);

        /* возврат значения из метода out,
         * только возврат в метод ничего не передается,
         * поэтому инициализация переменной ненужна
         * */
        b = obj1.GetParts(24.8877, out d); 
        Console.WriteLine("целая: {0}, дробная: {1}\n\n", b, d);

        Console.Write("odj2 - ");
        obj2.Draw();

        Console.Write("obj3 - ");
        obj3.Draw();

        Console.Write("\nSwap\n\n");

        /* передача ссылки на объект по ссылке
         * позволяет менять объект 
         * на который указывает ссылка
         * */
        obj1.SwapObj(ref obj2, ref obj3); 

        Console.Write("odj2 - ");
        obj2.Draw();

        Console.Write("obj3 - ");
        obj3.Draw();

        /* передача произвольного
         * количества аргументов
         * params в списке параметров всегда последний
         * */
        int min;

        min = obj1.MinVal("text argument", 21, 54, 67, 21, 1, 23, -45, -35, -12, -13, 4, 6, 7, 8, 5);
        Console.WriteLine("min: {0}", min);

        int[] arrr3 = { 12, 24, 48, 56, 32, 1, 2, -51, -45, -55, -75 };
        min = obj1.MinVal("text argument",arrr3);
        Console.WriteLine("min: {0}", min);

        min = obj1.MinVal("text argument");
    }
}

class Chapter5
{
    public Chapter5()
    {
        FactoryClass obj = new FactoryClass();
        int a, b;

        //наделать объектов используя метод Factory
        for (a = 0, b = 10; a < 10; a++, b--)
        {
            FactoryClass anotherObj = obj.Factory(a, b); //создать новый объект
            anotherObj.Show();
        }

        /*********************************/

        int numfactors;
        int[] factors;

        factors = obj.FindFactors(1000, out numfactors);

        Console.WriteLine("fact 1000: ");
        for (int i = 0; i < numfactors; i++)
            Console.Write(factors[i] + " ");

        Console.WriteLine();
    }
}