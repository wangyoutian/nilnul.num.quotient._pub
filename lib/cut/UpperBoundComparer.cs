using nilnul.order.cut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational.cut
{
	public partial class UpperBoundComparer
		:
		nilnul.order.cut.UpperBoundComparer<R,rational.Comparer,Cut>
	{

		static public nilnul.order.cut.UpperBoundComparer<R, rational.Comparer> Comparer = new UpperBoundComparer<R,rational.Comparer>();



		public int Compare(Cut x, Cut y)
		{
			return Comparer.Compare(x as Cut<R>, y as Cut<R>);

			throw new NotImplementedException();
		}
	}
}
