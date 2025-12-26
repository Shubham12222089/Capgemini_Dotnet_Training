using System;

class Car : Vehical //created a child class Car which inherits the base class Vehical
{
    public Car(double distance,double hour,double fuel) : base(distance, hour, fuel) //calling the base class constructor in derived class
    {
        
    }
    public new void Average()
    {
        double average=0.0;
        average=distance/hour;
        Console.WriteLine($"Average speed of Car is : {average} km/hr");
    }
    public override void Speed()
    {
        double speed=0.0;
        speed=distance/fuel;
        Console.WriteLine($"Average fuel consumption of Car is : {speed} km/litre");
    }
    
}