using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RUtil
{
	public static class Chino
	{
		public static T[] Append<T>(this T[] source, params T[] elements) {
			return source.Concat(elements).ToArray();
		}
	}
}
