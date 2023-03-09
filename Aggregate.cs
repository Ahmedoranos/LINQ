using System;		
using System.Collections.Generic;
using System.Linq;
public class Aggregate
{
	public static void Main()
	{
		int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
		int min_Result = Numbers.Min();
		Console.WriteLine(min_Result);
		
		int max_Result = Numbers.Max();
		Console.WriteLine(max_Result);
		
		//get minimum even number
		int min_Even = Numbers.Where(x=> x % 2 == 0).Min();
		
		int number_Sum = Numbers.Sum();
		Console.WriteLine(number_Sum);
		//sum of all even number
		int sum_Even = Numbers.Where(x=> x % 2 == 0).Sum();
		Console.WriteLine(sum_Even);
		
		int array_Count = Numbers.Count();
		Console.WriteLine(array_Count);

		double averageOfAllNumbers = Numbers.Average();
		Console.WriteLine(averageOfAllNumbers);
		//using Min() with user defined type
		List<Person> p = new List<Person>() 
		{ 
	          new Person(){ Id = 2, Name="Bill"},
	          new Person(){ Id = 3, Name="Steve"},
		  new Person(){ Id = 4, Name="Ram"},
		  new Person(){ Id = 5, Name="Abdul"},
		  new Person(){ Id = 6, Name="Abdul"}
	        };
		int resultPerson = p.Min(x=> x.Id);
		Console.WriteLine(resultPerson);
		
	}
}
