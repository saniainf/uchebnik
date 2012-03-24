using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Chapter8
{
    public Chapter8()
    {
        MyEvent evt = new MyEvent();

        // Add Handler() to the event list. 
        evt.SomeEvent += Handler;

        // Raise the event. 
        evt.OnSomeEvent();
    }

    public void Handler(object sender, EventArgs e)
    {
        Console.WriteLine("Event occurred");
        Console.WriteLine("Source is " + sender);
    }
}

// Declare a class that contains an event. 
class MyEvent
{
    public event EventHandler SomeEvent; // uses EventHandler delegate 

    // This is called to raise SomeEvent. 
    public void OnSomeEvent()
    {
        if (SomeEvent != null)
            SomeEvent(this, EventArgs.Empty);
    }
}
