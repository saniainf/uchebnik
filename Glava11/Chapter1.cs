using System;

class Chapter1
{
    public Chapter1()
    {
        Triangle triangle1 = new Triangle(4.0, 4.0, "ravnobed");
        Triangle triangle2 = new Triangle(8.0, 12.0, "pryamougol");
        Triangle triangle3 = new Triangle(triangle1); //новый объект дублированием объекта

        Console.WriteLine("triangle1");
        triangle1.Show();
        Console.WriteLine("Area: {0}", triangle1.Area());
        Console.WriteLine();

        Console.WriteLine("triangle2");
        triangle2.Show();
        Console.WriteLine("Area: {0}", triangle2.Area());
        Console.WriteLine();

        Console.WriteLine("triangle3");
        triangle3.Show();
        Console.WriteLine("Area: {0}", triangle3.Area());
    }
}

/* базовый класc */
class object2D
{
    protected double Width;
    protected double Height { get; private set; }

    public object2D(double w, double h)
    {
        this.Width = w;
        this.Height = h;
    }

    public object2D(object2D obj)
    {
        this.Width = obj.Width;
        this.Height = obj.Height;
    }

    public void Show()
    {
        Console.WriteLine("Width: {0}, Height: {1}", Width, Height);
    }
}

/* наследуемый класc */
class Triangle : object2D
{
    string Style;

    public Triangle(double width, double height, string style)
        : base(width, height)
    {
        this.Style = style;
    }

    public Triangle(Triangle obj)
        : base(obj)
    {
        this.Style = obj.Style;
    }

    public double Area()
    {
        return Width * Height / 2;
    }

    new public void Show() //метод Show из базового класса скрывается
    {
        base.Show(); //вызов метода Show из базового класса
        Console.WriteLine("Triangle " + Style);
    }
}
