using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational.ext.op
{
	public partial class Max
	{
		static public ExtendedI Eval(ExtendedI a, ExtendedI b) {

			return ExtendedX.Create(  nilnul.order.ext.op.Max_ComparerSingle<R, rational.Comparer>.Eval(a, b));
		}
	}
}
