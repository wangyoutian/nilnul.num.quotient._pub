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
    public partial class Fraction_natural
		:
		RationalA,
		RationalI
    {
        public Natural2 numerator;
        public PositiveNatural3 _denominator;
		public PositiveNatural3 denominator { 
			get{
				return _denominator;
			}

			set{

				nilnul.num.integer.Zero.AssertNot(value);
				_denominator=value;
				
			}
		
		
		}

		public Fraction_natural(Natural2 numerator)
		:this(numerator, new PositiveNatural3( 1))
		{ }


        public Fraction_natural(Natural2 numerator,PositiveNatural3 denominator)
        {
			
            this.numerator = numerator;
			this.denominator = denominator;

        }

		public Fraction_natural(BigInteger numerator, BigInteger denominator)
			:this(new Natural2(numerator),new PositiveNatural3(denominator))
		{

			

		}


		public Fraction_natural inverse() {
			return Inverse(this);
		}

		
		
		public override string ToString()
		{
			return numerator.ToString() +"/"+denominator.ToString();
		}



		public void simplify() {

			var standFrac=Divide.Eval(numerator, denominator);

			this.numerator = standFrac.numerator;
			this.denominator = standFrac.denominator;
		
		
		}

		public void reduce()
		{

			var standFrac = Divide.Eval(numerator, denominator);
			this.numerator = standFrac.numerator;
			this.denominator = standFrac.denominator;



		}

		public Fraction_natural reduce1()
		{

			var standFrac = Divide.Eval(numerator, denominator);
			this.numerator = standFrac.numerator;
			this.denominator = standFrac.denominator;
			return this;



		}

		public double toDouble() {
			return (double)(numerator) / (double)(denominator.val);
		}



		static public Fraction_natural Inverse(Fraction_natural a) {

			return new Fraction_natural(a.numerator, a.denominator);
				
			
		}

		static public Fraction_natural AddAndSimplify(Fraction_natural a,Fraction_natural b) {
			Fraction_natural r=new Fraction_natural(a.numerator.val*b.denominator.val+a.denominator.val*b.numerator.val,a.denominator.val*b.denominator.val);
			r.simplify();

			return r;
		
		}

		static public Fraction_natural ToFraction2(long a) {
			return new Fraction_natural(a, 1);
		}

		static public Fraction_natural AddAndSimplify(Fraction_natural a, int b)
		{
			return AddAndSimplify(a, new Fraction_natural(b, 1));

		}

		static public Fraction_natural AddAndSimplify(Fraction_natural a, long b)
		{
			return AddAndSimplify(a, new Fraction_natural(b, 1));

		}



		static public Fraction_natural AddAndSimplify(int a,Fraction_natural b)
		{
			return AddAndSimplify( b,a);

		}

		static public Fraction_natural AddAndSimplify(long a, Fraction_natural b)
		{
			return AddAndSimplify(b, a);

		}
		/// <summary>
		/// to parse a string as fraction
		/// </summary>
		/// <param name="s"></param>
		/// <returns></returns>
		static public Fraction_natural Parse(string s) {

			///first find the /
			///
			/// 
			string[] terms= s.Split(Divide.Sign);
			if (terms.Length!=2)
			{
				throw new Exception(string.Format("There are more than two terms sperated by {0}.",Divide.Sign));
				
			}

			return new Fraction_natural(BigInteger.Parse(terms[0]), BigInteger.Parse(terms[1]));


			/// 
			///first is it an integer?
			///

 

		
		}

    }
}
