using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibbonachi
{
	class Program
	{


		static long Fibonacci(int n)
		{
			if (n < 3)
				return 1;
			else
				return Fibonacci(n - 1) + Fibonacci(n - 2);
		}
		static void Main(string[] args)
		{
			int n = 0;
			do
			{
				Console.WriteLine("vvedite chlen posledovatelnosti");
				n = Convert.ToInt32(Console.ReadLine());
			} while (n < (-45) || n > (45));
			
			int first = 0;
			int second = 1;
			for (int i = 0; i < n; i++)
			{
				second = first + second;
				first = second - first;
			}
			if (n < 0)
				Console.WriteLine(first * (-1) + "   ");
			else
				Console.WriteLine(first  + "   ");
		Console.ReadKey();

		}
		
	}
}
