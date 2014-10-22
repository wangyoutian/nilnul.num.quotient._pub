using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.interval.be
{
	public partial class Accuracy
	{
		static public bool Eval(Interval2 x) {
			return x.contains(0);
		}

		public class Be:
			nilnul.bit.Be<Interval2> 
		{
			public Be()
				:base(Eval)
			{

			}



		}

		public class Expr
			:nilnul.bit.be.Asserted<Interval2,Be>
		{
			public Expr(Interval2 interval)
				:base(interval)
			{

			}
		}

		


	}
}
