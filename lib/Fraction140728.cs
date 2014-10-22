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
	public partial class Fraction140728
	{


		public BigInteger numerator;
		public num.natural.__bigint.be.Positive.Asserted _denominator;
		public num.natural.__bigint.be.Positive.Asserted denominator
		{
			get
			{
				return _denominator;
			}

			set
			{


				_denominator = value;

			}


		}
		public Fraction140728()
			:this(0)
		{

		}

		public Fraction140728(BigInteger numerator)
			: this(numerator, 1)
		{ }

		public Fraction140728(
			BigInteger num
			,
			num.natural.__bigint.be.Positive.Asserted denominator
		)
		{
			this.numerator = num;
			this.denominator = denominator;


		}


		public Fraction140728(BigInteger numerator, BigInteger denominator)
			: this(
			numerator
			,
			new natural.__bigint.be.Positive.Asserted(denominator)
		)
		{



		}

		public Fraction140728 inverse()
		{
			return Inverse(this);
		}



		public override string ToString()
		{
			return numerator.ToString() + "/" + denominator.ToString();
		}



		public void simplify()
		{
			var gcd = nilnul.num.i.op.Gcd.Eval(numerator, denominator);

			numerator = nilnul.num.i.op.Divide.Eval(  numerator, gcd);


			this.denominator =nilnul.num.i.op.Divide.Eval(  denominator, gcd) ;


		}

		static public Fraction140728 Divide(BigInteger x, BigInteger y) {

			if (y<0)
			{
				return new Fraction140728(-x, -y);
				
			}
			return new Fraction140728(x, y);
		
		}	

		static public Fraction140728 Divide(num.natural.__bigint.be.Positive.Asserted x, BigInteger y) {

			if (y<0)
			{
				return new Fraction140728(-x.val, -y);
				
			}
			return new Fraction140728(x.val, y);
		
		}	

		static public Fraction140728 Inverse(Fraction140728 a)
		{

			return Divide(a.denominator,a.numerator);


		}

	

		static public Fraction140728 ToFraction2(long a)
		{
			return new Fraction140728(a, 1);
		}

		



	
		/// <summary>
		/// to parse a string as fraction
		/// </summary>
		/// <param name="s"></param>
		/// <returns></returns>
		static public Fraction140728 Parse(string s)
		{

			///first find the /
			///
			/// 
			string[] terms = s.Split(op.Divide.Sign);
			if (terms.Length != 2)
			{
				throw new Exception(string.Format("There are more than two terms sperated by {0}.", op.Divide.Sign));

			}

			return new Fraction140728(BigInteger.Parse(terms[0]), BigInteger.Parse(terms[1]));


			/// 
			///first is it an integer?
			///




		}

	}
}
