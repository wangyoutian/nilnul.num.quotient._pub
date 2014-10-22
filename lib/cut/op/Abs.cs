using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.cut.op
{
	public partial class Abs
	{

		public static Cut Eval(Cut x) {
			if (x==null)
			{
				return null;
				
			}
			return new Cut(x.openFalseCloseTrue, x.pinpoint.toAbs());
		
		}
	}
}
