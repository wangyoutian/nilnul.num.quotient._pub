using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.ext.bound.op
{
	public partial class Abs
	{

		static public Bound Eval(Bound x) {
			return new Bound(x.openFalseCloseTrue, ext.op.Abs.Eval(x.pinpoint));
		}
		
	}
}
