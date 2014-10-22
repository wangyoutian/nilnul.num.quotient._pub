using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational.accuracy
{
	static public   class BoundedX
		
		
	{

		static public FiniteI Create(R lower, bool lowerOpenClose_latterTrue, R upper, bool upperOpenClose_laterTrue) {
			if (lowerOpenClose_latterTrue)
			{
				if (upperOpenClose_laterTrue)
				{
					return new Close2(lower, upper);
					
				}
				return new Clopen(lower, upper);
				
			}
			if (upperOpenClose_laterTrue)
			{
				return new OpenClose(lower, upper);
				
			}
			return new Open2(lower, upper);


			throw new NotImplementedException();
		}
		



	}
}
