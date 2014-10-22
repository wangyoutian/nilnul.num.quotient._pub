using nilnul.order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.ext.op
{
	public partial class Subtract
	{
		static public ExtendedI Eval(ExtendedI x, ExtendedI y) {
			return Add.Eval(x,Negate.Eval(y));
		
		}

		static public ExtendedI Eval(ExtendedI<Rational_InheritFraction2> x, ExtendedI<Rational_InheritFraction2> y) {

			return Eval(
				ExtendedX.Create(x)
				,
				ExtendedX.Create(y)
				);
		
		}
	}
}
