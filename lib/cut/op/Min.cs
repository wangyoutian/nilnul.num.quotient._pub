using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.cut.op
{
	public partial class Min
	{
		static public Cut Eval(Cut a, Cut b) {

			return LowerBoundComparer.Singleton.Compare(a, b) <= 0 ? a : b;
		
		}
	}
}
