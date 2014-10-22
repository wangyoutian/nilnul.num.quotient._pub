using nilnul.num.rational.float_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.rational.bicemal
{
	/// <summary>
	/// b*2^e
	/// </summary>
	public partial class Binary 
		:Float3
	{

		public Binary(BigInteger significand, BigInteger _power)
			:base(2,significand,_power)
		{

		}

		public Binary(BigInteger significand)
			:this(significand,0)
		{

		}

		public Binary()
			:base()
		{

		}
		

		static public Binary Multi(
			Binary a,
			Binary b
			) {
				var f= Float3.Multi(2, a.significandIndex, b.significandIndex);
				return new Binary(f.significand, f.index);
		
		}

		static public Binary operator *(Binary a,Binary b){

			return Multi(a, b);
		
		}

		static public Binary Subtract(
			Binary a,
			Binary b
			) {
				var f = Float3._Subtract(2, a.significandIndex, b.significandIndex);
				return new Binary(f.significand, f.index);
		
		}

		static public Binary operator -(Binary a,Binary b){
			return Subtract(a, b);
		
		}

		static public Binary Add(
			Binary a,
			Binary b
			
		) {
			var f = Float3._Add(2, a.significandIndex, b.significandIndex);
			return new Binary(f.significand, f.index);
		
		}


		static public Binary Add(BigInteger a,Binary b) {
			return Add(new Binary(a), b);
		
		}


		static public Binary operator +(
			BigInteger a, Binary b
			
			){
				return Add(a, b);
		
		}


		static public Binary Square(Binary a) {
			return Multi(a, a);
		}

		static public bool Lt(Binary a, Binary b)
		{
			return (a - b).sign < 0;
		}

		static public bool Le(Binary a, Binary b)
		{
			return (a - b).sign <= 0;
		}
		static public bool Gt(Binary a, Binary b)
		{
			return (a - b).sign > 0;
		}
		static public bool Ge(Binary a, Binary b)
		{
			return (a - b).sign >= 0;
		}
		static public bool Eq(Binary a, Binary b)
		{
			return (a - b).sign == 0;
		}

		static public bool operator <(Binary a, Binary b)
		{
			return Lt(a, b);
		}
		static public bool operator <(Binary a, int b)
		{
			return Lt(a, new Binary( b));
		}

		static public bool operator >(Binary a, int b)
		{
			return Gt(a, new Binary(b));
		}

		static public bool operator <=(Binary a, Binary b)
		{
			return Le(a, b);
		}
		static public bool operator >(Binary a, Binary b)
		{
			return Gt(a, b);
		}
		static public bool operator >=(Binary a, Binary b)
		{
			return Ge(a, b);
		}
		static public bool operator ==(Binary a, Binary b)
		{
			return Eq(a, b);
		}
		static public bool operator !=(Binary a, Binary b)
		{
			return !Eq(a, b);
		}



	

		


	


	}
}
