using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.bound.pair.be.nonempty.op
{
	public partial class Abs
	{
		static public Nonempty.Asserted Eval(Nonempty.Asserted x) {
			return Nonempty.Asserted.Abs(x);
		
		}
	}
}
