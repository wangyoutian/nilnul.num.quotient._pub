using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R=nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational.interval
{
	public abstract partial class BoundedA
		:
		nilnul.order.interval.BoundedA<R,Comparer>
	{
		public BoundedA(R lower, R upper)
			:base(lower,upper)
			
		{

		}

		
	}
}
