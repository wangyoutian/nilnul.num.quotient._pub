using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.interval.op
{
	public partial class Add
	{
		static public rational.Interval2 Eval(
			Interval2 x
			,
			Interval2 y
			
		) {

			return new Interval2(
				nilnul.num.rational.ext.comparer.bounded._restricted.Lower.Expr.Add(x.val.lower,y.val.lower).val
				,
				nilnul.num.rational.ext.comparer.bounded._restricted.Upper.Expr.Add(x.val.lower,y.val.lower).val

			);

			throw new NotImplementedException();
		
		}
	}
}
