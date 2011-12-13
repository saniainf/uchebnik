using System;

class Chapter3
{
    public Chapter3()
    {
        TwoDShape[] shapes = new TwoDShape[5];

        shapes[0] = new TriangleTwoD("right", 8.0, 12.0); //прямоугольный
        shapes[1] = new RectangleTwoD(10);
        shapes[2] = new RectangleTwoD(10, 4);
        shapes[3] = new TriangleTwoD(7.0);
        shapes[4] = new TwoDShape(10, 20, "generic form");

        foreach (TwoDShape obj in shapes)
        {
            Console.WriteLine("object is " + obj.name);
            Console.WriteLine("area is " + obj.Area());

            Console.WriteLine();
        }
    }
}

/* базовый класc */
class TwoDShape
{
    protected double Width;
    protected double Height;
    public string name { get; set; }

    public TwoDShape()
    {
        Width = Height = 0.0;
        name = "null";
    }

    public TwoDShape(double w, double h, string name)
    {
        this.Width = w;
        this.Height = h;
        this.name = name;
    }

    public TwoDShape(double x, string name)
    {
        Width = Height = x;
        this.name = name;
    }

    public TwoDShape(TwoDShape obj)
    {
        this.Width = obj.Width;
        this.Height = obj.Height;
        this.name = obj.name;
    }

    public void Show()
    {
        Console.WriteLine("Width: {0}, Height: {1}", Width, Height);
    }

    public virtual double Area()
    {
        Console.WriteLine("override");
        return 0.0;
    }
}

class TriangleTwoD : TwoDShape
{
    string Style;

    public TriangleTwoD()
    {
        Style = "null";
    }

    public TriangleTwoD(string style, double w, double h)
        : base(w, h, "triangle")
    {
        this.Style = style;
    }

    public TriangleTwoD(double x)
        : base(x, "triangle")
    {
        this.Style = "isosceles"; //равнобедренный :-)
    }

    public TriangleTwoD(TriangleTwoD obj)
        : base(obj)
    {
        this.Style = obj.Style;
    }

    public override double Area()
    {
        return Width * Height / 2;
    }

    public void Showstyle()
    {
        Console.WriteLine("triangle " + Style);
    }
}

class RectangleTwoD : TwoDShape
{
    public RectangleTwoD(double w, double h)
        : base(w, h, "rectangle")
    {

    }

    public RectangleTwoD(double x)
        : base(x, "rectangle")
    {

    }

    public RectangleTwoD(RectangleTwoD obj)
        : base(obj)
    {

    }

    public bool isSquare()
    {
        if (Width == Height) return true;
        return false;
    }

    public override double Area()
    {
        return Width * Height;
    }
}