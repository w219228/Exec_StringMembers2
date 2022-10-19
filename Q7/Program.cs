using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("請輸入第一個數");
			string num1 = Console.ReadLine();
			Console.WriteLine("請輸入第二個數");
			string num2 = Console.ReadLine();
			
			if(string.IsNullOrEmpty(num1)||string.IsNullOrEmpty(num2))
			{
				Console.WriteLine("請重新輸入");
			}
			
			bool isInt = decimal.TryParse(num1, out decimal n1);
			bool isInt2 = decimal.TryParse(num2, out decimal n2);

			decimal sum = n1 + n2;
			string result = sum.ToString("#.##");
			Console.WriteLine(result);
		}
	}
}
