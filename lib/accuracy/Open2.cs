using nilnul.num.natural;
using nilnul.num.rational.accuracy.bounded;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational.accuracy
{
	public partial class Open2
		: 
		FiniteA
		,OpenLeftI
		,OpenRightI
		
	{
		

		



		public Open2(R lowerBound, R upperBound)
		{
			this.upperBound=upperBound;
			this.lowerBound=( lowerBound);

			if (lowerBound==upperBound)
			{
				throw new Exception();
				
			}

		}

		static public Open2 CreateSymmetric(rational.be.Positive.Asserted radius)
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
