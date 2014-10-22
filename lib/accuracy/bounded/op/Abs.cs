using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.accuracy.bounded.op
{
	public partial class Abs
	{
		static public FiniteI Eval(FiniteI a) {

			var lowerAbs = a.lowerBound.toAbs();
			if (lowerAbs>a.upperBound)
			{
				if (a is OpenLeftI)
				{
					return new Clopen(0, lowerAbs);
					
				}
				return new Close2(0, lowerAbs);
				
			}
			if (lowerAbs==a.upperBound)
			{
				if (a is CloseLeftI || a is CloseRightI )
				{
					return new Close2(0, lowerAbs);

					
				}
				return new Clopen(0, lowerAbs);
				
			}
			if (a is CloseRightI)
			{
				return new Close2(0, a.upperBound);
				
			}
			return new Clopen(0, a.upperBound);


			throw new NotFiniteNumberException();
		}


		
	}
}
