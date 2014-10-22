using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.ext.op
{
	public partial class Abs
	{
		static public ExtendedI Eval(ExtendedI x) {
			if (x is NegInf)
			{
				return new PosInf();
				
			}
			if (x is PosInf)
			{
				return new NegInf();
			}
			return new ext.Literal( (x as  ext.Literal).val.toAbs());
		}

		static public ExtendedI Eval(nilnul.order.ExtendedI<Rational_InheritFraction2> x) {
			return Eval( (ExtendedI)(x) );
		}

	}
}
