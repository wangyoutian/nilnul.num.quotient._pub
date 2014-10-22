using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational
{
	public class ClosedInterval
		:nilnul.interval.ClosedInterval<Rational_InheritFraction>
	{

		public ClosedInterval(Rational_InheritFraction a,Rational_InheritFraction b)
			:base(a,b)
		{
		}
					
	}
}
