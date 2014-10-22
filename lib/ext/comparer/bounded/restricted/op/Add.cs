using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.ext.comparer.bounded.restricted.op
{
	public partial class Add
	{
		static public Restricted.Expr Eval(Restricted.Expr x,Restricted.Expr y) {
			return new Restricted.Expr(

				ext.bound.op.Add.Eval(x.val.lower,y.val.lower)
				,
				ext.bound.op.Add.Eval(y.val.upper,y.val.upper)
					
			);
		}
	}
}
