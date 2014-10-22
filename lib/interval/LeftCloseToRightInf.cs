using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using R = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational.interval
{
	public partial class LeftCloseToRightInf
		: IntervalI
	{

		private R _lowerBound;

		public R lowerBound
		{
			get { return _lowerBound; }
			set { _lowerBound = value; }
		}



		public LeftCloseToRightInf(R lowerBound)
		{
			this.lowerBound = lowerBound;

		}
		public LeftCloseToRightInf(int lower)
			:this(new R(lower))
		{

		}

		static public LeftCloseToRightInf CreateLowerZero() {
			return new LeftCloseToRightInf(0);
		}
		

		public bool contains(R n)
		{
			return n >=lowerBound ;
		}





		
	}
}
