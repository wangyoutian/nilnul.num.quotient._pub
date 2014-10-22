using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational.neighbor
{
	public partial class OpenClose
		:
		FiniteA,
		IntervalI
		
	{
		
		

		
		
		public OpenClose(R lower, R upperOpenBound)
		{
			this.upperBound=( upperOpenBound);
			this.lowerBound=( lower);

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





		public be.NonNegX.Asserted radius
		{
			get {
				return new be.NonNegX.Asserted(  nilnul.num.rational.op.MaxX.Do(upperBound, lowerBound));
				
				throw new NotImplementedException(); 
			
			}
		}

	
	}
}
