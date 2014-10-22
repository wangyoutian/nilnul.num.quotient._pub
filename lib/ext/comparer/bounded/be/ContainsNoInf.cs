using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.ext.comparer.bounded.be
{
	public partial class ContainsNoInf
	{
		static public  bool Eval(Bounded bounded) {

			return ContainsNoNegInf(bounded) && ContainsNoPosInf(bounded);
		
		}

		public class Be:
			nilnul.bit.Be<Bounded>
		{
			public Be()
				:base(Eval)
			{

			}
			
		}





		static bool ContainNegInf(Bounded bounded)
		{

			return bounded.contains(
				nilnul.order.ext.NegInf<Rational_InheritFraction2>.Singleton
			);
		}
		static bool ContainPosInf(Bounded bounded)
		{

			return bounded.contains(
				nilnul.order.ext.PosInf<Rational_InheritFraction2>.Singleton
			);
		}


		static bool ContainsNoNegInf(Bounded bounded)
		{

			return !ContainNegInf(bounded);
		}


		static public bool ContainsNoPosInf(Bounded bounded) {
			return !ContainPosInf(bounded);
		}

	}
}
