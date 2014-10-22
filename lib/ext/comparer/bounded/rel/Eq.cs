using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.ext.comparer.bounded.rel
{
	public class Eq

	{
		static public bool Eval(
			Bounded x, Bounded y
			
		) {

			return Supset.Eval( x,y) && Subset.Eval(x,y);
		
		}

	}
}
