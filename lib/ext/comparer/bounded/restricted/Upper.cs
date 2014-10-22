using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.ext.comparer.bounded.restricted
{
	public partial class Upper
	{
		static public bool Eval(Bound bound) {

			return bound.isPosOpen() || bound.isFinite();
		
		}

		public class Be:
			nilnul.bit.Be<Bound>
		{
			public Be()
				:base(Eval)
			{

			}

		}

		public class Asserted:
			nilnul.bit.be.Asserted<Bound ,Be>
		{
			public Asserted(Bound bound)
				:base(bound)
			{

			}
			
		}


	}
}
