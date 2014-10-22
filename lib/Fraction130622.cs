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
    public partial class Fraction130622
		
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

		public Fraction130622(BigInteger numerator)
		:this(numerator,1)
		{ }


        public Fraction130622(BigInteger numerator,BigInteger denominator)
        {
			
            this.numerator = numerator;
			this.denominator = denominator;

        }

		public Fraction130622 inverse() {
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

		public Fraction130622 reduce1()
		{

			var standFrac = Divide.Eval(numerator, denominator);
			this.numerator = standFrac.Numerator();
			this.denominator = standFrac.Denominator();
			return this;



		}

		public double toDouble() {
			return (double)(numerator) / (double)(denominator);
		}

		static public Fraction130622 Inverse(Fraction130622 a) {

			return new Fraction130622(a.numerator, a.denominator);
				
			
		}

		static public Fraction130622 AddAndSimplify(Fraction130622 a,Fraction130622 b) {
			Fraction130622 r=new Fraction130622(a.numerator*b.denominator+a.denominator*b.numerator,a.denominator*b.denominator);
			r.simplify();

			return r;
		
		}

		static public Fraction130622 ToFraction2(long a) {
			return new Fraction130622(a, 1);
		}

		static public Fraction130622 AddAndSimplify(Fraction130622 a, int b)
		{
			return AddAndSimplify(a, new Fraction130622(b, 1));

		}

		static public Fraction130622 AddAndSimplify(Fraction130622 a, long b)
		{
			return AddAndSimplify(a, new Fraction130622(b, 1));

		}



		static public Fraction130622 AddAndSimplify(int a,Fraction130622 b)
		{
			return AddAndSimplify( b,a);

		}

		static public Fraction130622 AddAndSimplify(long a, Fraction130622 b)
		{
			return AddAndSimplify(b, a);

		}
		/// <summary>
		/// to parse a string as fraction
		/// </summary>
		/// <param name="s"></param>
		/// <returns></returns>
		static public Fraction130622 Parse(string s) {

			///first find the /
			///
			/// 
			string[] terms= s.Split(Divide.Sign);
			if (terms.Length!=2)
			{
				throw new Exception(string.Format("There are more than two terms sperated by {0}.",Divide.Sign));
				
			}

			return new Fraction130622(BigInteger.Parse(terms[0]), BigInteger.Parse(terms[1]));


			/// 
			///first is it an integer?
			///

 

		
		}

    }
}
