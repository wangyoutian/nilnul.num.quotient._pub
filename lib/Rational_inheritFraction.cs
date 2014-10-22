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
	public partial class Rational_InheritFraction
		:Fraction_BigInteger_PositiveNatural3_
		,
		IComparable<Rational_InheritFraction>
		,IEquatable<Rational_InheritFraction>
	{

		#region ctor




		public Rational_InheritFraction(BigInteger numerator, PositiveNatural_inheritNatural denominator)
			:base(numerator,denominator)
		{

			simplify();


		}
		public BigInteger denominatorAsBigInt { get {
			return denominator.val;
		} }

		public Tuple<BigInteger, Rational_InheritFraction> ToIntAndProper() {
			BigInteger remainder;
			var quotient = BigInteger.DivRem(this.numerator, this.denominatorAsBigInt, out remainder);
			return new Tuple<BigInteger, Rational_InheritFraction>(quotient, new Rational_InheritFraction(remainder, this.denominatorAsBigInt));

		}

		public Rational_InheritFraction(PositiveNatural_inheritNatural numerator, BigInteger denominator)
			:base(numerator,denominator)
		{
			simplify();

		}

		public Rational_InheritFraction(BigInteger numerator, BigInteger denominator)
			: base(numerator, denominator)
		{

			simplify();


		}






		static public Rational_InheritFraction _Create_fromSimplified(BigInteger numerator,BigInteger denominator) {

			return new Rational_InheritFraction(numerator, denominator);
		
		}


		public Rational_InheritFraction(Fraction_BigInteger_PositiveNatural3_ fraction)
			: base(fraction.numerator, fraction.denominator)
		{

			simplify();


		}

		public Rational_InheritFraction(PositiveNatural_inheritNatural numerator)
			: base(numerator)
		{




		}




		public Rational_InheritFraction(int numerator)
			:base(numerator)
		{
		}


		public Rational_InheritFraction(uint numerator)
			: base(numerator)
		{
		}
		public Rational_InheritFraction(BigInteger numerator)
			: base(numerator)
		{
		}


		public Rational_InheritFraction(Natural2 a)
			:base(a)
		{
		}
					

		
					
					



		public Rational_InheritFraction()
			: base()
		{
		}

				

	
		
			#endregion

	

		#region static

		static public readonly Rational_InheritFraction Zero = new Rational_InheritFraction();
		static public readonly Rational_InheritFraction One = new Rational_InheritFraction(1);

		static public Rational_InheritFraction NewZero {
			get {
				return new Rational_InheritFraction();
			}
		}
		static public Rational_InheritFraction NewOne {
			get {
				return new Rational_InheritFraction(1);
			}
		}
		static public Rational_InheritFraction Create(int i) {
			return new Rational_InheritFraction(i);
		}

		static public Rational_InheritFraction Add(Rational_InheritFraction a,Rational_InheritFraction b) {

			return Reduce(

				Fraction_BigInteger_PositiveNatural3_.Add(a,b)
			
			);


			
		}

		static public Rational_InheritFraction Multiply(Rational_InheritFraction a, Rational_InheritFraction b)
		{

			return Reduce(

				Fraction_BigInteger_PositiveNatural3_.Multiply(a, b)

			);



		}

		static public Rational_InheritFraction Multi(BigInteger a,Rational_InheritFraction b) {
			return new Rational_InheritFraction(a*b.numerator,b.denominator);
		
		
		}

		static public Rational_InheritFraction operator *(Rational_InheritFraction a,Rational_InheritFraction b){
			return Multiply(a, b);
		}

		static public Rational_InheritFraction operator *(BigInteger a, Rational_InheritFraction b)
		{
			return Multi(a, b);
		}



		static public Rational_InheritFraction operator /(Rational_InheritFraction a, Rational_InheritFraction b)
		{

			return Divide(a, b);

		}

		static public Rational_InheritFraction operator /(Rational_InheritFraction a, natural.Natural_bigInteger b)
		{

			return Divide(a, b);

		}
		static public Rational_InheritFraction Divide(int a, natural.Natural_bigInteger b)
		{

			return Divide((Rational_InheritFraction)a, b);

		}

		static public implicit operator Rational_InheritFraction(natural.Natural_bigInteger n)
		{
			return new Rational_InheritFraction(n);
		}


		static public  Rational_InheritFraction Divide(Rational_InheritFraction a, Rational_InheritFraction b)
		{

			return Reduce(

				Fraction_BigInteger_PositiveNatural3_.Divide(a, b)

			);



		}

		static public Rational_InheritFraction Divide(BigInteger a,Rational_InheritFraction b) {
			throw new NotImplementedException();
		
		}
		static public Rational_InheritFraction Divide(Natural2 a, Natural2 b)
		{

			return Divide(new Rational_InheritFraction(a),new Rational_InheritFraction(b));



		}

		static public Rational_InheritFraction Divide(Natural_bigInteger a, Natural_bigInteger b)
		{

			return Divide(new Rational_InheritFraction(a), new Rational_InheritFraction(b));



		}

		static public Rational_InheritFraction Divide(int a, Natural2 b)
		{

			return Divide(new Rational_InheritFraction(a), new Rational_InheritFraction(b));



		}
		static public Rational_InheritFraction Divide(uint a, Natural2 b)
		{

			return Divide(new Rational_InheritFraction(a), new Rational_InheritFraction(b));



		}
		static public Rational_InheritFraction Divide(BigInteger a, BigInteger b)
		{



			return Divide(new Rational_InheritFraction(a), new Rational_InheritFraction(b));



		}

		static public Rational_InheritFraction Divide2(BigInteger a, BigInteger b)
		{



			return new Rational_InheritFraction(a,b);



		}

		static public Rational_InheritFraction operator +(Rational_InheritFraction a, Rational_InheritFraction b)
		{
			return Add(a, b);
		}

		static public Rational_InheritFraction operator +(Rational_InheritFraction a, Natural2 b)
		{
			return Add(a,
				
				new Rational_InheritFraction(b)
				
				);
		}
		static public bool GreaterThan(Rational_InheritFraction a,Rational_InheritFraction b) {

			return (a - b).sign > 0;
		
		}

		static public bool operator >(Rational_InheritFraction a,Rational_InheritFraction b){
			return GreaterThan(a, b);
		}
		static public bool GreaterThanOrEqualTo(Rational_InheritFraction a,Rational_InheritFraction b) {
			return (a - b).sign >= 0;
 
		
		}

		static public bool operator >=(Rational_InheritFraction a, Rational_InheritFraction b)
		{
			return GreaterThanOrEqualTo(a, b);
		}

		static public bool LessThanOrEqualTo(Rational_InheritFraction a, Rational_InheritFraction b)
		{
			return (a - b).sign <= 0;


		}

		static public bool operator <=(Rational_InheritFraction a, Rational_InheritFraction b)
		{
			return LessThanOrEqualTo(a, b);
		}



		static public bool LessThan(Rational_InheritFraction a,Rational_InheritFraction b) { 
			return (a - b).sign < 0;
		}
		static public bool operator <(Rational_InheritFraction a, Rational_InheritFraction b)
		{
			return LessThan(a, b);
		}
		static public  implicit operator Rational_InheritFraction(Natural2 n){
			return new Rational_InheritFraction(n);
		}

		static public bool operator ==(Rational_InheritFraction a, Rational_InheritFraction b)
		{

			return Equals(a, b);

		}
		static public bool operator !=(Rational_InheritFraction a, Rational_InheritFraction b)
		{

			return !Equals(a, b);

		}



		static public bool Equals(Rational_InheritFraction a, Rational_InheritFraction b)
		{

			return a.numerator == b.numerator && a.denominator == b.denominator;

		}
		static public bool NotEquals(Rational_InheritFraction a, Rational_InheritFraction b)
		{

			return !Equals(a,b);

		}



		static public  implicit operator Rational_InheritFraction(int u){
			return new Rational_InheritFraction(u);
		}

		static public Rational_InheritFraction Inverse(Rational_InheritFraction rational)
		{

			return new Rational_InheritFraction(rational.denominator, rational.numerator);

		}
					

		static public Rational_InheritFraction Add(PositiveNatural_inheritNatural a, Rational_InheritFraction b)
		{

			return Add( new Rational_InheritFraction( a), b);



		}

		static public Rational_InheritFraction operator -(Rational_InheritFraction a, Rational_InheritFraction b)
		{
			return Subtract(a, b);

		}
		static public Rational_InheritFraction operator -(Natural2 a, Rational_InheritFraction b)
		{
			return Subtract(a, b);

		}

		static public Rational_InheritFraction Add(Fraction_BigInteger_PositiveNatural3_ a, Fraction_BigInteger_PositiveNatural3_ b) {

			return Add(new Rational_InheritFraction(a), new Rational_InheritFraction(b));
		}

		static public Rational_InheritFraction Subtract(Fraction_BigInteger_PositiveNatural3_ a, Fraction_BigInteger_PositiveNatural3_ b)
		{

			return Subtract(new Rational_InheritFraction(a), new Rational_InheritFraction(b));
		}


		static public Rational_InheritFraction Subtract(Rational_InheritFraction a, Rational_InheritFraction b)
		{

			return Add(new Rational_InheritFraction(a), Rational_InheritFraction.Negate(b));
		}

		static public Rational_InheritFraction Negate(
			Rational_InheritFraction a	
		) {

			var r = a.MemberwiseClone() as Rational_InheritFraction;
			r.negate();
			return r;

		
		}

		public void negate() {

			numerator = -numerator;
		
		}

		



		static public Rational_InheritFraction Reduce( Fraction_BigInteger_PositiveNatural3_ fraction)
		{



			///http://msdn.microsoft.com/en-us/library/vstudio/system.numerics.biginteger.greatestcommondivisor(v=vs.100).aspx
			///If the left and right parameters are non-zero numbers, the method always returns at least a value of 1 because all numbers can be divided by 1. If either parameter is zero, the method returns the absolute value of the non-zero parameter. If both values are zero, the method returns zero.

			return new Rational_InheritFraction(fraction);

		}

		/// <summary>
		/// don't use this.
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		static public Rational_InheritFraction ToRational(double x) {
			return   cf.ContinuedFraction2.ToRational(x);
		
		}

		static public Rational_InheritFraction ToRational_tillDenominator(double x,BigInteger denominatorToTill)
		{
			return cf.ContinuedFraction2.ToRational_tillDenominator(x,denominatorToTill);

		}


		#endregion


		public int CompareTo(Rational_InheritFraction other)
		{
			return (int)((this - other).sign);
		}

		



		public bool Equals(Rational_InheritFraction other)
		{
			return Rational_InheritFraction.Equals(this,other);
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

			return Equals((Rational_InheritFraction) obj);
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
#if DEBUG

			return string.Format("{0}({1})", base.ToString(), toDouble());
#endif
			return base.ToString();
		}
	}
}
