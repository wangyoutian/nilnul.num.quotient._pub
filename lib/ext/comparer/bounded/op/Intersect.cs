using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational.ext.comparer.bounded.op
{
	public partial class Intersect
	{
		static public Bounded Eval(Bounded x, Bounded y) {

			return   new Bounded(  
				nilnul.order.ext.comparer.bounded.op.Intersect<R,rational.Comparer>.Eval(x,y)
			);
			
		
		}
	}
}
