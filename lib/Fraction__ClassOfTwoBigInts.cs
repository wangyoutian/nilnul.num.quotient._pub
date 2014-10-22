using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.natural;

namespace nilnul.num.rational
{
	public partial class Fraction__LazyValidated : RationalI
	{
		public BigInteger numerator;
		public BigInteger denominator;

		public Fraction__LazyValidated(BigInteger numerator, BigInteger denominator)
		{
			this.numerator = numerator;
			this.denominator = denominator;

		}

		public Fraction__LazyValidated(BigInt i):this(i.val,1)
		{
		}
					
		public Fraction__LazyValidated(int numerator, int denominator)
		{
			this.numerator = numerator;
			this.denominator = denominator;

		}
		public override string ToString()
		{
			return numerator.ToString() + Divide.Sign + denominator.ToString();
		}


		


		public void standardizeDivideZero() {
			if (denominator==0)
			{
				throw new Exception();
				
			}
		}

		public void assertDenominatorNoteZero()
		{
			if (denominator == 0)
			{
				throw new Exception();

			}
		}


		public bool eq(Fraction__LazyValidated another) {

			another.assertDenominatorNoteZero();
			this.assertDenominatorNoteZero();

			return this.numerator * another.denominator == this.denominator * another.numerator;
		
		}
		public bool neq(Fraction__LazyValidated another)
		{

			return !eq(another);
		
		}


		public bool eq(BigInt other) {

			return eq(new Fraction__LazyValidated(other));
		
		}



		public void standardize()
		{
			standardizeSign();

			BigInteger gcd = BigInteger.GreatestCommonDivisor(numerator, denominator);

			///gcd cannot be zero due to normalizeSign(). so gcd>0.
			numerator = numerator / gcd;
			denominator = denominator / gcd;


		}

		public Fraction__LazyValidated standardizeSelf()
		{
			standardizeSign();

			BigInteger gcd = BigInteger.GreatestCommonDivisor(numerator, denominator);

			///gcd cannot be zero due to normalizeSign(). so gcd>0.
			numerator = numerator / gcd;
			denominator = denominator / gcd;
			return this;


		}
		

		public void standardizeSign()
		{
			standardizeDivideZero();
			naturalizeDenominator();
			

		}


		public void naturalizeDenominator()
		{
			
			if (denominator < 0)
			{
				this.denominator = -denominator;
				this.numerator = -numerator;
				return;

			}


		}

		public static void StandardizeSign(Fraction__LazyValidated f)
		{
			 f.standardizeSign();
		}

		public double toDouble()
		{
			return (double)(numerator) / (double)(denominator);
		}

		static public Fraction__LazyValidated Inverse(Fraction__LazyValidated a)
		{


			return new Fraction__LazyValidated(a.denominator, a.numerator);



		}

		static public Fraction__LazyValidated InverseAndStandardize(Fraction__LazyValidated a)
		{


			var r= new Fraction__LazyValidated(a.denominator, a.numerator);
			r.standardize();
			return r;



		}


		static public Fraction__LazyValidated Add(Fraction__LazyValidated a, Fraction__LazyValidated b)
		{
			return new Fraction__LazyValidated(a.numerator * b.denominator + a.denominator * b.numerator, a.denominator * b.denominator);

		}


		static public Fraction__LazyValidated AddAndStandardize(Fraction__LazyValidated a, Fraction__LazyValidated b)
		{


			var r= Add(a, b);
			r.standardize();
			return r;

		}

		static public void Standardize(Fraction__LazyValidated f)
		{

			f.standardize();

		}

		static public Fraction__LazyValidated AddAndStandardize(Fraction__LazyValidated a, int b)
		{
			var r= AddAndStandardize(a, new Fraction__LazyValidated(b, 1));
			
			return r;

		}
		/// <summary>
		/// to parse a string as fraction
		/// </summary>
		/// <param name="s"></param>
		/// <returns></returns>
		static public Fraction__LazyValidated Parse(string s)
		{

			///first find the /
			///
			/// 
			string[] terms = s.Split(Divide.Sign);
			if (terms.Length != 2)
			{
				throw new Exception(string.Format("There are more than two terms sperated by {0}.", Divide.Sign));

			}

			return new Fraction__LazyValidated(BigInteger.Parse(terms[0]), BigInteger.Parse(terms[1]));


			/// 
			///first is it an integer?
			///


		}

		

		static public Fraction__LazyValidated ParseAndStandardize(string s)
		{

			///first find the /
			///
			/// 
			string[] terms = s.Split(Divide.Sign);
			if (terms.Length != 2)
			{
				throw new Exception(string.Format("There are more than two terms sperated by {0}.", Divide.Sign));

			}

			var r= new Fraction__LazyValidated(BigInteger.Parse(terms[0]), BigInteger.Parse(terms[1]));
			r.standardize();
			return r;


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
