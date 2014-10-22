using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using R=nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational.accuracy.bounded.op
{
	public partial class Scale
	{
		static public FiniteI Eval(R scale, FiniteI a)
		{
			if (scale==0)
			{
				return new Close2(0, 0);
				
			}

			if (a is OpenLeftI && a is OpenRightI)
			{
				return new Open2(a.lowerBound, a.upperBound);
				
			}

			if (a is OpenLeftI)
			{
				if (a is CloseRightI)
				{
					return new OpenClose(a.lowerBound, a.upperBound);
					
				}
				
			}

			if (a is CloseLeftI)
			{
				if (a is OpenRightI)
				{
					return new Clopen(a.lowerBound, a.upperBound);
					
				}
				return new Close2(a.lowerBound, a.upperBound);
				
			}


			throw new NotFiniteNumberException();
		}

		static public FiniteI Eval(FiniteI a, R scale) {
			return Eval(scale, a);
		}

	

		
	}
}
