using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.interval.op
{
	public partial class Intersect
	{
		static public Interval2 Eval(
			Interval2 x
			,
			Interval2 y
			
		) {

			return new Interval2(

				 nilnul.order.ext.comparer.bounded.op.Intersect<Rational_InheritFraction2,rational.Comparer>.Eval<ext.Bound>(
					x.val
					,
					y.val
				)


				
			);


			throw new NotImplementedException();
		}
	}
}
