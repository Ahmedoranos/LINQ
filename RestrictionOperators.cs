using System;
using System.Linq;
using System.Collections.Generic;

public class RestrictionOperators
{
	public static void Main()
	{
		List<int> numbers = new List<int>{1,2,3,4,5,6,7,8,9,10};
		IEnumerable<int> evenNumbers = numbers.Where(x => x % 2 == 0);
		/*SQL like syntax*/
		IEnumerable<int> evenNumbers_SQLLike = 
			from num in numbers			                                   
			where num % 2 == 0
			select num ;
		foreach(var num in evenNumbers_SQLLike)
		{
			Console.WriteLine(num);
		}
	}
}
