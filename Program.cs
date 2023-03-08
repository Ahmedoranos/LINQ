using System;
using System.Collections.Generic;
using System.Linq;
					
public class Program
{
	public static void Main()
	{
		//Using Lambda Expressions to get IEnumerable of males student
		IEnumerable<Student> query_Result = Student.GetAllStudents().Where(student => student.Gender == "Male");
		//Using SQL like query expressions
		IEnumerable<Student> query_SQLLike = from student in Student.GetAllStudents()
											 where student.Gender == "Male"
											 select student;
		foreach(var student in query_Result)
		{
			Console.WriteLine(student.Name); 	
		}
	}
}
//start class student
public class Student
{
	private int ID {set; get;}
	public string Name {set; get;}
	public string Gender {set; get;}
	
	public static List<Student> GetAllStudents()
	{
		List<Student> listStudents = new List<Student>();

        Student student1 = new Student
        {
            ID = 101,
            Name = "Mark",
            Gender = "Male"
        };
		
        listStudents.Add(student1);

        Student student2 = new Student
        {
            ID = 102,
            Name = "Mary",
            Gender = "Female"
        };
		
        listStudents.Add(student2);

        Student student3 = new Student
        {
            ID = 103,
            Name = "John",
            Gender = "Male"
        };
		
		listStudents.Add(student3);
		
		Student student4 = new Student
        {
            ID = 104,
            Name = "Steve",
            Gender = "Male"
        };
        listStudents.Add(student4);

        Student student5 = new Student
        {
            ID = 105,
            Name = "Pam",
            Gender = "Female"
        };
        listStudents.Add(student5);

        return listStudents;
	}
}//end of class student
	
