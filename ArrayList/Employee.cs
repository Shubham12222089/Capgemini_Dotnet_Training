using System.Data.Common;

class Employee
{
    public int Id{get;set;}
    public string Name{get;set;}
    public override string ToString()
    {
        return $"Employee Id {Id} and Name {Name}";
    }
}