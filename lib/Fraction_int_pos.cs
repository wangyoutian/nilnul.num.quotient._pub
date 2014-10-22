using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.natural;
using nilnul.num.integer;

namespace nilnul.num.rational
{
	/// <summary>
	/// guratee that denominator is positive.
	/// </summary>
    public partial class Fraction_int_pos:RationalI
    {
        public Integer numerator;
        public PositiveNatural denominator;

        public Fraction_int_pos(BigInteger numerator,BigInteger denominator)
        {
            this.numerator = numerator;
			this.denominator = new PositiveNatural(denominator);

        }

		public Fraction_int_pos(BigInteger numerator)
			:this(numerator,1)
		{
			

		}

		public Fraction_int_pos inverse() {
			return Inverse(this);
		}

		public Fraction_int_pos(int numerator, int denominator)
		{
			this.numerator = new Integer( numerator);
			this.denominator = new PositiveNatural(denominator);

		}

		public Fraction_int_pos(BigInteger numerator, PositiveNatural denominator)
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
			return (double)( numerator.toBigint()) / (double)(denominator.toBigint());
		}

		static public Fraction_int_pos Inverse(Fraction_int_pos a) {

			if (a.numerator.bigInt==0)
			{
				throw new DivideByZeroException();
				
			}
			if (a.numerator.bigInt>0)
			{
				return new Fraction_int_pos(a.denominator.toBigint(), new PositiveNatural(a.numerator));
				
			}
			
				return new Fraction_int_pos(-a.denominator.toBigint(), new PositiveNatural(a.numerator));
				
			
		}

		static public Fraction_int_pos AddAndSimplify(Fraction_int_pos a,Fraction_int_pos b) {
			Fraction_int_pos r=new Fraction_int_pos(a.numerator*b.denominator.toBigint()+a.denominator.toBigint()*b.numerator,a.denominator.toBigint()*b.denominator.toBigint());
			r.simplify();

			return r;
		
		}

		

		static public Fraction_int_pos AddAndSimplify(Fraction_int_pos a, int b)
		{
			return AddAndSimplify(a, new Fraction_int_pos(b, 1));

		}

		static public Fraction_int_pos AddAndSimplify(Fraction_int_pos a, long b)
		{
			return AddAndSimplify(a, new Fraction_int_pos(b, 1));

		}

		static public Fraction_int_pos AddAndSimplify(long a,Fraction_int_pos  b)
		{
			return AddAndSimplify(b, a);

		}
		/// <summary>
		/// to parse a string as fraction
		/// </summary>
		/// <param name="s"></param>
		/// <returns></returns>
		static public Fraction_int_pos Parse(string s) {

			///first find the /
			///
			/// 
			string[] terms= s.Split(Divide.Sign);
			if (terms.Length!=2)
			{
				throw new Exception(string.Format("There are more than two terms sperated by {0}.",Divide.Sign));
				
			}

			return new Fraction_int_pos(BigInteger.Parse(terms[0]), BigInteger.Parse(terms[1]));


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
