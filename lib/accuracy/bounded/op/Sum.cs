using nilnul.num.rational.accuracy.bounded;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.accuracy.bounded.op
{
	public partial class Sum
	{
		static public FiniteI Eval(IEnumerable<FiniteI> a_nonEmpty)
		{
			var r = a_nonEmpty.First();

			for (int i = 1; i < a_nonEmpty.Count(); i++)
			{
				r = Add.Eval(r, a_nonEmpty.ElementAt(i));
			}
			return r;


			throw new NotImplementedException();
		}

		static public FiniteI Eval(params FiniteI[] a_nonEmpty)
		{
			return Eval(a_nonEmpty.AsEnumerable());


			throw new NotImplementedException();
		}

	


	}
}
