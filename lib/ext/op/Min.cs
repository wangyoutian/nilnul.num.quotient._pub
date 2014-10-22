using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational.ext.op
{
	public partial class Min
	{
		static public ExtendedI Eval(ExtendedI a, ExtendedI b)
		{

			return ExtendedX.Create(nilnul.order.ext.op.Min_ComparerSingle<R, rational.Comparer>.Eval(a, b));
		}
		static public ExtendedI Eval(nilnul.order.ExtendedI<R> a, nilnul.order.ExtendedI<R> b)
		{

			return ExtendedX.Create(nilnul.order.ext.op.Min_ComparerSingle<R, rational.Comparer>.Eval(a, b));
		}
	}
}
