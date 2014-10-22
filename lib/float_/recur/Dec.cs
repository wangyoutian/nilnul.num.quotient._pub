using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.rational.float_.recur
{
	public partial class Dec
		:Periodic
	{
		public Dec(Float f, nilnul.num.natural.Natural_bigInteger recurSpan )
			:base(10,f,recurSpan)
		{

		}

		

		static public explicit operator Dec(Rational_InheritFraction2 q) {

			var t=Periodic.FroRational(10, q);


			return	new Dec(t.float_.float_, t.recurSpan);
				
		}



		

		


	}
}
