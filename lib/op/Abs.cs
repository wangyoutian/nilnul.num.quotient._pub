using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R=nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational.op
{
	public partial class Abs
		:UnaryI

	{
		static public R Eval(R x) {
			return x.toAbs();
		}
		public Rational_InheritFraction2 eval(Rational_InheritFraction2 arg)
		{
			return Eval(arg);
			throw new NotImplementedException();
		}
	}
}
