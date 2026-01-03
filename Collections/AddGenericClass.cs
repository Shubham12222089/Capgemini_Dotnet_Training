using System;

class AddGenericClass<T> //Generic Class
{
    T n1;
    T n2;
    T result;
    //Generic Constructor
    public AddGenericClass()
    {
        
    }
    public AddGenericClass(T m, T n) //Generic parameterized Constructor
    {
        this.n1=m;
        this.n2=n;
    }

    public T AddAllType(T num1, T num2)
    {
        
        dynamic x = num1;
        dynamic y = num2;
        result = x+y;
        return result;
    }
}