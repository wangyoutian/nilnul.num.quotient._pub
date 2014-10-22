using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R=nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational.cut.op
{
	public partial class Scale
	{
		static public Cut Eval(R scale, Cut cut) {


			return cut==null? null:new Cut(cut.openFalseCloseTrue, scale * cut.pinpoint);
		
		}

	}
}
