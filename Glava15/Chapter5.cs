using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

delegate void MyEventHandler();

class Chapter5
{
    public Chapter5()
    {
        MyEventChap6 evt = new MyEventChap6();
        Subscribers1 sub1 = new Subscribers1();
        Subscribers2 sub2 = new Subscribers2();

        evt.SomeEvent += sub1.Handler1;
        evt.SomeEvent += sub2.Handler2;

        evt.OnSomeEvent();
    }
}

class MyEvent2
{
    public event MyEventHandler SomeEvent;

    public void OnSomeEvent()
    {
        if (SomeEvent != null)
            SomeEvent();
    }
}

class Subscribers1
{
    public void Handler1()
    {
        Console.WriteLine("Event handle sub1");
    }
}

class Subscribers2
{
    public void Handler2()
    {
        Console.WriteLine("Event handle sub2");
    }
}

