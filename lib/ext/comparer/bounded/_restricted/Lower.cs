using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.ext.comparer.bounded._restricted
{
	public partial class Lower
	{
		static public bool IsRestricted(
			ext.Bound x
			
		) {

			return (x.pinpoint is nilnul.order.ext.NegInfI && !x.openFalseCloseTrue)
				||
				(x.pinpoint is nilnul.num.rational.ext.Literal)
			;
		
		}

		public class Be
			:nilnul.bit.Be<Bound>
		{
			public Be()
				:base(IsRestricted)
			{

			}
			
		}

		public class Expr
			:
			nilnul.bit.be.Asserted<Bound,Be>
		{
			public Expr(Bound bound)
				:base(bound)
			{

			}

			static public Expr Add(Expr a,Expr b) {

				return new Expr( ext.bound.op.Add.Eval(a.val, b.val));
			
			}

			static public Expr Add(Bound x_restrictedLower, Bound y_restrictedLower) {

				return Add( 
					new Expr(x_restrictedLower)
					,
					new Expr(y_restrictedLower)  
				);

		
			}




			
		}


	}
}
