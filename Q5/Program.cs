﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string answer = "Allen";
			
			Console.WriteLine("請輸入密碼不分大小寫");
			string input = Console.ReadLine();
			if(string.IsNullOrEmpty(input))
			{
				Console.WriteLine("您沒有輸入");
				return;
			}
			
			if(answer.ToUpper() == input.ToUpper())
			{
				Console.WriteLine("正確");
				return ;
			}
			Console.WriteLine("錯誤");
		}
	}
}
