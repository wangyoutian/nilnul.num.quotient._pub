using nilnul.order.cut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational.cut
{
	public partial class Comparer
		:
		
		IComparer<Cut>
	{

		static public nilnul.order.cut.Comparer<R, rational.Comparer> Singleton = new Comparer<R, rational.Comparer>();



		public int Compare(Cut x, Cut y)
		{
			return Singleton.Compare(x as Cut<R>, y as Cut<R>);

			throw new NotImplementedException();
		}
	}
}
