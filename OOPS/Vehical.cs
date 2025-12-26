using System;
class Vehical
{
    protected double distance=0.0;
    protected double hour=0.0;
    protected double fuel=0.0;
    public Vehical(double distance,double hour,double fuel)
    {
        this.distance=distance;
        this.hour=hour;
        this.fuel=fuel;
    }

    public void Average()
    {
        double average=0.0;
        average=distance/fuel;
        Console.WriteLine($"Average fuel consumption is : {average} km/litre");
    }

    public virtual void Speed()
    {
        double speed=0.0;
        speed=distance/hour;
        Console.WriteLine($"Average speed is : {speed} km/hr");
    }
}