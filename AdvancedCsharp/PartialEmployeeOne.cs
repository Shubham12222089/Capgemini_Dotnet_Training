using System.Runtime.CompilerServices;

namespace PartialDemo
{
    public partial class PartialEmployee
    {
        private string _FirstName;
        private string _LastName;
        private double _Salary;
        private string _Gender;
        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }
        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }
        public double Salary
        {
            get { return _Salary; }
            set { _Salary = value; }
        }
        public string Gender
        {
            get { return _Gender; }
            set { _Gender = value; }
        }
        partial void PartialMethod(); //Declaration of partial method
    }
}