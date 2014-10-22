using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.ext.comparer.bounded.rel
{
	public class ProperSupset

	{
		static public bool Eval(
			Bounded x, Bounded y
			
		) {

			return Supset.Eval(x,y) && Neq.Eval(x,y) ;
		
		}

	}
}
