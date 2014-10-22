using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.be
{
	public partial class Tail
	{
		static public bool Eval(Rational_InheritFraction2 x) {
			return x >= 0 && x < 1;
		}

		public class Be:nilnul.bit.Be<Rational_InheritFraction2>
			
		{
			public Be()
				:base(Eval)
			{

			}
		}
		public class Asserted
			:
			nilnul.bit.be.Asserted<Rational_InheritFraction2,Be>
		{
			public Asserted(Rational_InheritFraction2 r)
				:base(r)
			{

			}
		}
	}
}
