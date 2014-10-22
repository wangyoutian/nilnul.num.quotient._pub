using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using R=nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational.accuracy.bounded.op
{
	public partial class Multi
	{
		static public FiniteI Eval(FiniteI a, FiniteI b)
		{
			#region Init Var
			var aLowerBUpper = a.lowerBound * b.upperBound;
			var aUpperBLower = a.upperBound * b.lowerBound;

			var aUpperBUpper = a.upperBound * b.upperBound;
			var aLowerBLower = a.lowerBound * b.lowerBound;

			//		var lower=nilnul.num.rational.op.MinX.Do(a.lowerBound * b.upperBound, a.upperBound * b.lowerBound);
			var lower = nilnul.num.rational.op.MinX.Do(aLowerBUpper, aUpperBLower);
			//			var upper = nilnul.num.rational.op.MaxX.Do(a.lowerBound * b.lowerBound, a.upperBound * b.upperBound);

			var upper = nilnul.num.rational.op.MaxX.Do(aLowerBLower, aUpperBUpper);


			#endregion

			bool leftOpenClose;	// = false;
			bool rightOpenClose;	// = false;

			#region determine OpenClose


			_DetermineLowerOpenClose(ref lower, ref a, ref b, ref aLowerBUpper, ref aUpperBLower, out leftOpenClose);

			_DetermineUpperOpenClose(ref upper, ref a, ref b, ref aLowerBLower, ref aUpperBUpper, out rightOpenClose);

		

			#endregion

			#region CreateAccuracy

			if (leftOpenClose)
			{
				if (rightOpenClose)
				{
					return new Close2(lower, upper);

				}
				return new Clopen(lower, upper);

			}
			if (rightOpenClose)
			{
				return new OpenClose(lower, upper);

			}
			return new Open2(lower, upper);

			#endregion





			throw new NotFiniteNumberException();
		}

		static private void _DetermineUpperOpenClose(
			ref R upper
			,

			ref FiniteI a
			,
			ref FiniteI b
			,
			ref R aLowerBLower
			,
			ref R aUpperBUpper
			,
			out bool rightOpenClose
			
			
		) {

			if (upper==0)
			{
				rightOpenClose = true;
				
			}
			_DetermineUpperOpenCloseIfNotZero(ref upper,ref a,ref b,ref aLowerBLower,ref aUpperBUpper,out rightOpenClose);
		
		
		}

		static private void _DetermineUpperOpenCloseIfNotZero(
			ref R upper
			,

			ref FiniteI a
			,
			ref FiniteI b
			,
			ref R aLowerBLower
			,
			ref R aUpperBUpper
			,
			out bool rightOpenClose


		)
		{
			rightOpenClose = false;

			if (upper == aLowerBLower)
			{
				if (upper != aUpperBUpper)
				{
					if (a is CloseLeftI && b is CloseLeftI)
					{
						rightOpenClose = true;
					}
				}
				else
				{
					if (a is CloseLeftI && b is CloseLeftI || a is CloseRightI && b is CloseRightI)
					{
						rightOpenClose = true;
					}
				}

			}
			else
			{	//upper ==aUpperBUpper

				if (a is CloseRightI && b is CloseRightI)
				{
					rightOpenClose = true;
				}
			}
		//	return rightOpenClose;
		}
		static private void _DetermineLowerOpenClose(
			ref R lower
			,
			ref FiniteI a
			,
			ref FiniteI b
			,
			ref R aLowerBUpper
			,
			ref R aUpperBLower
			,
			out bool leftOpenClose
		)
		{
			if (lower==0)
			{
				leftOpenClose = true;
				
			}
			_DetermineLowerOpenCloseIfNotZero(ref lower, ref a, ref b, ref aLowerBUpper, ref aUpperBLower, out leftOpenClose);
			
		}
		static private void _DetermineLowerOpenCloseIfNotZero(
			ref R lower
			,
			ref FiniteI a
			,
			ref FiniteI b
			,
			ref R aLowerBUpper
			,
			ref R aUpperBLower
			,
			out bool leftOpenClose
		)
		{
			leftOpenClose = false;

			if (lower == aLowerBUpper)
			{
				if (lower != aUpperBLower)
				{
					if (a is CloseLeftI && b is CloseRightI)
					{
						leftOpenClose = true;
					}
				}
				else
				{
					if (a is CloseLeftI && b is CloseRightI|| a is CloseRightI && b is CloseLeftI)
					{
						leftOpenClose = true;
					}
				}

			}
			else
			{	//upper ==aUpperBLower

				if (a is CloseRightI && b is CloseLeftI)
				{
					leftOpenClose = true;
				}
			}
			//return leftOpenClose;
		}
	}
}
