using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RUtil.Cappuccino
{
	public static class Jogmaya
	{
		public static T[] Append<T>(this T[] source, params T[] elements) {
			return source.Concat(elements).ToArray();
		}

        public static double Eval(string exp) {
            var formula = Regex.Replace(exp, @"\s", "");
			var values = Regex.Split(formula, @"([\+-\*/\(\),]|\d*\.\d+|\w+)");
			



        }
	}
}
