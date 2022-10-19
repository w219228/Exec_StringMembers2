using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string name = "aLLeN kUO";
			string toLower = name.ToLower();
			string result = toLower.Substring(0, 1).ToUpper()+ toLower.Substring(1,5)+toLower.Substring(6, 1).ToUpper()+ toLower.Substring(7);
			Console.WriteLine(result);
		}
	}
}
