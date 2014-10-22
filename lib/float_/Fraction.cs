using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.natural;

namespace nilnul.num.rational.float_
{
	/// <summary>
	/// A quotient times an exponent.
	/// </summary>
	public partial class Fraction
	{
		Count _denominator=(Count)1;	

		public Count denominator { get {
			return _denominator;
		}
			set {
				_denominator = value;
			}
		}

		private Float _numerator;

		public Float numerator
		{
			get { return _numerator; }
			set { _numerator = value; }
		}




		public Fraction(Float numerator,Count denominator)
		{
			this.numerator = numerator;
			this.denominator = denominator;
		}


		public Fraction reduce() {
			///



			_numerator.reduce2(); 


			///find the common divisor of 
			///
			var t=FloatX.SignificandToPower(_denominator.val,_numerator.@base_);

			_numerator.power /= t.Item1;
			
			//
			var gcd=BigInteger.GreatestCommonDivisor(_numerator.significand, denominator);


			
			return this;





			
 
			//
		
		}

		public Fraction inverse() {
			var num = numerator;
			numerator = new Float(denominator, numerator.@base_, 1);

			_denominator = (Count)(numerator.significand);

			
			return this.reduce();
		}

		static public Fraction Divide(Float a, Float b) {

			

			return new Fraction(   new Float(a.significand,a.@base_,a.power-b.power), (Count)(b.significand)).reduce();
		}

		/// <summary>
		/// find the closure
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
	

		static public Fraction Add(Fraction a,Fraction b) {


			return new Fraction(
				a.numerator * b.denominator + b.numerator * a.denominator, 
				a.denominator * a.denominator
			).reduce();

			
			
		
		}

		static public Fraction Inverse(Fraction a) {
			return (a.MemberwiseClone() as Fraction).inverse();

		
		}

		
	}
}
