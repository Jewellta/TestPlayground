using System;

namespace TestPlayground
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = { 450, 285, 267, 148, 946, 605, 883, 826, 258, 301, 130, 354, 226, 899 };
			var min = 1000;
			var max = 0;
				foreach(var num in arr)
			{
				if (num > max) max = num;
				if (num < min) min = num;
			}
			Console.WriteLine($"the min is {min} the max is {max} ");

			var x = 10;
			var y = 4;
			var color = "black";
			color = (x > y) ? "red" : "green";


			//fizzbuzz
		
			
			//fibonnaci



		}

		


	}
}
