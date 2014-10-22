using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.ext.bound.op
{
	public class Scale
	{

		static public Bound Eval(Rational_InheritFraction2 scale, Bound bound) {

			return new Bound(
				bound.openFalseCloseTrue,
	
				ext.op.Multi.Eval(scale,bound.pinpoint)
			);
		
		}
	}
}
