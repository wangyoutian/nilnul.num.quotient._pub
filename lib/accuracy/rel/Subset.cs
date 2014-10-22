using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.accuracy.rel
{
	public partial class Subset
	{
		static public bool Eval(Accuracy2 x, Accuracy2 y) {
			return ext.comparer.bounded.rel.Subset.Eval(
				x.val.val
				,
				y.val.val	
			);
		}
	}
}
