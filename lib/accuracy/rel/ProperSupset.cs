using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.accuracy.rel
{
	public partial class ProperSupset
	{
		static public bool Eval(Accuracy2 x, Accuracy2 y) {
			return ProperSubset.Eval(y, x);
		}

	
	}
}
