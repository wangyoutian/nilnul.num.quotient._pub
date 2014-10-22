using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.ext.comparer.bounded.restricted.be
{
	public partial class Bounded
	{
		static public bool Eval(Restricted.Expr interval) {

			return ext.be.Literal.Eval(interval.val.lower.pinpoint) && ext.be.Literal.Eval(interval.val.upper.pinpoint);
		
		}
	}
}
