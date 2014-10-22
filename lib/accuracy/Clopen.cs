using nilnul.num.rational.accuracy.bounded;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational.accuracy
{
	public partial class Clopen
		:
		FiniteA
		,
		IntervalI
		,
		CloseLeftI
		,OpenRightI
	{
		


		
		public Clopen(R lower, R upperOpenBound)
		{
			this.upperBound = upperOpenBound;
			this.lowerBound = lower;

			if (lowerBound == upperBound)
			{
				throw new Exception();

			}

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
		



		public override bool contains(R n) {

			return n >= lowerBound && n < upperBound;
		
		}


	


	
	}
}
