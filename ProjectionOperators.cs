using System;
using System.Collections.Generic;
using System.Linq;
					
public class ProjectionOperators
{
	public static void Main()
	{
		/*using select to get the id column alone*/
		IEnumerable<int> result = Employee.GetAllEmployees().Select(x => x.EmployeeID);
		foreach(var x in result)
		{
			Console.WriteLine(x);
		}
		/*Project FirstName & Gender properties of all employees into anonymous type.*/
		var resultAnoType = Employee.GetAllEmployees().Select(x => 
	    new {FirstName = x.FirstName ,Gender = x.Gender} 
		);
		
		foreach(var x in resultAnoType)
		{
			Console.WriteLine(x.FirstName + " , " + x.Gender);
		}
		/*computes FullName and MonthlySalay of all employees and projects these 2 new computed properties into anonymous type*/
		var resultComputed = Employee.GetAllEmployees().Select( x => new{ name = x.FirstName + " " + x.LastName , monthSalary = x.AnnualSalary/12});
		
			foreach(var x in resultComputed)
		{
			Console.WriteLine(x.name + " , " + x.monthSalary);
		}
		/*repeat using SQL like syntax*/
		var resultSQLLike = Employee.GetAllEmployees().Where(x=> x.AnnualSalary > 50000).Select( x => new{ name = x.FirstName + " " + x.LastName , monthSalary = x.AnnualSalary/12});
		Console.WriteLine("---------------------------------");
		foreach(var x in resultSQLLike)
		{
			Console.WriteLine(x.name + " , " + x.monthSalary);
		}
		
	}
}


public class Employee
{
    public int EmployeeID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Gender { get; set; }
    public int AnnualSalary { get; set; }

    public static List<Employee> GetAllEmployees()
    {
        List<Employee> listEmployees = new List<Employee>
        {
            new Employee
            {
                EmployeeID = 101,
                FirstName = "Tom",
                LastName = "Daely",
                Gender = "Male",
                AnnualSalary = 60000
            },
            new Employee
            {
                EmployeeID = 102,
                FirstName = "Mike",
                LastName = "Mist",
                Gender = "Male",
                AnnualSalary = 72000
            },
            new Employee
            {
                EmployeeID = 103,
                FirstName = "Mary",
                LastName = "Lambeth",
                Gender = "Female",
                AnnualSalary = 48000
            },
            new Employee
            {
                EmployeeID = 104,
                FirstName = "Pam",
                LastName = "Penny",
                Gender = "Female",
                AnnualSalary = 84000
            },
        };

        return listEmployees;
    }
}
