using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using R = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational.interval
{
	public partial class NegInfToUpperOpen
		: IntervalI
	{

		private R _lowerBound;

		public R lowerBound
		{
			get { return _lowerBound; }
			set { _lowerBound = value; }
		}



		public NegInfToUpperOpen(R lowerBound)
		{
			this.lowerBound = lowerBound;

		}
		public NegInfToUpperOpen(int lower)
			:this(new R(lower))
		{

		}

		static public NegInfToUpperOpen CreateLowerZero() {
			return new NegInfToUpperOpen(0);
		}
		

		public bool contains(R n)
		{
			return n <lowerBound ;
		}





		
	}
}
