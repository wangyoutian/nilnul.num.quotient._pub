using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational
{
	public partial class Comparer
		: IComparer<R>
	{
		static public Comparer Singleton = SingletonByDefault<Comparer>.Instance;

		static public int Eval(R x, R y

			) {
				return (int)(x - y).sign;
		}
		public int Compare(R x, R y)
		{
			return (int)(x - y).sign;

			throw new NotImplementedException();
		}
		public partial class Leg
			: nilnul.order.compare.Leg_froSysComparer<R, Comparer>
		{

		}
	}

}
