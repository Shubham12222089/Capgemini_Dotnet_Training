using System;
// class Employee:IComparable<Employee>
// {
//     public int Id{get;set;}
//     public string Name{get;set;}

//     public int CompareTo(Employee other)
//     {
//         return this.Id.CompareTo(other.Id);
//     }

//     public override string ToString()
//     {
//         return $"Employee Id is : {Id}\nEmployee Name is : {Name}";
//     }
// }

class Employee : IComparable<Employee>
{
    public int Id { get; set; }
    public string Name { get; set; }

    // Sorting logic
    public int CompareTo(Employee other)
    {
        // First compare by Id
        int idResult = this.Id.CompareTo(other.Id);

        // If Id is same, compare by Name
        if (idResult == 0)
        {
            return this.Name.CompareTo(other.Id);
        }

        return idResult;
    }

    // Output formatting
    public override string ToString()
    {
        return $"Employee Id: {Id}, Employee Name: {Name}";
    }
}
