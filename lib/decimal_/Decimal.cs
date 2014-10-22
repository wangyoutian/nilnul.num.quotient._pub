using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.rational.decimal_
{
	public partial class Decimal
		:Float
	{

		public Decimal(BigInteger significand, BigInteger index)
			:base(significand,10,index)
		{

		}
					
		
	}
}
