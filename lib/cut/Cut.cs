using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R=nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational.cut
{
	public partial class Cut:nilnul.order.cut.Cut<Rational_InheritFraction2>
	{
		public Cut(bool openFalseCloseTrue, R pinpoint)
			:base(openFalseCloseTrue,pinpoint)
		{

		}

		static public Cut CreateZeroClose() {
			return new Cut(true, 0);
		}

		
	}
}
