using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using R = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational.interval
{
	public partial class NegInfToUpperClose
		: IntervalI
	{

		private R _lowerBound;

		public R lowerBound
		{
			get { return _lowerBound; }
			set { _lowerBound = value; }
		}



		public NegInfToUpperClose(R lowerBound)
		{
			this.lowerBound = lowerBound;

		}
		public NegInfToUpperClose(int lower)
			:this(new R(lower))
		{

		}

		static public NegInfToUpperClose CreateLowerZero() {
			return new NegInfToUpperClose(0);
		}
		

		public bool contains(R n)
		{
			return n <=lowerBound ;
		}





		
	}
}
