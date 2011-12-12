using System;

class Chapter1 : IClass
{
    public Chapter1()
    {

    }

    public int alpha()
    {
        return 0;
    }

    public void Reset()
    {

    }

    public void SetStart(int x)
    {

    }
}

public interface IClass //интерфейс
{
    int alpha();
    void Reset();
    void SetStart(int x);
}