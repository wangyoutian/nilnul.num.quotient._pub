using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Q = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational.op
{
	static public partial class SubtractX
	{

		static public Rational_InheritFraction2 Eval(Q x, Q y) {

			return Q.Subtract(x, y);

		}
	


	}
}
