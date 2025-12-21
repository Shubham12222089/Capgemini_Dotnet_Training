
class Employee
{
    private int Id;
    private string Names=string.Empty;
    private string Department=string.Empty;
    private float Salary=0.0f;
    private bool status=true;

    //Properties for all fields
    public int EmpId //id property
    {
        get { return Id; }
        set { Id = value; }
    }
    public string EmpName //name property
    {
        get { return Names; }
        set { Names = value; }
    }
    public string EmpDepartment //department property
    {
        get { return Department; }
        set { Department = value; }
    }
    public float EmpSalary //salary property
    {
        get { return Salary; }
        set { Salary = value; }
    }
    public bool EmpStatus //status property
    {
        get { return status; }
        set { status = value; }
    }

    public void AcceptDetails()
    {
        Console.WriteLine("Enter Employee Details: ");
        Console.WriteLine("Enter Id: ");
        Id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Employee Name: ");
        Names=Console.ReadLine();
        Console.WriteLine("Enter Employee Department: ");
        Department=Console.ReadLine();
        Console.WriteLine("Enter Employee Salary: ");
        Salary=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Employee Status on project :True or False");
        status=Convert.ToBoolean(Console.ReadLine());

    }

    public void SalaryDetails()
    {
        int pf=(int)(Salary*0.12);
        Console.WriteLine("The PF amount deducted from the salary is: "+pf);
        int hra=(int)(Salary*0.20);
        Console.WriteLine("The HRA amount added to the salary is: "+hra);
        int da=(int)(Salary*0.18);
        Console.WriteLine("The DA amount added to the salary is: "+da);
        int grossSalary=(int)(Salary+hra+da);
        Console.WriteLine("The Gross Salary of the Employee is: "+grossSalary);
        int netSalary=(int)(grossSalary-pf);
        Console.WriteLine("The Net Salary of the Employee is: "+netSalary);
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Employee Details: ");
        Console.WriteLine($"Employee Id: {Id}");
        Console.WriteLine($"Employee Name: {Names}");
        Console.WriteLine($"Employee Department: {Department}");
        Console.WriteLine($"Employee Salary: {Salary}");
        Console.WriteLine($"Employee Status on project: {status}");
    }


}


