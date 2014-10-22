using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational.neighbor
{
	public partial class Clopen
		:
		IntervalI
	{
		private R _upperOpenBound;

		public R upperOpenBound
		{
			get { return _upperOpenBound; }
			set {

				nilnul.bit.AssertX.True(value > 0);

				
				_upperOpenBound = value;
			
			}
		}

		private R _lowerBound;

		public R lowerBound
		{
			get { return _lowerBound; }
			set {
				nilnul.bit.AssertX.True(value <= 0);

				_lowerBound = value; }
		}
		

		
		public Clopen(R lower, R upperOpenBound)
		{
			this.upperOpenBound = upperOpenBound;
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

			return n >= lowerBound && n < upperOpenBound;
		
		}


	


	
	}
}
