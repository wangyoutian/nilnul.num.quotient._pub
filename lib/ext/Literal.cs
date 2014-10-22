using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational.ext
{
	public partial class Literal
		:
		
		nilnul.order.ext.Literal<R>
		,
		ExtendedI
		,
		nilnul.order.ext.LiteralI

	{

		public Literal(R r)
			:base(r)
		{

		}

		static public Literal CreateZero() {
			return new Literal(0);
		}
	}
}
