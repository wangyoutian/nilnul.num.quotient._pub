using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.collection
{
	public partial class Interval
		: nilnul.interval.Interval<Rational_InheritFraction, order.LessThanOrEqualTo2>
	{

		public Interval()
			: base(null, null)
		{



		}

		public Interval(Cut left,Cut right)
			:base(left,right)
		{



		}

		

		
					
	}
}
