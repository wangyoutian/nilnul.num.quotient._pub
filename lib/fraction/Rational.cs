using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.rational.fraction
{
	public partial class Rational
		:num.rational.Fraction140728
		{
			public Rational(BigInteger x, BigInteger y)
				:base(x,y)
			{
				simplify();
			}

			public Rational(Fraction140728 f)
				:base(f.numerator,f.denominator)
			{
				simplify();

			}

			static public Rational Divide(BigInteger x, BigInteger y) {

				var r= Fraction140728.Divide(x, y);


				return new Rational(r);
			
			}
			
			
		
	}
}
