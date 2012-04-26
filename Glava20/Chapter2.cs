using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Glava20
{
    class Chapter2
    {
        public Chapter2()
        {
            DemoPart dp = new DemoPart(5, 3);
            Console.WriteLine(dp.X + "  " + dp.Y);
            dp.ShowXY();
        }
    }
}

partial class DemoPart // разделение класса partial
{
    public int X { get; set; }

    public void ShowXY() // разделение метода
    {
        Show();
    }
}


partial class DemoPart
{
    public int Y { get; set; }

    partial void Show()
    {
        Console.WriteLine("{0}, {1}", X, Y);
    }
}

partial class DemoPart
{
    public DemoPart(int x, int y)
    {
        X = x;
        Y = y;
    }

    partial void Show();
}