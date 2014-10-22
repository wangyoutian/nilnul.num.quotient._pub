using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q=nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational.op
{
	static public partial class MultiX
	{

		static public Q Eval( Q a, Q b)
		{
			return Q.Multiply(a, b);
		
		}

		static public Q Square(this Q x) {

			return Eval(x, x);
		
		}

		

	}
}
