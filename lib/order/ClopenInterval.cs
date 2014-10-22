using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.order
{
	public partial class ClopenInterval
		:nilnul.order.total.unbound.dense.ClosedInterval<Rational_InheritFraction,LessThanOrEqualTo2>
	{

		public ClopenInterval(Rational_InheritFraction left, Rational_InheritFraction right)
			:base(left,right)
		{
		}

		public partial class Unit
			: ClopenInterval
		{

			public Unit()
				: base(0, 1)
			{

			}
			static public readonly Unit Instance = SingletonByDefaultNew<Unit>.Instance;


		}
		public partial class NonNeg
			: ClopenInterval
		{

			public NonNeg()
				: base(0, null)
			{

			}
			static public readonly NonNeg Instance = SingletonByDefaultNew<NonNeg>.Instance;


		}


					
					
	}
}
