using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational.interval
{
	public partial class Close
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
		

		
		public Close(R lower, R upperOpenBound)
		{
			this.upperBound = upperOpenBound;
			this.lowerBound = lower;

		}

		public Close(int a,R upperBound)
			:this(new R(a),upperBound)
		{

		}

		public Close(int a,int b)
			:this(a,new R(b))
		{

		}
		
		static public Close CreateSingleton(R upper)
			
		{
			return new Close(upper, upper);
		}

		static public Close CreateLowerZero(R upper)
		{
			return new Close(0, upper);

		}
		static public Close CreateSymmetric(R radius)
		{
			if (radius<0)
			{
				return new Close(radius, -radius);
				
			}
			return new Close(-radius, radius);

		}



		public bool contains(R n) {

			return n >= lowerBound && n <= upperBound;
		
		}


	

	}
}
