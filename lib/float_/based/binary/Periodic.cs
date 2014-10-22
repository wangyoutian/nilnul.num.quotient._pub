using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational.float_.based.binary
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>recurring, cyclic, repeating, recurring...</remarks>
	public partial class Periodic
		:nilnul.num.rational.float_.Periodic
	{

		public Periodic(Float float_, nilnul.num.natural.Natural_bigInteger recurringSpan)
			:base(new nilnul.num.rational.float_.based.Binary(float_),recurringSpan)

		{



		}

		static public Periodic FroRational(
			R rational
			
		) {
			var r=			 nilnul.num.rational.float_.Periodic.FroRational_binary(rational);

			return new Periodic(r.float_.float_, r.recurSpan);

			throw new NotImplementedException();
		}


		
		
	}
}
