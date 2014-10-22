using nilnul.order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.ext.op
{
	public partial class Negate
	{
		static public ExtendedI Eval(ExtendedI<Rational_InheritFraction2> x) {

			if (x is nilnul.order.ext.NegInfI)
			{
				return NegInf.Singleton;
				
			}
			if (x is nilnul.order.ext.PosInfI)
			{
				return PosInf.Singleton;
				
			}
			return ExtendedX.Create(

					(x as nilnul.order.ext.Literal<Rational_InheritFraction2>).val.toNegate()
				
				
			);
		}
	}
}
