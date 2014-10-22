using nilnul.num.rational.accuracy.bounded;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational.accuracy
{
	public partial class OpenClose
		:
		FiniteA,
		IntervalI
		,OpenLeftI,
		CloseRightI
		
	{
		
		

		
		
		public OpenClose(R lower, R upperOpenBound)
		{
			this.upperBound=( upperOpenBound);
			this.lowerBound=( lower);

			if (lowerBound == upperBound)
			{
				throw new Exception();

			}

		}

		public OpenClose(int a,R upperBound)
			:this(new R(a),upperBound)
		{

		}

		public OpenClose(int a,int b)
			:this(a,new R(b))
		{

		}
		



		public override bool contains(R n) {

			return n > lowerBound && n <= upperBound;
		
		}





		public rational.be.NonNegX.Asserted radius
		{
			get {
				return new rational.be.NonNegX.Asserted(  nilnul.num.rational.op.MaxX.Do(upperBound, lowerBound));
				
				throw new NotImplementedException(); 
			
			}
		}

	
	}
}
