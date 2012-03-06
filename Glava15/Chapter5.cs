using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

delegate void MyEventHandler();

class Chapter5
{
    public void Handler()
    {
        Console.WriteLine("Event is done");
    }

    public Chapter5()
    {
        MyEvent evt = new MyEvent();

        evt.SomeEvent += Handler;

        evt.OnSomeEvent();
    }
}

class MyEvent
{
    public event MyEventHandler SomeEvent;

    public void OnSomeEvent()
    {
        if (SomeEvent != null)
            SomeEvent();
    }
}

