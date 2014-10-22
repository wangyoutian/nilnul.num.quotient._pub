using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.ext.bound
{
	public partial class UpperComparer
		:
		nilnul.order.ext.bound.UpperComparer_ComparerSingle<Rational_InheritFraction2,rational.Comparer,Bound>
	{

		public class Leg
	: nilnul.order.comparer.Leg_froSysComparer<Bound, UpperComparer>
		{



		}

		
	}
}
