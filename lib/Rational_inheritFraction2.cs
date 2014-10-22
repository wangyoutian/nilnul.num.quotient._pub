using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.natural;
using Fraction=nilnul.num.rational.Fraction_BigInteger_PositiveNatural3_;

namespace nilnul.num.rational
{
	/// <summary>
	/// coprime.
	/// </summary>
	public partial class Rational_InheritFraction2
		:Fraction_BigInteger_PositiveNatural3_
		,
		IComparable<Rational_InheritFraction2>
		,IEquatable<Rational_InheritFraction2>
	{
		private void _setNumerator(BigInteger numerator) {

			this.numerator = numerator;
			
		}

		private void _setDenominator(PositiveNatural_inheritNatural denominator)
		{

			this.denominator = denominator;

		}
		private void _setDenominator()
		{

			this.denominator = new PositiveNatural_inheritNatural( 1);

		}

		public void abs()
		{
			this.numerator = BigInteger.Abs(numerator);
		}
		public Rational_InheritFraction2 asAbs()
		{
			this.numerator = BigInteger.Abs(numerator);
			return this;
		}

		public Rational_InheritFraction2 toAbs() {
			var r = new Rational_InheritFraction2(this);
			r.abs();
			return r;
		}

		public Rational_InheritFraction2 clone() {
			return new Rational_InheritFraction2(this);
		}

		public void inverse() {

			var oldNumerator = numerator1;

			if (numerator <= 0)
			{
				_setNumerator(-denominator.val);
				_setDenominator(new PositiveNatural_inheritNatural(- oldNumerator));

			}
			else
			{
				_setNumerator(denominator);
				_setDenominator(new PositiveNatural_inheritNatural(oldNumerator));
			}


		
		
		}

		public Rational_InheritFraction2 toInverse()
		{

			return ToInverse(this);



		}



		#region ctor

		private Rational_InheritFraction2(BigInteger numerator, PositiveNatural_inheritNatural denominator)
			:base(numerator,denominator)
		{
			simplify();

		}
		public BigInteger denominatorAsBigInt { get {
			return denominator.val;
		} }

		public Tuple<BigInteger, Rational_InheritFraction2> ToIntAndProper()
		{
			BigInteger remainder;
			var quotient = BigInteger.DivRem(this.numerator, this.denominatorAsBigInt, out remainder);
			return new Tuple<BigInteger, Rational_InheritFraction2>(
				quotient,
				new Rational_InheritFraction2(remainder, this.denominatorAsBigInt)
			);

		}
		static public Tuple<BigInteger, Rational_InheritFraction2> ToIntAndProper1(Rational_InheritFraction2 x)
		{
			BigInteger remainder;
			var quotient = BigInteger.DivRem(x.numerator, x.denominatorAsBigInt, out remainder);
			return new Tuple<BigInteger, Rational_InheritFraction2>(
				quotient,
				new Rational_InheritFraction2(remainder, x.denominatorAsBigInt)
			);

		}

		private Rational_InheritFraction2(PositiveNatural_inheritNatural numerator, BigInteger denominator)
			:base(numerator,denominator)
		{

		}

		public Rational_InheritFraction2(BigInteger numerator, BigInteger denominator)
			: base(numerator, denominator)
		{
			simplify();

		}






		static internal Rational_InheritFraction2 _Create_fromSimplified(BigInteger numerator,BigInteger denominator) {

			return new Rational_InheritFraction2(numerator, denominator);
		
		}

		public Rational_InheritFraction2(PositiveNatural3 numerator)
			
		{
			_setNumerator(numerator.val);
			_setDenominator();

		}


		public Rational_InheritFraction2(Fraction_BigInteger_PositiveNatural3_ fraction)
			: base(fraction.numerator, fraction.denominator)
		{

			simplify();


		}

		public Rational_InheritFraction2(PositiveNatural_inheritNatural numerator)
			: base(numerator)
		{

		}




		public Rational_InheritFraction2(int numerator)
			:base(numerator)
		{
		}

		public Rational_InheritFraction2(int a, int b)
			:this((BigInteger)(a),(BigInteger)(b))
		{

		}



		public Rational_InheritFraction2(uint numerator)
			: base(numerator)
		{
		}
		public Rational_InheritFraction2(BigInteger numerator)
			: base(numerator)
		{
		}


		public Rational_InheritFraction2(Natural2 a)
			:base(a)
		{
		}

		public Rational_InheritFraction2(Rational_InheritFraction2 r)
		{
			_setNumerator(r.numerator);
			_setDenominator(r.denominator);

		}
					

		
					
					



		public Rational_InheritFraction2()
			: base()
		{
		}

				

	
		
			#endregion

	

		#region static

		static public readonly Rational_InheritFraction2 Zero = new Rational_InheritFraction2();
		static public readonly Rational_InheritFraction2 One = new Rational_InheritFraction2(1);

		static public Rational_InheritFraction2 NewZero {
			get {
				return new Rational_InheritFraction2();
			}
		}
		static public Rational_InheritFraction2 NewOne {
			get {
				return new Rational_InheritFraction2(1);
			}
		}

		static public Rational_InheritFraction2 CreateHalf() {
			return new Rational_InheritFraction2(1, 2);
		}
		static public Rational_InheritFraction2 Create(int i)
		{
			return new Rational_InheritFraction2(i);
		}
		static public Rational_InheritFraction2 Create(BigInteger n,BigInteger d)
		{
			return new Rational_InheritFraction2(n,d);
		}

		static public Rational_InheritFraction2 Add(Rational_InheritFraction2 a,Rational_InheritFraction2 b) {

			return Reduce(

				Fraction_BigInteger_PositiveNatural3_.Add(a,b)
			
			);


			
		}

		



		static public Rational_InheritFraction2 Multiply(Rational_InheritFraction2 a, Rational_InheritFraction2 b)
		{

			return Reduce(

				Fraction_BigInteger_PositiveNatural3_.Multiply(a, b)

			);



		}

		static public Rational_InheritFraction2 Multi(BigInteger a,Rational_InheritFraction2 b) {
			return new Rational_InheritFraction2(a*b.numerator,b.denominator);
		
		
		}

		static public Rational_InheritFraction2 operator *(Rational_InheritFraction2 a,Rational_InheritFraction2 b){
			return Multiply(a, b);
		}

		static public Rational_InheritFraction2 operator *(BigInteger a, Rational_InheritFraction2 b)
		{
			return Multi(a, b);
		}

		static public Rational_InheritFraction2 operator *(int a, Rational_InheritFraction2 b)
		{
			return Multi(a, b);
		}



		static public Rational_InheritFraction2 operator /(Rational_InheritFraction2 a, Rational_InheritFraction2 b)
		{

			return Divide(a, b);

		}

		static public Rational_InheritFraction2 operator /(Rational_InheritFraction2 a, natural.Natural_bigInteger b)
		{

			return Divide(a, b);

		}
		static public Rational_InheritFraction2 Divide(int a, natural.Natural_bigInteger b)
		{

			return Divide((Rational_InheritFraction2)a, b);

		}

		static public implicit operator Rational_InheritFraction2(natural.Natural_bigInteger n)
		{
			return new Rational_InheritFraction2(n.val);
		}

		static public  Rational_InheritFraction2 Divide(Rational_InheritFraction2 a, Rational_InheritFraction2 b)
		{

			return Reduce(

				Fraction_BigInteger_PositiveNatural3_.Divide(a, b)

			);
		}

		static public Rational_InheritFraction2 Divide(BigInteger a,Rational_InheritFraction2 b) {
			throw new NotImplementedException();
		
		}
		static public Rational_InheritFraction2 Divide(Natural2 a, Natural2 b)
		{

			return Divide(new Rational_InheritFraction2(a),new Rational_InheritFraction2(b));



		}

		static public Rational_InheritFraction2 Divide(Natural_bigInteger a, Natural_bigInteger b)
		{

			return Divide(new Rational_InheritFraction2(a.val), new Rational_InheritFraction2(b.val));



		}

		static public Rational_InheritFraction2 Divide(int a, Natural2 b)
		{

			return Divide(new Rational_InheritFraction2(a), new Rational_InheritFraction2(b));



		}
		static public Rational_InheritFraction2 Divide(uint a, Natural2 b)
		{

			return Divide(new Rational_InheritFraction2(a), new Rational_InheritFraction2(b));



		}
		static public Rational_InheritFraction2 Divide(BigInteger a, BigInteger b)
		{



			return Divide(new Rational_InheritFraction2(a), new Rational_InheritFraction2(b));



		}

		static public Rational_InheritFraction2 Inverse(BigInteger a) {
			return Divide(1, a);
		}

		static public Rational_InheritFraction2 Divide2(BigInteger a, BigInteger b)
		{



			return new Rational_InheritFraction2(a, b);



		}

		static public Rational_InheritFraction2 Divide2(int a, BigInteger b)
		{

			return new Rational_InheritFraction2(a, b);
		}



		static public Rational_InheritFraction2 Divide2(Rational_InheritFraction2  a, BigInteger b)
		{



			return Divide(a, new Rational_InheritFraction2( b));



		}

		static public Rational_InheritFraction2 operator +(Rational_InheritFraction2 a, Rational_InheritFraction2 b)
		{
			return Add(a, b);
		}

		static public Rational_InheritFraction2 operator +(Rational_InheritFraction2 a, Natural2 b)
		{
			return Add(a,
				
				new Rational_InheritFraction2(b)
				
				);
		}
		static public bool GreaterThan(Rational_InheritFraction2 a, Rational_InheritFraction2 b)
		{

			return (a - b).sign > 0;

		}

		static public bool Gt(Rational_InheritFraction2 a, PositiveNatural3 b)
		{

			return (a - b).sign > 0;

		}

		static public bool operator >(Rational_InheritFraction2 a, Rational_InheritFraction2 b)
		{
			return GreaterThan(a, b);
		}
		static public bool GreaterThanOrEqualTo(Rational_InheritFraction2 a,Rational_InheritFraction2 b) {
			return (a - b).sign >= 0;
 
		
		}

		static public bool operator >=(Rational_InheritFraction2 a, Rational_InheritFraction2 b)
		{
			return GreaterThanOrEqualTo(a, b);
		}

		static public bool LessThanOrEqualTo(Rational_InheritFraction2 a, Rational_InheritFraction2 b)
		{
			return (a - b).sign <= 0;


		}

		static public bool operator <=(Rational_InheritFraction2 a, Rational_InheritFraction2 b)
		{
			return LessThanOrEqualTo(a, b);
		}



		static public bool LessThan(Rational_InheritFraction2 a, Rational_InheritFraction2 b)
		{
			return (a - b).sign < 0;
		}
		static public bool LessThan(Rational_InheritFraction2 a, PositiveNatural3 b)
		{
			return (a - b).sign < 0;
		}
		static public bool operator <(Rational_InheritFraction2 a, Rational_InheritFraction2 b)
		{
			return LessThan(a, b);
		}
		static public bool operator <(Rational_InheritFraction2 a, PositiveNatural3 b)
		{
			return LessThan(a, b);
		}
		static public bool operator >(Rational_InheritFraction2 a, PositiveNatural3 b)
		{
			return Gt(a, b);
		}
		static public implicit operator Rational_InheritFraction2(Natural2 n)
		{
			return new Rational_InheritFraction2(n);
		}

		static public bool operator ==(Rational_InheritFraction2 a, Rational_InheritFraction2 b)
		{

			return Equals(a, b);

		}
		static public bool operator !=(Rational_InheritFraction2 a, Rational_InheritFraction2 b)
		{

			return !Equals(a, b);

		}



		static public bool Equals(Rational_InheritFraction2 a, Rational_InheritFraction2 b)
		{

			return a.numerator == b.numerator && a.denominator == b.denominator;

		}
		static public bool NotEquals(Rational_InheritFraction2 a, Rational_InheritFraction2 b)
		{

			return !Equals(a,b);

		}



		static public implicit operator Rational_InheritFraction2(int u)
		{
			return new Rational_InheritFraction2(u);
		}
		static public implicit operator Rational_InheritFraction2(BigInteger u)
		{
			return new Rational_InheritFraction2(u);
		}

		static public Rational_InheritFraction2 Inverse(Rational_InheritFraction2 rational)
		{
			var r = new Rational_InheritFraction2(rational);
			r.inverse();
			return r;




		}

		static public Rational_InheritFraction2 ToInverse(Rational_InheritFraction2 rational)
		{
			var r = new Rational_InheritFraction2(rational);
			r.inverse();
			return r;




		}


					

		static public Rational_InheritFraction2 Add(PositiveNatural_inheritNatural a, Rational_InheritFraction2 b)
		{

			return Add( new Rational_InheritFraction2( a), b);



		}

		static public Rational_InheritFraction2 operator -(Rational_InheritFraction2 a, Rational_InheritFraction2 b)
		{
			return Subtract(a, b);

		}
		static public Rational_InheritFraction2 operator -(Rational_InheritFraction2 a, PositiveNatural3 b)
		{
			return Subtract(a, b);

		}
		static public Rational_InheritFraction2 operator -(Natural2 a, Rational_InheritFraction2 b)
		{
			return Subtract(a, b);

		}

		static public Rational_InheritFraction2 operator -( Rational_InheritFraction2 b)
		{
			return Negate(b);

		}



		static public Rational_InheritFraction2 Add(Fraction_BigInteger_PositiveNatural3_ a, Fraction_BigInteger_PositiveNatural3_ b) {

			return Add(new Rational_InheritFraction2(a), new Rational_InheritFraction2(b));
		}

		static public Rational_InheritFraction2 Subtract(Fraction_BigInteger_PositiveNatural3_ a, Fraction_BigInteger_PositiveNatural3_ b)
		{

			return Subtract(new Rational_InheritFraction2(a), new Rational_InheritFraction2(b));
		}


		static public Rational_InheritFraction2 Subtract(Rational_InheritFraction2 a, Rational_InheritFraction2 b)
		{

			return Add(new Rational_InheritFraction2(a), Rational_InheritFraction2.Negate(b));
		}
		static public Rational_InheritFraction2 Subtract(Rational_InheritFraction2 a, PositiveNatural3 b)
		{

			return Add(new Rational_InheritFraction2(a), Rational_InheritFraction2.Negate(b));
		}

		static public Rational_InheritFraction2 Negate(
			Rational_InheritFraction2 a
		)
		{

			var r = a.MemberwiseClone() as Rational_InheritFraction2;
			r.negate();
			return r;


		}
		static public Rational_InheritFraction2 ToNegate(
			Rational_InheritFraction2 a
		)
		{

			var r = a.MemberwiseClone() as Rational_InheritFraction2;
			r.negate();
			return r;


		}

		static public Rational_InheritFraction2 Negate(
			PositiveNatural3 a
		)
		{

			var r = new Rational_InheritFraction2(a);
			r.negate();
			return r;


		}

		public void negate()
		{

			numerator = -numerator;
		
		}

		public Rational_InheritFraction2 toNegate()
		{

			return new Rational_InheritFraction2(-this.numerator, this.denominator);

		}


		



		static public Rational_InheritFraction2 Reduce( Fraction_BigInteger_PositiveNatural3_ fraction)
		{



			///http://msdn.microsoft.com/en-us/library/vstudio/system.numerics.biginteger.greatestcommondivisor(v=vs.100).aspx
			///If the left and right parameters are non-zero numbers, the method always returns at least a value of 1 because all numbers can be divided by 1. If either parameter is zero, the method returns the absolute value of the non-zero parameter. If both values are zero, the method returns zero.

			return new Rational_InheritFraction2(fraction);

		}

		/// <summary>
		/// don't use this.
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		static public Rational_InheritFraction2 ToRational(double x) {
			return   cf.ContinuedFraction2.ToRational2(x);
		
		}

		static public Rational_InheritFraction2 ToRational_tillDenominator(double x,BigInteger denominatorToTill)
		{
			return cf.ContinuedFraction2.ToRational_tillDenominator2(x,denominatorToTill);

		}


		#endregion


		public int CompareTo(Rational_InheritFraction2 other)
		{
			return (int)((this - other).sign);
		}


		static public Rational_InheritFraction2 Parse(string s)
		{
			//
			var terms = s.Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries);

			if (terms.Length == 0)
			{
				throw new ArgumentException("empty string.");

			}
			if (terms.Length == 1)
			{
				return new Rational_InheritFraction2(BigInteger.Parse(terms[0]));


			}
			if (terms.Length == 2)
			{
				return new Rational_InheritFraction2(BigInteger.Parse(terms[0]), BigInteger.Parse(terms[1]));

			}
			throw new ArgumentException(string.Format("Only two terms are expected across the {0}", '/'));


		}

		



		public bool Equals(Rational_InheritFraction2 other)
		{
			return Rational_InheritFraction2.Equals(this,other);
		}
		// override object.Equals
		public override bool Equals(object obj)
		{
			//       
			// See the full list of guidelines at
			//   http://go.microsoft.com/fwlink/?LinkID=85237  
			// and also the guidance for operator== at
			//   http://go.microsoft.com/fwlink/?LinkId=85238
			//

			if (obj == null || GetType() != obj.GetType())
			{
				return false;
			}

			// TODO: write your implementation of Equals() here

			return Equals((Rational_InheritFraction2) obj);
			throw new NotImplementedException();
			//return base.Equals(obj);
		}

		// override object.GetHashCode
		public override int GetHashCode()
		{
			
			return  this.numerator.GetHashCode()^denominator.GetHashCode();
		}

		public override string ToString()
		{
//#if DEBUG

//			return string.Format("{0}({1})", base.ToString(), toDouble());
//#endif


			return base.ToString();
		}
	}
}
