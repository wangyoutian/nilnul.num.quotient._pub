using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.ext.bound
{
	public partial class LowerComparer
		:
		nilnul.order.ext.bound.LowerComparer_ComparerSingle<Rational_InheritFraction2,rational.Comparer,Bound>

	{

		static public Bound Min(Bound x,Bound y) {

			return  Singleton.Compare(x, y) <= 0 ? x : y;
		
		}

		public class Leg
			:nilnul.order.comparer.Leg_froSysComparer<Bound,LowerComparer>
		{

			

		}
		
	}
}
