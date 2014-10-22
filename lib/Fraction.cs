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
    public partial class Fraction:RationalI
    {
        public BigInteger numerator;
        public PositiveNatural denominator;

        public Fraction(BigInteger numerator,BigInteger denominator)
        {
            this.numerator = numerator;
			this.denominator = new PositiveNatural(denominator);

        }

		public Fraction inverse() {
			return Inverse(this);
		}

		public Fraction(int numerator, int denominator)
		{
			this.numerator = numerator;
			this.denominator = new PositiveNatural(denominator);

		}

		public Fraction(BigInteger numerator, PositiveNatural denominator)
		{
			this.numerator = numerator;
			this.denominator = denominator;

		}
		public override string ToString()
		{
			return numerator.ToString() +"/"+denominator.ToString();
		}



		public void simplify() {

			BigInteger gcd = BigInteger.GreatestCommonDivisor(numerator, denominator.toBigint());
			numerator = numerator / gcd;
			denominator=new PositiveNatural(denominator.toBigint()/gcd );
		
		
		}

		public double toDouble() {
			return (double)(numerator) / (double)(denominator.toBigint());
		}

		static public Fraction Inverse(Fraction a) {

			if (a.numerator.Sign==0)
			{
				throw new DivideByZeroException();
				
			}
			if (a.numerator>0)
			{
				return new Fraction(a.denominator.toBigint(), new PositiveNatural(a.numerator));
				
			}
			
				return new Fraction(-a.denominator.toBigint(), new PositiveNatural(a.numerator));
				
			
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


		public RationalI eval()
		{
			return this;
		}
	}
}
