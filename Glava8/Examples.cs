using System;

class Example
{
    static void Main()
    {
        string numb;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("1. Базовый пример\n"+
                        "2. Stack\n" +
                        //"3. Неявно типизированные массивы\n" +
                        //"4. foreach\n" +
                        //"5. bubble sort\n" +
                        //"6. quicksort\n" +
                        //"7. String\n" +
                        //"8. Число в слова\n" +
                        "\n");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Введи номер части: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        numb = Console.ReadLine();
        Console.ResetColor();
        Console.Write("\n\n");

        switch (numb)
        {
            case "1":
                Console.Clear();
                Chap1();
                break;
            case "2":
                Console.Clear();
                Chap2();
                break;
            //case "3":
            //    Console.Clear();
            //    Chap3();
            //    break;
            //case "4":
            //    Console.Clear();
            //    Chap4();
            //    break;
            //case "5":
            //    Console.Clear();
            //    Chap5();
            //    break;
            //case "6":
            //    Console.Clear();
            //    Chap6();
            //    break;
            //case "7":
            //    Console.Clear();
            //    Chap7();
            //    break;
            //case "8":
            //    Console.Clear();
            //    Chap8();
            //    break;
            default:
                Console.WriteLine("не вводи всякую херню\n\n\n");
                Main();
                break;
        }
    }

    static void Chap1()
    {
        AccessZero classAccess = new AccessZero();
        /*доступ к полям объекта через методы доступа*/
        classAccess.SetA(Convert.ToInt32(Console.ReadLine()));
        classAccess.SetB(Convert.ToInt32(Console.ReadLine()));
        classAccess.c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("a: {0}, b: {1}, c: {2}", classAccess.GetA(), classAccess.GetB(), classAccess.c);
    }

    static void Chap2()
    {
        StackDrv startStack = new StackDrv();
    }
}

class AccessZero
{
    /*поля класса*/
    private int a; //явный private доступ
    int b; //private по умолчанию
    public int c; //публик доступ

    /*методы доступа*/
    public void SetA(int a)
    {
        this.a = a;
    }

    public int GetA()
    {
        return a;
    }

    public void SetB(int b)
    {
        this.b = b;
    }

    public int GetB()
    {
        return b;
    }
}

#region Stack

class StackDrv
{
    classStack stack;

    public StackDrv()
    {
        Console.Write("Размер стека: ");
        stack = new classStack(Convert.ToInt32(Console.ReadLine()));
        Menu();
    }

    private void Menu()
    {
        string numb;

        Console.Clear();
        stackInfo();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Меню стека\n");
        Console.Write("1. Поместить в стек\n" +
                        "2. Извлечь из стека\n" +
                        "3. Извлечь весь стек\n" +
                        "4. Выход\n" +
                        "\n");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("ввод: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        numb = Console.ReadLine();
        Console.ResetColor();
        Console.Write("\n\n");


        switch (numb)
        {
            case "1":
                Console.Clear();
                PushStack();
                break;
            case "2":
                Console.Clear();
                PullStack();
                break;
            case "3":
                Console.Clear();
                PullAllStack();
                break;
            case "4":
                Console.Clear();
                Environment.Exit(0);
                break;
            default:
                Console.Clear();
                Console.WriteLine("error\n\terror\n\t\terror\n\t\t\terror\n\t\t\t\terror\n\n\nне вводи всякую херню\n\n\nжмакни Enter");
                Console.ReadLine();
                Console.Clear();
                Menu();
                break;
            }
    }

    private void stackInfo()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Размер стека: ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(stack.Capacity() + "    ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Текущий индекс: ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(stack.GetIndex() + "\n\n\n\n\n");
    }

    private void PushStack()
    {
        if (stack.isFull())
        {
            Console.WriteLine("\nСтек заполнен");
            Console.ReadLine();
            Menu();
        }
        string inputStr;
        Console.Write("Ввод: ");
        inputStr = Console.ReadLine();
        for (int a = 0; a < inputStr.Length; a++)
        {
            if (stack.isFull())
            {
                Console.WriteLine("\nПревышен размер стека. Сохранено {0} первых.", a);
                Console.ReadLine();
                Menu();
            }
            stack.Push(inputStr[a]);
        }
        Menu();
    }

    private void PullStack()
    {
        if (stack.isEmpty())
        {
            Console.WriteLine("\nСтек пустой");
            Console.ReadLine();
            Menu();
        }
        int countTable = 0;
        int pullIndx;
        Console.Write("Кол-во ячеек для вывода: ");
        pullIndx = Convert.ToInt32(Console.ReadLine());
        Console.Write("\n");
        for (; pullIndx > 0; pullIndx--)
        {
            if (stack.isEmpty())
            {
                Console.WriteLine("\n\nДостигнут конец стека. Стек пуст.");
                Console.ReadLine();
                Menu();
            }
            Console.Write("{0}\t", stack.Pull());
            if (++countTable == 5)
            {
                Console.WriteLine("\n");
                countTable = 0;
            }
        }
        Console.ReadLine();
        Menu();
    }

    private void PullAllStack()
    {
        if (stack.isEmpty())
        {
            Console.WriteLine("\nСтек пустой");
            Console.ReadLine();
            Menu();
        }
        int countTable = 0;
        for (int a = stack.GetIndex(); a > 0; a--)
        {
            Console.Write("{0}\t", stack.Pull());
            if (++countTable == 5)
            {
                Console.WriteLine("\n");
                countTable = 0;
            }
        }
        Console.ReadLine();
        Menu();

    }

}

class classStack
{
    /*поля*/
    char[] stck;
    int indx;

    /*конструктор*/
    public classStack(int size)
    {
        stck = new char[size];
        indx = 0;
    }

    /*поместить в стек*/
    public void Push(char chr)
    {
        if (indx == stck.Length)
        {
            Console.WriteLine("\nОшибка !!! Стек заполнен\n");
            return;
        }
        stck[indx] = chr;
        indx++;
    }

    /*извлечь из стека*/
    public char Pull()
    {
        if (indx == 0)
        {
            Console.WriteLine("\nОшибка !!! Стек пуст\n");
            return (char)0;
        }
        indx--;
        return stck[indx];
    }

    /*true если полный*/
    public bool isFull()
    {
        return indx == stck.Length;
    }

    /*true если пустой*/
    public bool isEmpty()
    {
        return indx == 0;
    }

    /*емкость стека*/
    public int Capacity()
    {
        return stck.Length;
    }

    /*текущий индекс*/
    public int GetIndex()
    {
        return indx;
    }
}

#endregion