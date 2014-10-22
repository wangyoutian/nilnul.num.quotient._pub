using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.rational
{
	public partial class Negate
	{

		
	}



	static public partial class NegateX
	{
		static public RationalI Negate(this RationalI x)
		{
			return Divide.Eval(-x.Numerator(), x.Denominator());


		}
		static public Rational_InheritFraction2 Negate(this Rational_InheritFraction2 x)
		{
			return x.toNegate();


		}


	}
}
