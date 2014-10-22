using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational.accuracy.bounded.op
{
	public partial class Union
	{
		static public FiniteI Eval(FiniteI a,FiniteI b) {

			R lower;
			R upper;
			bool leftOpenClose_latterTrue = false; ;
			bool rightOpenClose_latterTrue = false;

			if (a.lowerBound<b.lowerBound)
			{
				lower = a.lowerBound;
				if (a is OpenLeftI)
				{
					leftOpenClose_latterTrue = false;
					
				}
				else
				{
					leftOpenClose_latterTrue = true;
				}
				
			}else

			if (a.lowerBound==b.lowerBound)
			{
				lower = a.lowerBound;
				if (a is CloseLeftI || b is CloseLeftI)
				{
					leftOpenClose_latterTrue = true;
					
				}

			}
			else
			{
				lower = b.lowerBound;
				if (b is CloseLeftI)
				{
					leftOpenClose_latterTrue = true;
					
				}
			}

			if (a.upperBound>b.upperBound)
			{
				upper = a.upperBound;
				if (a is CloseRightI)
				{
					rightOpenClose_latterTrue = true;

				}

			}
			else if (a.upperBound==b.upperBound)
			{
				upper = a.upperBound;
				if (a is CloseRightI || b is CloseRightI)
				{
					rightOpenClose_latterTrue = true;
					
				}

				
			}else
			{
				upper = b.upperBound;
				if (b is CloseRightI)
				{
					rightOpenClose_latterTrue = true;
					
				}

			}

			return BoundedX.Create(lower, leftOpenClose_latterTrue, upper, rightOpenClose_latterTrue);


			


			throw new NotFiniteNumberException();
		}
	}
}
