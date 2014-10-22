using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.interval.rel
{
	public partial class Supset
	{
		static public bool Eval(Interval a, Interval b) {

			return nilnul.order.cut.interval.rel.Supset.Eval(a, b,Comparer.Singleton);
		
		}
	}
}
