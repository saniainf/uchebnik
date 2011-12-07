using System;

class Chapter1
{
    public Chapter1()
    {
        Triangle triangle1 = new Triangle(4.0, 4.0, "ravnobed");
        Triangle triangle2 = new Triangle(8.0, 12.0, "pryamougol");

        Console.WriteLine("triangle1");
        triangle1.ShowStyle();
        triangle1.ShowDim();
        Console.WriteLine("Area: {0}", triangle1.Area());
        Console.WriteLine();
        Console.WriteLine("triangle2");
        triangle2.ShowStyle();
        triangle2.ShowDim();
        Console.WriteLine("Area: {0}", triangle2.Area());
    }
}

class object2D
{
    protected double Width;
    protected double Height{get; private set;}

    public object2D(double w, double h)
    {
        this.Width = w;
        this.Height = h;
    }

    public void ShowDim()
    {
        Console.WriteLine("Width: {0}, Height: {1}", Width, Height);
    }
}

class Triangle : object2D
{
    string Style;

    public Triangle(double width, double height, string style):base (width, height)
    {
        this.Style = style;
    }

    public double Area()
    {
        return Width * Height / 2;
    }

    public void ShowStyle()
    {
        Console.WriteLine("Triangle " + Style);
    }
}