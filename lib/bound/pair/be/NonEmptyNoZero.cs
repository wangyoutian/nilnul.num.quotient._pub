using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.bound.pair.be
{
	public partial class NonEmptyNoZero
	{
		static public bool Eval(
			bound.Pair x
				
		) {

			return Nonempty.Eval(x) && (!x.contains(0));
		
		}

		public class Be:
			nilnul.bit.Be<bound.Pair>
		{

			public Be()
				:base(Eval)
			{

			}
		}

		public class Asserted
			:nilnul.bit.be.Asserted<bound.Pair,Be>
		{
			public Asserted(bound.Pair x)
				:base(x)
			{

			}

			static public Asserted Inverse(Asserted x) {

				return new Asserted(
					new Pair(
						nilnul.num.rational.Bound.Inverse(x.val.upper)
						,
						nilnul.num.rational.Bound.Inverse(x.val.lower)
					)	
				);
			
			}

			static public Asserted Inverse(Nonempty.Asserted x) {
				return Inverse( new Asserted(x.val)  );
			}

		}




	}
}
