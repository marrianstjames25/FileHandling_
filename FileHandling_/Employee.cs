using System;
namespace Hashtables_
{
    public class Employee
    {

        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public Employee(int employeeID, string FirstName, string LastName)
        {
            this.EmployeeID = employeeID;
            this.LastName = FirstName;
            this.FirstName = LastName;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"EmployeeId:{this.EmployeeID} \n" +
                $"First Name: {this.FirstName} \n" +
                $"Last Name: {this.LastName}");
        }


        ~Employee()
        {
            Console.WriteLine("Clean up, close db connection etc");
        }
    }
}