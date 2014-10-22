using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using R = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational.interval
{
	public partial class LeftOpenToRightInf
		: IntervalI
	{

		private R _lowerBound;

		public R lowerBound
		{
			get { return _lowerBound; }
			set { _lowerBound = value; }
		}



		public LeftOpenToRightInf(R lowerBound)
		{
			this.lowerBound = lowerBound;

		}

		public bool contains(R n)
		{
			return n > lowerBound ;
		}






	
	}
}
