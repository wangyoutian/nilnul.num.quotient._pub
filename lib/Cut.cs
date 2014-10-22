using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R=nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational
{
	public partial class Cut:nilnul.order.Bound<Rational_InheritFraction2>
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
