using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string answer = "Allen";

			Console.WriteLine("請輸入密碼分大小寫");
			string input = Console.ReadLine();
			if (string.IsNullOrEmpty(input))
			{
				Console.WriteLine("您沒有輸入");
				return;
			}

			if (answer.Substring(0,5) == input.Substring(0,5))
			{
				Console.WriteLine("正確");
				return;
			}
			Console.WriteLine("錯誤");
		}
	}
}
