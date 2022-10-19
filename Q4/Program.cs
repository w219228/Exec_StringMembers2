using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string date = "110/02/25";
			DateTime dateTime =Convert.ToDateTime(date);
			DateTime result = dateTime.AddYears(1911);
			string result1 = result.ToString("yyyy/MM/dd");
			Console.WriteLine(result1);
		}
	}
}
