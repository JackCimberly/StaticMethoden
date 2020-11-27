using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethoden
{
	static class Helper
	{

		public static int FirstSummand { get; set; }
		public static int SecondSummand { get; set; }

		public static int BerechneAddition(int firstSummand, int secondSummand)
		{
			return firstSummand + secondSummand;
		}



	}
}
