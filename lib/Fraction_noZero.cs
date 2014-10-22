using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.natural;

namespace nilnul.num.rational
{
	/// <summary>
	/// guratee that denominator is positive.
	/// </summary>
    public partial class Fraction_noZero
		
		:
		RationalA,
		RationalI
    {
        public BigInteger numerator;
        public BigInteger _denominator;
		public BigInteger denominator { 
			get{
				return _denominator;
			}

			set{

				nilnul.num.integer.Zero.AssertNot(value);
				_denominator=value;
				
			}
		
		
		}


        public Fraction_noZero(BigInteger numerator,BigInteger denominator)
        {
			
            this.numerator = numerator;
			this.denominator = denominator;

        }

		public Fraction_noZero inverse() {
			return Inverse(this);
		}

		
		
		public override string ToString()
		{
			return numerator.ToString() +"/"+denominator.ToString();
		}



		public void simplify() {

			var standFrac=Divide.Eval(numerator, denominator);
			this.numerator = standFrac.Numerator();
			this.denominator = standFrac.Denominator();
		
		
		}

		public void reduce()
		{

			var standFrac = Divide.Eval(numerator, denominator);
			this.numerator = standFrac.Numerator();
			this.denominator = standFrac.Denominator();



		}

		public Fraction_noZero reduce1()
		{

			var standFrac = Divide.Eval(numerator, denominator);
			this.numerator = standFrac.Numerator();
			this.denominator = standFrac.Denominator();
			return this;



		}

		public double toDouble() {
			return (double)(numerator) / (double)(denominator);
		}

		static public Fraction_noZero Inverse(Fraction_noZero a) {

			return new Fraction_noZero(a.numerator, a.denominator);
				
			
		}

		static public Fraction AddAndSimplify(Fraction a,Fraction b) {
			Fraction r=new Fraction(a.numerator*b.denominator.toBigint()+a.denominator.toBigint()*b.numerator,a.denominator.toBigint()*b.denominator.toBigint());
			r.simplify();

			return r;
		
		}

		static public Fraction AddAndSimplify(Fraction a, int b)
		{
			return AddAndSimplify(a, new Fraction(b, 1));

		}
		/// <summary>
		/// to parse a string as fraction
		/// </summary>
		/// <param name="s"></param>
		/// <returns></returns>
		static public Fraction Parse(string s) {

			///first find the /
			///
			/// 
			string[] terms= s.Split(Divide.Sign);
			if (terms.Length!=2)
			{
				throw new Exception(string.Format("There are more than two terms sperated by {0}.",Divide.Sign));
				
			}

			return new Fraction(BigInteger.Parse(terms[0]), BigInteger.Parse(terms[1]));


			/// 
			///first is it an integer?
			///

 

		
		}

    }
}
