using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational.accuracy
{
	public  abstract class FiniteA
		:
		IntervalI
		,
		
		FiniteI
	{
		




		public rational.be.NonNegX.Asserted radius
		{
			get {
				return new rational.be.NonNegX.Asserted(  nilnul.num.rational.op.MaxX.Do(upperBound, lowerBound));
				
				throw new NotImplementedException(); 
			
			}
		}






		public abstract bool contains(R item);

		private R _lowerBound;

		
		


		public  R lowerBound
		{
			get {
				return _lowerBound;
			}
			set {
				nilnul.bit.AssertX.True(value <= 0);


				_lowerBound = value;

			
			}
		}
		private R _upperBound;

		public  R upperBound
		{
			get {
				return _upperBound;
			}
			set { 
				nilnul.bit.AssertX.True(value >= 0);


				_upperBound = value;
			
			}
		}
	}
}
