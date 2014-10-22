using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.interval.op
{
	public partial class Negate
	{
		static public Interval2 Eval(Interval2 x) {
			return new Interval2(
				ext.bound.op.Negate.Eval(x.val.upper)
				,
				ext.bound.op.Negate.Eval(x.val.lower)
				
			);
		}
	}
}
