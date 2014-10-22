using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.order
{
	public partial class OpenCloseInterval
		:nilnul.order.total.unbound.dense.OpenCloseInterval<Rational_InheritFraction,LessThanOrEqualTo2>
	{

		public OpenCloseInterval(Rational_InheritFraction left, Rational_InheritFraction right)
			:base(left,right)
		{
		}

		public partial class Unit
			: OpenCloseInterval
		{

			public Unit()
				: base(0, 1)
			{

			}
			static public readonly Unit Instance = SingletonByDefaultNew<Unit>.Instance;


		}
		public partial class NonPositive
			: OpenCloseInterval
		{

			public NonPositive()
				: base(null, 0)
			{

			}
			static public readonly NonPositive Instance = SingletonByDefaultNew<NonPositive>.Instance;


		}


					
					
	}
}
