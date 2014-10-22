using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.interval.rel
{
	public partial class ProperSubset
	{
		static public bool Eval(Interval a, Interval b) {

			return  Subset.Eval(b,a) && Neq.Eval(a,b);
		
		}
	}
}
