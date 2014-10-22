using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.ext.bound.op
{
	public partial class Add
	{
		static public ext.comparer.bounded.restricted.Lower.Expr Eval_lower(

			ext.comparer.bounded.restricted.Lower.Expr a
			,
			ext.comparer.bounded.restricted.Lower.Expr b
			
		) {

			return new ext.comparer.bounded.restricted.Lower.Expr(
				new ext.Bound(
					a.val.openFalseCloseTrue && b.val.openFalseCloseTrue
					,
					ext.op.Add.Eval(a.val.pinpoint,b.val.pinpoint)
				)	
			);
		
		}

		static public ext.Bound Eval(ext.Bound x, ext.Bound y) {
			return new ext.Bound(
				x.openFalseCloseTrue&&y.openFalseCloseTrue
				,
				ext.op.Add.Eval(x.pinpoint,y.pinpoint)
			);
		}


		
	}
}
