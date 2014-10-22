using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.order
{
	public partial class OpenInterval
		: nilnul.order.total.unbound.dense.OpenInterval<Rational_InheritFraction, LessThanOrEqualTo2>
	{

		public OpenInterval(Rational_InheritFraction left, Rational_InheritFraction right)
			: base(left, right)
		{
		}

		public partial class Unit
	: OpenInterval
		{

			public Unit()
				: base(0, 1)
			{

			}
			static public readonly Unit Instance = SingletonByDefaultNew<Unit>.Instance;


		}

		public partial class All
			:OpenInterval
		{

			public All()
				:base(null,null)
			{
			}
				static public readonly All Instance = SingletonByDefaultNew<All>.Instance;
				
			
		}

		public partial class Positive
	: OpenInterval
		{

			public Positive()
				: base(0, null)
			{
			}
			static public readonly Positive Instance = SingletonByDefaultNew<Positive>.Instance;


		}
		public partial class Negative
	: OpenInterval
		{

			public Negative()
				: base(null, 0)
			{
			}
			static public readonly Negative Instance = SingletonByDefaultNew<Negative>.Instance;


		}




	}
}
