using System;
using System.Collections.Generic;

class Example
{
    static void Main()
    {
        string numb;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("1. Базовый пример\n"+
                        "2. Stack\n" +
                        "3. Передача объектов по ссылке\n" +
                        "4. ref out params\n" +
                        "5. return object, array\n" +
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
            case "3":
                Console.Clear();
                Chap3();
                break;
            case "4":
                Console.Clear();
                Chap4();
                break;
            case "5":
                Console.Clear();
                Chap5();
                break;
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

    static void Chap3()
    {
        Chapter3 chapter3 = new Chapter3();
    }
    
    static void Chap4()
    {
        Chapter4 chapter4 = new Chapter4();
    }
    
    static void Chap5()
    {
        Chapter5 chapter5 = new Chapter5();
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
        bool timework = true;

        do
        {
            Console.Clear();
            stackInfo();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Меню стека\n");
            Console.Write("1. Поместить в стек\n" +
                            "2. Извлечь из стека\n" +
                            "3. Извлечь весь стек\n" +
                            "4. Вывести весь стек\n" +
                            "5. Выход\n" +
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
                    PrintAllStack();
                    break;
                case "5":
                    Console.Clear();
                    timework = false;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("error\n\terror\n\t\terror\n\t\t\terror\n\t\t\t\terror\n\n\nне вводи всякую херню\n\n\nжмакни Enter");
                    Console.ReadLine();
                    Console.Clear();
                    break;
            }
        } while (timework);
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
            return;
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
                return;
            }
            stack.Push(inputStr[a]);
        }
    }

    private void PullStack()
    {
        if (stack.isEmpty())
        {
            Console.WriteLine("\nСтек пустой");
            Console.ReadLine();
            return;
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
                return;
            }
            Console.Write("{0}\t", stack.Pull());
            if (++countTable == 5)
            {
                Console.WriteLine("\n");
                countTable = 0;
            }
        }
        Console.ReadLine();
    }

    private void PullAllStack()
    {
        if (stack.isEmpty())
        {
            Console.WriteLine("\nСтек пустой");
            Console.ReadLine();
            return;
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
    }

    private void PrintAllStack()
    {
        if (stack.isEmpty())
        {
            Console.WriteLine("\nСтек пустой");
            Console.ReadLine();
            return;
        }
        int countTable = 0;
        for (int a = stack.GetIndex() - 1; a >= 0; a--)
        {
            Console.Write("{0}\t", stack.Print(a));
            if (++countTable == 5)
            {
                Console.WriteLine("\n");
                countTable = 0;
            }
        }
        Console.ReadLine();

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

    /*вывести произвольную ячейку*/
    public char Print(int a)
    {
        if (indx == 0)
        {
            Console.WriteLine("\nОшибка !!! Стек пуст\n");
            return (char)0;
        }
        return stck[a];
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

class OtherClass
{
    public int alpha, beta;
    public ConsoleColor color;

    public OtherClass(int a, int b, ConsoleColor color)
    {
        alpha = a;
        beta = b;
        this.color = color;
    }

    public void Copy(OtherClass obj)
    {
        this.alpha = obj.alpha;
        this.beta = obj.beta;
        this.color = obj.color;
    }

    public void Draw()
    {
        Console.ForegroundColor = color;
        Console.WriteLine("alpha {0}, beta {1}\n", alpha, beta);
        Console.ResetColor();
    }

    public void Change(OtherClass ob)
    {
        ob.alpha = ob.alpha + ob.beta;
        ob.beta = -ob.beta;
        ob.color = ConsoleColor.White;
    }

    public void Swap(ref int a, ref int b)//принудительный вызов по ссылке
    {
        int swap;
        swap = a;
        a = b;
        b = swap;
    }

    public int GetParts(double n, out double frac)//возврат значения из метода
    {
        int a = (int)n;
        frac = n - a;
        return a;
    }

    public void SwapObj(ref OtherClass obj1, ref OtherClass obj2)
    {
        OtherClass swap;
        swap = obj1;
        obj1 = obj2;
        obj2 = swap;
    }

    /* params произвольное количество аргументов 
     * params в списке параметров всегда последний
     * */
    public int MinVal(string str, params int[] numb) 
    {
        int min;
        if (numb.Length == 0)
        {
            Console.WriteLine("No argument");
            return 0;
        }

        min = numb[0];
        foreach (int a in numb)
            if (a < min) min = a;

        Console.Write(str + "\t");
        return min;
    }

}

class FactoryClass
{
    int alpha, beta;

    public FactoryClass Factory(int a, int b) //метод который возвращает объект этого класса
    {
        FactoryClass obj = new FactoryClass();

        obj.alpha = a;
        obj.beta = b;

        return obj;
    }

    public void Show()
    {
        Console.WriteLine("a: {0} , b: {1}", alpha, beta);
    }

    public int[] FindFactors(int num, out int numfactors) //метод возвращает массив (множители num)
    {
        int[] facts = new int[80];
        int a, b;

        for (a=2, b =0; a<num/2 +1; a++)
            if ((num % a) == 0)
            {
                facts[b] = a;
                b++;
            }
        numfactors = b;
        return facts;
    }
}