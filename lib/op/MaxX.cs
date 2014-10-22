using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.rational.op
{
	public partial class MaxX
	{

		static public Rational_InheritFraction2 Do(Rational_InheritFraction2 a,Rational_InheritFraction2 b) {
			return a < b ? b : a;
		}
		


	}
}
