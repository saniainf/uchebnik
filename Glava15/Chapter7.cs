using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Chapter7
{
    public Chapter7()
    {
        XChap7 ob1 = new XChap7();
        YChap7 ob2 = new YChap7();
        MyEventChap7 evt = new MyEventChap7();

        // Add Handler() to the event list. 
        evt.SomeEvent += ob1.Handler;
        evt.SomeEvent += ob2.Handler;

        // Raise the event. 
        evt.OnSomeEvent();
        evt.OnSomeEvent();
    }

}


// Derive a class from EventArgs. 
class MyEventArgs : EventArgs
{
    public int EventNum;
}

// Declare a delegate type for an event.  
delegate void MyEventHandlerChap7(object sender, MyEventArgs e);

// Declare a class that contains an event. 
class MyEventChap7
{
    static int count = 0;

    public event MyEventHandlerChap7 SomeEvent;

    // This raises SomeEvent. 
    public void OnSomeEvent()
    {
        MyEventArgs arg = new MyEventArgs();

        if (SomeEvent != null)
        {
            arg.EventNum = count++;
            SomeEvent(this, arg);
        }
    }
}

class XChap7
{
    public void Handler(object sender, MyEventArgs e)
    {
        Console.WriteLine("Event " + e.EventNum +
                          " received by an X object.");
        Console.WriteLine("Source is " + sender);
        Console.WriteLine();
    }
}

class YChap7
{
    public void Handler(object sender, MyEventArgs e)
    {
        Console.WriteLine("Event " + e.EventNum +
                          " received by a Y object.");
        Console.WriteLine("Source is " + sender);
        Console.WriteLine();
    }
}

