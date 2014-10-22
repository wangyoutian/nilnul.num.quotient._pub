using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.order
{
	public partial class Interval
		:nilnul.order.total.unbound.dense.Interval<Rational_InheritFraction,LessThanOrEqualTo2>
	{

		public Interval(nilnul.order.interval.Cut2<Rational_InheritFraction> left, nilnul.order.interval.Cut2<Rational_InheritFraction> right)
			:base(left,right)
		{
		}

		public Interval(Rational_InheritFraction left,bool leftEq,Rational_InheritFraction right, bool rightEq)
			:this(new nilnul.order.interval.Cut2<Rational_InheritFraction>(left,leftEq),new nilnul.order.interval.Cut2<Rational_InheritFraction>(right,rightEq))
		{
		}

		public partial class Cut
			:nilnul.order.interval.Cut2<Rational_InheritFraction>
		{

			public Cut(Rational_InheritFraction pinpoint, bool eq)
				:base(pinpoint,eq)
			{
			}
					

		}

		public partial class ClosedCut
			: nilnul.order.interval.ClosedCut<Rational_InheritFraction>
		{

			public ClosedCut(Rational_InheritFraction pinpoint)
				: base(pinpoint)
			{
			}


		}
		public partial class OpenCut
			: nilnul.order.interval.ClosedCut<Rational_InheritFraction>
		{

			public OpenCut(Rational_InheritFraction pinpoint)
				: base(pinpoint)
			{
			}


		}

	
					
					
	}
}
