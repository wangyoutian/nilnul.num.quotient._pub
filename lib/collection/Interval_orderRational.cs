using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.collection
{
	public partial class Interval_orderRational
		:
		nilnul.interval.Interval<Rational_InheritFraction, order.LessThanOrEqualTo2>
		
	{

		public Interval_orderRational()
			: base(null, null)
		{



		}

		public Interval_orderRational(Cut left,Cut right)
			:base(left,right)
		{


		}

		

		
					
	}
}
