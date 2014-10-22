using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.order
{
	public partial class Rational
		:nilnul.order.TotalOrderedTypeA<nilnul.num.rational.Rational_InheritFraction,LessThanOrEqualTo2>
	{

		public Rational(Rational_InheritFraction val)
			:base(val)
		{
		}
					
		
	}
}
