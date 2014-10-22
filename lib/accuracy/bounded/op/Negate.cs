using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.accuracy.bounded.op
{
	public partial class Negate
	{
		static public FiniteI Eval(FiniteI a) {

			if (a is OpenLeftI)
			{
				if (a is OpenRightI)
				{
					return new Open2(-a.upperBound, -a.lowerBound);
					
				}

				return new Clopen(-a.upperBound, -a.lowerBound);
				
			}
			if (a is CloseRightI)
			{
				return new Close2(-a.upperBound, -a.lowerBound);
				
			}
			if (a is OpenRightI)
			{
				return new OpenClose(-a.upperBound, -a.lowerBound);
				
			}



			throw new NotFiniteNumberException();
		}
	}
}
