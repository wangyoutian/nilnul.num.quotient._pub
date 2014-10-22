using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.bound.pair.be
{
	public partial class Singleton
	{
		static public bool Eval(Pair x) {

			return Close.Eval(x) && x.lower.pinpoint == x.upper.pinpoint;
		
		}
	}
}
