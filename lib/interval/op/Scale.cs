using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.interval.op
{
	public partial class Scale
	{
		static public Interval2 Eval(Rational_InheritFraction2 scale, Interval2 interval) {

			//if (scale==0)
			//{
			//	return Interval2.CreateZero();
				
			//}

			var bound1 = ext.bound.op.Scale.Eval(scale, interval.val.lower);

			var bound2 = ext.bound.op.Scale.Eval(scale, interval.val.upper);

			var t = ext.Comparer.Singleton.Compare(bound1.pinpoint, bound2.pinpoint);

			if (t==0)
			{
				return Interval2.CreateSingleton(bound1.pinpoint);
				
			}
			if (t<0)
			{
				return new Interval2(
					bound1,bound2	
				);
			}
			return new Interval2(bound2, bound1);
		
		}
	}
}
