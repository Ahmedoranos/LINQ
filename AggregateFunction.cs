using System;
using System.Linq;
namespace Demo
{
    public class Program
    {
        public static void Main()
        {
            string[] countries = { "India", "US", "UK", "Canada", "Australia" };

            string result = countries.Aggregate((a, b) => a + ", " + b);

            Console.WriteLine(result);
			
			int[] numbers = {1,2,3};
			
			int aggregateResult = numbers.Aggregate((a,b) => a*b);
			
			Console.WriteLine(aggregateResult);
        }
    }
}
