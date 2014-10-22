using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.accuracy.rel
{
	public partial class Eq
	{
		static public bool Eval(Accuracy2 a, Accuracy2 b) {
			return Subset.Eval(a, b) && Supset.Eval(a, b);
		}
	}
}
