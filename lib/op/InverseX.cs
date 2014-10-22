using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational.op
{
	static public partial class InverseX
	{

		static public Rational_InheritFraction2 Inverse(this BigInteger denominator) {
			return new R(1,denominator);
		}

		static public Rational_InheritFraction2 Inverse(this Rational_InheritFraction2 r) {

			return DivideX.Eval(1, r);
		
		}
	


	}
}
