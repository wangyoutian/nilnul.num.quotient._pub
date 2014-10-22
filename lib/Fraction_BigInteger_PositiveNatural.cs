using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.natural;
using Fraction2 = nilnul.num.rational.Fraction_BigInteger_PositiveNatural3_;

namespace nilnul.num.rational
{
	/// <summary>
	/// guratee that denominator is positive.
	/// </summary>
    public partial class Fraction_BigInteger_PositiveNatural3_:

		
		RationalI

		,
		IEquatable<Fraction_BigInteger_PositiveNatural3_>
    {
		public nilnul.order.Sign sign {
			get {
				return nilnul.order.SignX.ToSign(numerator.Sign);
			}
		}
        public BigInteger numerator;
        public PositiveNatural_inheritNatural denominator;

		public BigInteger numerator1 {
			get {
				return numerator;
			}
			private set {
				numerator = value;
			}
		}

		public Fraction_BigInteger_PositiveNatural3_()
		{
			//numerator is default to 0
			this.denominator = new PositiveNatural_inheritNatural();
		}


		public Fraction_BigInteger_PositiveNatural3_(
			BigInteger numerator
			,
			PositiveNatural_inheritNatural denominator
		)
		{
			this.numerator = numerator;
			this.denominator = denominator;
		}


		public Fraction_BigInteger_PositiveNatural3_(BigInteger numerator)
			: this(numerator, 1)
		{


		}

		public Fraction_BigInteger_PositiveNatural3_(PositiveNatural3 numerator)
			: this(numerator.val.val)
		{


		}

        public Fraction_BigInteger_PositiveNatural3_(BigInteger numerator,BigInteger denominator)
        {
			if (denominator<0)
			{
				this.numerator = -numerator;
				this.denominator = new PositiveNatural_inheritNatural( -denominator);
				return;

				
			}

            this.numerator = numerator;
			this.denominator = new PositiveNatural_inheritNatural(denominator);

        }

		public override string ToString()
		{
			return String.Format("{0}/{1}", numerator, denominator);
		}


		public static Fraction_BigInteger_PositiveNatural3_ operator +(Fraction_BigInteger_PositiveNatural3_ a,
			Fraction_BigInteger_PositiveNatural3_ b
			
			){

				return Add(a, b);

		
		}

		public static Fraction_BigInteger_PositiveNatural3_ operator +(PositiveNatural_inheritNatural a,
		Fraction_BigInteger_PositiveNatural3_ b

		)
		{

			return Add(a, b);


		}

		public static Fraction_BigInteger_PositiveNatural3_ operator +(BigInteger a,
	Fraction_BigInteger_PositiveNatural3_ b

	)
		{

			return Add(a, b);


		}

		public static Fraction_BigInteger_PositiveNatural3_ Add(PositiveNatural_inheritNatural a,
	Fraction_BigInteger_PositiveNatural3_ b

	)
		{
			return Add(new Fraction_BigInteger_PositiveNatural3_(a), b);


		}

		public static Fraction_BigInteger_PositiveNatural3_ Multiply(Fraction_BigInteger_PositiveNatural3_ a,
Fraction_BigInteger_PositiveNatural3_ b

)
		{
			return new Fraction_BigInteger_PositiveNatural3_(a.numerator*b.numerator,a.denominator*b.denominator);


		}

		public static Fraction_BigInteger_PositiveNatural3_ Divide(Fraction_BigInteger_PositiveNatural3_ a,
Fraction_BigInteger_PositiveNatural3_ b

)
		{
			return Multiply(a,Inverse( b));


		}

		

		public static Fraction_BigInteger_PositiveNatural3_ Add(BigInteger a,
	Fraction_BigInteger_PositiveNatural3_ b

	)
		{
			return Add(new Fraction_BigInteger_PositiveNatural3_(a), b);


		}

		public static Fraction_BigInteger_PositiveNatural3_ Add(Fraction_BigInteger_PositiveNatural3_ a,
		Fraction_BigInteger_PositiveNatural3_ b

		)
		{
			return new Fraction_BigInteger_PositiveNatural3_(a.numerator * b.denominator + a.denominator * b.numerator, a.denominator * b.denominator);


		}

	

		public Fraction_BigInteger_PositiveNatural3_ inverse() {
			return Inverse(this);
		}

		public Fraction_BigInteger_PositiveNatural3_(int numerator, int denominator)
		{
			this.numerator = numerator;
			this.denominator = new PositiveNatural_inheritNatural(denominator);

		}

		
	



		public void simplify() {


			
			///http://msdn.microsoft.com/en-us/library/vstudio/system.numerics.biginteger.greatestcommondivisor(v=vs.100).aspx
			///If the left and right parameters are non-zero numbers, the method always returns at least a value of 1 because all numbers can be divided by 1. If either parameter is zero, the method returns the absolute value of the non-zero parameter. If both values are zero, the method returns zero.
			///The value returned by the GreatestCommonDivisor method is always positive regardless of the sign of the left and right parameters.
			///


			BigInteger gcd = BigInteger.GreatestCommonDivisor(numerator, denominator.val);	//is this negative?


			numerator = numerator / gcd;
			denominator=new PositiveNatural_inheritNatural(denominator.val/gcd );
		
		}

		

		public void reduce() {
			simplify();
		}

		public double toDouble() {
			return (double)(numerator) / (double)(denominator.toBigint());
		}

		static public Fraction_BigInteger_PositiveNatural3_ Reduce(Fraction_BigInteger_PositiveNatural3_ a) {
			var r=a.MemberwiseClone() as Fraction_BigInteger_PositiveNatural3_;

			/// denominator

			r.simplify();	//denominator will point to another object.
			
			return r;
		
		}

		static public Fraction_BigInteger_PositiveNatural3_ Inverse(Fraction_BigInteger_PositiveNatural3_ a) {

			if (a.numerator.Sign==0)
			{
				throw new DivideByZeroException();
				
			}
			if (a.numerator>0)
			{
				return new Fraction_BigInteger_PositiveNatural3_(a.denominator.toBigint(), new PositiveNatural_inheritNatural(a.numerator));
				
			}
			
				return new Fraction_BigInteger_PositiveNatural3_(-a.denominator.toBigint(), (a.numerator));
				
			
		}

		static public Fraction_BigInteger_PositiveNatural3_ AddAndSimplify(Fraction_BigInteger_PositiveNatural3_ a,Fraction_BigInteger_PositiveNatural3_ b) {


			Fraction_BigInteger_PositiveNatural3_ r=new Fraction_BigInteger_PositiveNatural3_(a.numerator*b.denominator.toBigint()+a.denominator.toBigint()*b.numerator,a.denominator.toBigint()*b.denominator.toBigint());
			r.simplify();

			return r;
		
		}

		

		static public Fraction_BigInteger_PositiveNatural3_ AddAndSimplify(Fraction_BigInteger_PositiveNatural3_ a, int b)
		{
			return AddAndSimplify(a, new Fraction_BigInteger_PositiveNatural3_(b, 1));

		}

		static public Fraction_BigInteger_PositiveNatural3_ AddAndSimplify(Fraction_BigInteger_PositiveNatural3_ a, long b)
		{
			return AddAndSimplify(a, new Fraction_BigInteger_PositiveNatural3_(b, 1));

		}

		static public Fraction_BigInteger_PositiveNatural3_ AddAndSimplify(long a,Fraction_BigInteger_PositiveNatural3_  b)
		{
			return AddAndSimplify(b, a);

		}
		/// <summary>
		/// to parse a string as fraction
		/// </summary>
		/// <param name="s"></param>
		/// <returns></returns>
		static public Fraction_BigInteger_PositiveNatural3_ Parse(string s) {

			///first find the /
			///
			/// 
			string[] terms= s.Split(nilnul.num.rational.Divide.Sign);
			if (terms.Length!=2)
			{
				throw new Exception(string.Format("There are more than two terms sperated by {0}.",nilnul.num.rational.Divide.Sign));
				
			}

			return new Fraction_BigInteger_PositiveNatural3_(BigInteger.Parse(terms[0]), BigInteger.Parse(terms[1]));


			/// 
			///first is it an integer?
			///

 

		
		}


		public RationalI eval()
		{
			return this;
		}

		public bool Equals(Fraction2 other)
		{
			var a = Reduce(this);
			var b = Reduce(other);

			return a.numerator == b.numerator &&  a.denominator == b.denominator;
		}
	}
}
