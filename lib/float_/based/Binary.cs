using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.rational.float_.based
{
	/// <summary>
	/// b*2^e
	/// </summary>
	public partial class Binary 
		:Based<natural.be.plural.bigint.asserted.Two>
	
	{
		static public Binary FroRational(
			Rational_InheritFraction2 rational,
			BigInteger digits
			) {
				Based2 based= FroRational(2, rational,  digits);

				return new Binary(based.significand, based.index);
		
		}
		

		public Binary(BigInteger significand, BigInteger _power)
			: base(significand,  _power)
		{

		}

		public Binary(Float float_)
			:this(float_.significand,float_.index)
		{

		}
		public Binary(BigInteger significand)
			:this(significand,0)
		{

		}

		public Binary(Binary x)
			:this(x.significand,x.index)
		{

		}
		public Binary()
			:this(0)
		{

		}

		public Binary toSquare() {

			return Square(this);
		
		}



	
		static public Binary Negate(Binary a)
		{

			return new Binary(-a.significand, a.index);

		}

		static public Binary operator +(Binary a, Binary b)
		{

			
			return Add(a, b);



		}

		static public Binary operator *(Binary a,Binary b){

			return Multi(a, b);
		
		}

	
	


	

		static public Binary Multi(
			Binary a,
			Binary b
			)
		{
			var f = Based<natural.be.plural.bigint.asserted.Two>.Multi( a, b);
			return new Binary(f.significand, f.index);

		}

		static public Binary Subtract(
			Binary a,
			Binary b
			)
		{
			var f = Based<natural.be.plural.bigint.asserted.Two>.Subtract(a, b);
			return new Binary(f.significand, f.index);

		}

		static public Binary Add(
			Binary a,
			Binary b

		)
		{
			var f = Based<natural.be.plural.bigint.asserted.Two>.Add(a, b);
			return new Binary(f.significand, f.index);

		}

		static public Binary Square(Binary a)
		{
			return Multi(a, a);
		}

		static public bool Lt(Binary a, Binary b)
		{
			return bi.Comparer.Lt.Singleton.Instance.contains(a, b);
			throw new NotImplementedException();
		}

		static public bool operator <(Binary a,Binary b){
			return Lt(a, b);
		}

		static public bool Le(Binary a, Binary b) {
			return bi.Comparer.Le.Singleton.Instance.contains(a, b);
		}
		static public bool operator <=(Binary a, Binary b) {
			return Le(a, b);
		}

		static public bool Gt(Binary a, Binary b) {
			return bi.Comparer.Gt.Singleton.Instance.contains(a, b);
		}
		static public bool operator >(Binary a, Binary b) {
			return Gt(a, b);
		}

		static public bool Ge(Binary a, Binary b) {
			return bi.Comparer.Ge.Singleton.Instance.contains(a, b);
		}
		static public bool operator >=(Binary a,Binary b){
			return Ge(a, b);
		}

		static public bool Eq(Binary a, Binary b) { 
			return bi.Comparer.Eq.Singleton.Instance.contains(a,b);
			
		}

		static public bool operator ==(Binary a, Binary b) {
			return Eq(a, b);
		}

		static public bool operator !=(Binary a, Binary b) {
			return bi.Comparer.Ne.Singleton.Instance.contains(a, b);
		
		}



	




		public RationalI eval()
		{
			throw new NotImplementedException();
		}
	}
}
