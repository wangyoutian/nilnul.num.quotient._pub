using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.rational
{
	static public partial  class PowX
	{
		static public RationalI Pow(this BigInteger @base, BigInteger exp)
		{
			if (exp>=0)
			{
				return nilnul.num.integer.PowX.Pow(@base, exp).ToRational();
				
			}
			else
			{
				return DivideX.Divide(1, nilnul.num.integer.PowX.Pow(@base, exp));
			}
		}

		static public RationalI Pow(this StandardFraction @base, BigInteger exp)
		{

			return Pow(@base.numerator, exp).Divide(Pow(@base.denominatro, exp));
		}
		static public RationalI Pow(this Rational @base, BigInteger exp)
		{

			return Pow(@base.numerator, exp).Divide(Pow(@base.denominatro, exp));
		}

		

		



	

	}

	

	
}
