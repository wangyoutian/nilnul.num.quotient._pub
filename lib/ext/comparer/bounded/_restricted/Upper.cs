using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.ext.comparer.bounded._restricted
{
	public partial class Upper
	{
		static public bool IsRestricted(
			ext.Bound x
			
		) {

			return (x.pinpoint is nilnul.order.ext.PosInfI && !x.openFalseCloseTrue)
				||
				(x.pinpoint is nilnul.num.rational.ext.Literal)
			;
		
		}

		public class Be:
			nilnul.bit.Be<ext.Bound>
		{

			public Be()
				:base(IsRestricted)
			{

			}
		}

		public class Expr
			:nilnul.bit.be.Asserted<ext.Bound,Be>
		{
			public Expr(ext.Bound bound)
				:base(bound)
			{

			}

			static public Expr Add(Expr a, Expr b)
			{

				return new Expr(ext.bound.op.Add.Eval(a.val, b.val));

			}

			static public Expr Add(Bound x_restrictedUpper, Bound y_restrictedUpper)
			{

				return Add(
					new Expr(x_restrictedUpper)
					,
					new Expr(y_restrictedUpper)
				);


			}



			
		}
	}
}
