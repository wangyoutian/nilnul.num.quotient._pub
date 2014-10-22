using nilnul.num.natural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational.neighbor
{
	public partial class Open2
		: 
		FiniteA
		
	{
		

		



		public Open2(R lowerBound, R upperOpenBound)
		{
			this.upperBound=upperBound;
			this.lowerBound=( lowerBound);

		}

		static public Open2 CreateSymmetric(be.Positive.Asserted radius)
		{

			if (radius.val < 0)
			{
				return new Open2(radius.val, -radius.val);

			}
			return new Open2(-radius.val, radius.val);

		}
		static public Open2 CreateSymmetric(R radius_positive)
		{

			if (radius_positive < 0)
			{
				return new Open2(radius_positive, -radius_positive);

			}
			return new Open2(-radius_positive, radius_positive);

		}

		public override bool contains(R n)
		{
			return n > lowerBound && n < upperBound;
		}







	
	}
}
