using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational.interval
{
	public partial class Clopen
		:
		IntervalI
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
		

		
		public Clopen(R lower, R upperOpenBound)
		{
			this.upperBound = upperOpenBound;
			this.lowerBound = lower;

		}

		public Clopen(int a,R upperBound)
			:this(new R(a),upperBound)
		{

		}

		public Clopen(int a,int b)
			:this(a,new R(b))
		{

		}
		static public Clopen CreateLowerZero(R right) {
			return new Clopen(0, right);
		
		}
		



		public bool contains(R n) {

			return n >= lowerBound && n < upperBound;
		
		}


	


	
	}
}
