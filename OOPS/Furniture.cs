using System;

//we make abstract class because we want to override its methods in derived class
public abstract class Furniture
{
    protected int num;
    protected string color = string.Empty;
    protected int width;
    protected int height;
    public abstract void Accept();
    public abstract void Display();

    public void MyMethod()
    {
        Console.WriteLine("MyMethod");
    }
}