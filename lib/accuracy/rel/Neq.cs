using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.accuracy.rel
{
	public partial class Neq
	{
		static public bool Eval(Accuracy2 a, Accuracy2 b) {
			return !Eq.Eval(a,b);
		}
	}
}
