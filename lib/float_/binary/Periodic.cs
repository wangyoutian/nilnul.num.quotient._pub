using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.rational.float_.binary
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


		
		
	}
}
