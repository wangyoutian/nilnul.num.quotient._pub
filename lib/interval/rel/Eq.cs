using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.interval.rel
{
	public partial class Eq
	{
		static public bool Eval(Interval a, Interval b) {

			return  Subset.Eval(a,b) && Subset.Eval(a,b);
		
		}
	}
}
