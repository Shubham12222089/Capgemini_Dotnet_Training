using System;
//[DebugInfo(55,"Glenn Maxwell","10/10/2010",Message ="Return Type Mis-Match")]
class Rectangle
{
    protected double length;
    protected double width;
    public Rectangle(double l, double w)
    {
        this.length=l;
        this.width=w;
    }
    [DebugInfo(55,"Glenn Maxwell","10/10/2010",Message ="Return Type Mis-Match")]
    public double GetArea()
    {
        return length*width;
    }
    [DebugInfo(56,"Glenn Maxwell","10/10/2010")]
    public void Display()
    {
        Console.WriteLine($"Length: {length}");
        Console.WriteLine($"Width: {width}");
        Console.WriteLine($"Area: {GetArea()}");
    }
}