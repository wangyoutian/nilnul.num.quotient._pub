using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.ext.comparer.bounded.be
{
	public partial class FiniteNonempty
	{
		static public bool Eval(Bounded x) {

			return FiniteBounds.Eval(x) && NonEmpty.Eval(x);
		
		}

		public class Be:nilnul.bit.Be<Bounded>
		{
			public Be()
				:base(Eval)
			{

			}
			
		}

		public class Expr
			:nilnul.bit.be.Asserted<Bounded,Be>
		{
			public Expr(Bounded x)
				:base(x)
			{

			}


			
		}
	}
}
