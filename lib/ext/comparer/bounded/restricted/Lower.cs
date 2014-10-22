using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.ext.comparer.bounded.restricted
{
	public partial class Lower
	{
		static public bool Eval(Bound bound) {

			return bound.isNegOpen() || bound.isFinite();
		
		}

		public class Be:
			nilnul.bit.Be<Bound>
		{
			public Be()
				:base(Eval)
			{

			}

		}

		public class Expr
			:nilnul.bit.be.Asserted<Bound,Be>
		{
			public Expr(Bound bound)
				:base(bound)
			{

			}

			
		}
	}
}
