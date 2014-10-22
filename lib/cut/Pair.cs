using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R=nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational.cut
{
	public partial class Pair
		:nilnul.order.cut.Pair<R,rational.Cut>
	{
		public Pair(rational.Cut lower, rational.Cut upper)
			:base(lower ,upper)
		{

		}
	}
}
