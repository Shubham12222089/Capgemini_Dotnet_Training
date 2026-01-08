using System;

class AddTwoNumbers
{
    public delegate void dg_OddNumber(); //Declaring Delegate
    public event dg_OddNumber ev_OddNumber; //Declaring Event

    public void Add()
    {
        int result;
        result = 5+4;
        Console.WriteLine(result.ToString());
        //check is result is odd number then raise event
        if((result%2!=0) && (ev_OddNumber != null))
        {
            ev_OddNumber(); //Raised Event
        }
    }
}