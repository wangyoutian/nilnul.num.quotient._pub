using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.bound
{
	public partial class Pair
		:nilnul.order.comparer.Bounded_ComparerSingle<Rational_InheritFraction2,Comparer,Bound>
	{
		public Pair(bool leftOpenFalseCloseTrue, Rational_InheritFraction2 lower, bool upperClose, Rational_InheritFraction2 upper)
			:base(
			new Bound(
			leftOpenFalseCloseTrue,lower), new Bound( upperClose,upper)
			
			)
		{


		}

		public Pair(Bound lower, Bound upper)
			:base(lower,upper)
		{

		}



		



	}
}
