using nilnul.num.natural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational.interval
{
	public partial class Open
		: IntervalI
		,
		UpperBoundI
		,LowerBoundI
	{
		private R _upperBound;

		public R upperBound
		{
			get { return _upperBound; }
			set { _upperBound = value; }
		}

		private R _lowerBound;

		public R lowerBound
		{
			get { return _lowerBound; }
			set { _lowerBound = value; }
		}



		public Open(R lowerBound, R upperOpenBound)
		{
			this.upperBound = upperOpenBound;
			this.lowerBound = lowerBound;

		}

		static public Open CreateSymmetric(rational.be.Positive.Asserted radius)
		{

			if (radius.val < 0)
			{
				return new Open(radius.val, -radius.val);

			}
			return new Open(-radius.val, radius.val);

		}
		static public Open _CreateSymmetric(R radius_positive)
		{

			if (radius_positive < 0)
			{
				return new Open(radius_positive, -radius_positive);

			}
			return new Open(-radius_positive, radius_positive);

		}

		public bool contains(R n)
		{
			return n > lowerBound && n < upperBound;
		}





	
	}
}
