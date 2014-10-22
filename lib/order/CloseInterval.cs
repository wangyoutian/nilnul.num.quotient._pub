using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.order
{
	public partial class CloseInterval
		:nilnul.order.total.unbound.dense.ClosedInterval<Rational_InheritFraction,LessThanOrEqualTo2>
	{

		public CloseInterval(Rational_InheritFraction left, Rational_InheritFraction right)
			:base(left,right)
		{
		}

		public partial class Unit
			:CloseInterval
		{

			public Unit()
				:base(0,1)
			{

			}
			static public readonly Unit Instance = SingletonByDefaultNew<Unit>.Instance;
				

		}


					
					
	}
}
