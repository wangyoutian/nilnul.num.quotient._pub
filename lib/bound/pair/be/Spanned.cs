using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.bound.pair.be
{
	public partial class Spanned
	{
		static public bool Eval(Pair x) {
			return x.lower.pinpoint < x.upper.pinpoint;
		}


	}
}
