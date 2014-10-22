using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.bound.comparers
{
	public partial class Upper
	{
		static public int Eval(Bound x, Bound y)
		{

			if (x.pinpoint < y.pinpoint)
			{
				return -1;

			}

			if (x.pinpoint > y.pinpoint)
			{
				return 1;
			}

			return _Eval_ifPinpointEq(x, y);

		}

		static public int _Eval_ifPinpointEq(Bound x, Bound y) {
			if (x.openFalseCloseTrue==y.openFalseCloseTrue)
			{
				return 0;
				
			}
			return x.openFalseCloseTrue ? 1 : -1;

		}

		static public Bound Max(Bound x, Bound y)
		{
			return Eval(x, y) >= 0 ? x : y;
		}

		static public Bound Max(IEnumerable<Bound> bounds_nonEmpty) {
			if (bounds_nonEmpty.Count()==1)
			{
				return bounds_nonEmpty.First();
			}
			return Max(bounds_nonEmpty.First(),Max(bounds_nonEmpty.Skip(1)));



		}

		static public Bound Max(params Bound[] bounds)
		{
			return Max(bounds as IEnumerable<Bound>);
		}




	}
}
