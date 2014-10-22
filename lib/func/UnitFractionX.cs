using nilnul.num.natural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.rational.func
{
	public partial class UnitFractionX
	{

		
	}

	public partial class UnitFraction
		:Rational_InheritFraction
	{

		public UnitFraction(PositiveNatural_inheritNatural2 n)
			:base(1,n)
		{
		}

		public UnitFraction(BigInteger _natural)
			:this(new PositiveNatural_inheritNatural2(_natural))
		{
		}
					
					
		
	}
}
