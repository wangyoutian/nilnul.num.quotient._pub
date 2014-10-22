using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.accuracy.op
{
	public partial class Intersect
	{
		static public Accuracy2 Eval(Accuracy2 x, Accuracy2 y) {
			return new Accuracy2(
				
				nilnul.num.rational.ext.comparer.bounded.op.Intersect.Eval(x.val.val, y.val.val)
				
			);
		
		}
	}
}
