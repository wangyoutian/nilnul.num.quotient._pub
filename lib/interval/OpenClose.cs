using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational.interval
{
	public partial class OpenClose
		:IntervalI
		,UpperBoundI
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
		

		
		public OpenClose(R lower, R upperOpenBound)
		{
			this.upperBound = upperOpenBound;
			this.lowerBound = lower;

		}

		public OpenClose(int a,R upperBound)
			:this(new R(a),upperBound)
		{

		}

		public OpenClose(int a,int b)
			:this(a,new R(b))
		{

		}
		



		public bool contains(R n) {

			return n > lowerBound && n <= upperBound;
		
		}


	

	}
}
