using nilnul.order.cut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational.cut
{
	public partial class LowerBoundComparer
		:
		nilnul.order.cut.LowerBoundComparer<R,rational.Comparer,Cut>
	{
		static public LowerBoundComparer Singleton = SingletonByDefault<LowerBoundComparer>.Instance;



	
	}
}
