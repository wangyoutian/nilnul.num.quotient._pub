using nilnul.order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.ext.be
{
	public partial class Literal
	{
		static public bool Eval(ExtendedI<Rational_InheritFraction2> x) {
			return x is nilnul.order.ext.Literal<Rational_InheritFraction2>;
		}

		static public bool Eval(ExtendedI x) {
			return x is ext.Literal;
		}
	}
}
