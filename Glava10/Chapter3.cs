using System;

class Chapter3
{
    public Chapter3()
    {
        SimpProp ob = new SimpProp();

        Console.WriteLine("Original value of ob.MyProp: " + ob.MyProp);

        ob.MyProp = 100; // assign value 
        Console.WriteLine("Value of ob.MyProp: " + ob.MyProp);

        // Can't assign negative value to prop. 
        Console.WriteLine("Attempting to assign -10 to ob.MyProp");
        ob.MyProp = -10;
        Console.WriteLine("Value of ob.MyProp: " + ob.MyProp); 
    }
}

class Accesor
{
    public Accesor()
    {

    }
}

class SimpProp
{
    int prop; // field being managed by MyProp 

    public SimpProp() { prop = 0; }

    /* This is the property that supports access to 
       the private instance variable prop.  It 
       allows only positive values. */
    public int MyProp
    {
        get
        {
            return prop;
        }
        set
        {
            if (value >= 0) prop = value;
        }
    }
}