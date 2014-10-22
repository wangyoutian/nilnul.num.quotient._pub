using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.bound.pair.be
{
	public partial class OpenSpanned
	{
		static public bool Eval(Pair x) {
			return Open.Eval(x) && Spanned.Eval(x);
		}

		public class Be:
			nilnul.bit.Be<Pair>
		{
			public Be()
				:base(Eval)
			{

			}

		}

		public class Expr
			:nilnul.bit.be.Asserted<Pair,Be>

		{

			public Expr(Pair val)
				:base(val)
			{

			}

			
		}

	}
}
