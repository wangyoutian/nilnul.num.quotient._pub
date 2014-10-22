using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.interval.rel
{
	public partial class Subset
	{
		static public bool Eval(Interval a, Interval b) {

			return  Supset.Eval(b,a);
		
		}
	}
}
