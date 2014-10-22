using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.ext.comparer.bounded.rel
{
	public class Neq

	{
		static public bool Eval(
			Bounded x, Bounded y
			
		) {

			return ! Eq.Eval( x,y) ;
		
		}

	}
}
