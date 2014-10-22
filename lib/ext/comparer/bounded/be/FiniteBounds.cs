using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.ext.comparer.bounded.be
{
	public partial class FiniteBounds
	{
		static public bool Eval(Bounded bounded) {

			return bounded.lower.isNotInf() && bounded.upper.isNotInf();
		
		}




	}
}
