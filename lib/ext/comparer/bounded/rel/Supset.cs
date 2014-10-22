using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.ext.comparer.bounded.rel
{
	public class Supset

	{
		static public bool Eval(
			Bounded x, Bounded y
			
		) {

			return bound.LowerComparer.Leg.Le(x.lower, y.lower) && bound.UpperComparer.Leg.Ge(x.lower, y.lower);
		
		}

	}
}
