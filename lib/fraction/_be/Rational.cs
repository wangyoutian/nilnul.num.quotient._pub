using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.rational.fraction._be
{
	public partial class Rational
	{
		static public bool Eval(Fraction140728 fraction) {
			return nilnul.num.i.op.Gcd.Eval(fraction.numerator, fraction.denominator).val==1;
		}

		public class Converted
			:num.rational.Fraction140728
		{
			public Converted(BigInteger x, BigInteger y)
				:base(x,y)
			{
				simplify();
			}
			
			
		}
	}
}
