using nilnul.num.rational.float_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.rational.float_.based
{
	public partial class Dec
		:Based<natural.be.plural.bigint.asserted.Ten>
	{

		public Dec(BigInteger significand, BigInteger index)
			:base(significand,index)
		{

		}

		static public Dec FroRational(Rational_InheritFraction2 rational,BigInteger digits) {
			Based2 based = FroRational(10, rational, digits);

			return new Dec(based.significand, based.index);

		}
					
		
	}
}
