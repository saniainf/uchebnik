using System;
using System.Collections.Generic;

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
                            "5. Увеличить размер стека\n" +
                            "6. Уменьшить размер стека\n" +
                            "0. Выход\n" +
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
                    IncreaseSize();
                    break;
                case "6":
                    Console.Clear();
                    DecreaseSize();
                    break;
                case "0":
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
        string inputStr;
        Console.Write("Ввод: ");
        inputStr = Console.ReadLine();
        if (inputStr.Length > stack.Capacity() - stack.GetIndex())
        {
            Console.WriteLine("\n\nРазмер входных данных больше размера стека");
            IncreaseSize(inputStr);
        }
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

    private void IncreaseSize(string inputStr)
    {
        int inc = stack.GetIndex() + inputStr.Length - stack.Capacity();
        string command;
        Console.Write("\nУвеличить размер стека? (yes/no) ");
        command = Console.ReadLine();
        switch (command)
        {
            case "yes":
                stack = new classStack(stack, stack.GetIndex(), inc);
                break;
            case "y":
                stack = new classStack(stack, stack.GetIndex(), inc);
                break;
            case "no":
                break;
            case "n":
                break;
            default:
                Console.Clear();
                Console.WriteLine("error\n\terror\n\t\terror\n\t\t\terror\n\t\t\t\terror\n\n\nне вводи всякую херню\n\n\nжмакни Enter");
                Console.ReadLine();
                Console.Clear();
                return;
        }
        return;
    }

    private void IncreaseSize()
    {
        Console.Write("На сколько увеличить: ");
        stack = new classStack(stack, stack.GetIndex(), Convert.ToInt32(Console.ReadLine()));
    }

    private void DecreaseSize()
    {
        string command;
        int dec = 0;
        int indx = 0;
        Console.Write("Уменьшение размера может привести к потере данных\nВы уверены? (yes/no) ");
        command = Console.ReadLine();
        switch (command)
        {
            case "yes":
                break;
            case "y":
                break;
            case "no":
                return;
            case "n":
                return;
            default:
                Console.Clear();
                Console.WriteLine("error\n\terror\n\t\terror\n\t\t\terror\n\t\t\t\terror\n\n\nне вводи всякую херню\n\n\nжмакни Enter");
                Console.ReadLine();
                Console.Clear();
                return;
        }
        Console.Write("На сколько уменьшить: ");
        dec = Convert.ToInt32(Console.ReadLine());
        /*блок проверок*/
        if (dec > stack.Capacity())
        {
            Console.WriteLine("\nПревышает общий размер стека. Операция невозможна");
            Console.ReadLine();
            return;
        }
        indx = stack.GetIndex() > (stack.Capacity() - dec) ? (stack.Capacity() - dec) : stack.GetIndex();
        /*-------------*/
        stack = new classStack(stack, indx, -dec);
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

    public classStack(classStack obj, int indx, int a)
    {
        this.indx = indx;
        stck = new char[obj.stck.Length + a];
        if (a > 0)
        {
            for (int i = 0; i < obj.stck.Length; i++)
                stck[i] = obj.stck[i];
        }
        else
        {
            for (int i = 0; i < stck.Length; i++)
                stck[i] = obj.stck[i];
        }
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

