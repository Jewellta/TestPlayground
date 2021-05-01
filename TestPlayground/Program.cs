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


			//middle character
			#region
			//static void middleChar(string str)
			//{
			//	int len = str.Length;
			//	int middle = len / 2;
			//	Console.WriteLine(str[middle]);
			//}
			//String str = "TylerJewell";
			//middleChar(str);

			string input = "confirme";
			string op = "";
			if (input.Length > 0 && input.Length % 2 == 0)					//study this longer
			{
				op = input.Substring((input.Length - 1) / 2, 2);
				Console.WriteLine(op);
			}
			#endregion

			//fizzbuzz
			#region
			for (int i = 1; i <= 100; i++)							//for loop with if conditionals
			{
			if (i % 3 == 0 && i % 5 == 0)
				{Console.WriteLine("FizzBuzz");}
				else if (i % 3 == 0)
				{Console.WriteLine("Fizz");}
				else if (i % 5 == 0)
				{Console.WriteLine("Buzz");
				}else
				{Console.WriteLine(i);}
			}
			#endregion

			//fibonnaci
			#region

			#endregion

			//if given two numbers x, y, return an array of y length that evenly separates x into each space.
			//If it’s not an even separation, make the last part of the array have the larger number

			//int x1= 5;
			//int y1 = 10;
			//int[] arr1 = { };
			//int xdiv = x1 / y.length;

			const Number= Math.Floor(x1+1/y)

		}
		static void Fibonacci_Iterative(int len)
		{
			int a = 0, b = 1, c = 0;

			Console.Write("{0} {1}", a, b);
			for (int i = 2; i < len; i++)
			{
				c = a + b;
				Console.Write(" {0}", c);
				a = b;
				b = c;
			}
		}



	}
}
