using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit;
using nilnul.num.natural;
using nilnul.num.rational.float_.rel;

namespace nilnul.num.rational.float_
{
	/// <summary>
	/// s*b^p
	/// </summary>
	/// 
	/// <remark>
	/// note the decimal in .net also has acuracy issues.
	/// </remark>
	public partial class Float : RationalI, IEquatable<Float>
	{

		#region fields and properties

		private BigInteger _base;	///count

		public Plural base_
		{
			get { return new Plural(_base); }
			set { _base = value; }
		}



		BigInteger _significand;

		public BigInteger significand
		{
			get
			{
				return _significand;
			}
			set
			{
				_significand = value;
			}
		}
		BigInteger _power;

		public BigInteger power
		{
			get
			{
				return _power;
			}
			set
			{

				_power = value;

			}
		}

		#endregion

		#region ctor


		public Float(BigInteger significand, Plural base_, BigInteger power)
		{
			this._significand = significand;
			this.base_ = base_;
			this._power = power;

		}
		public Float(BigInteger significand, BigInteger _base, BigInteger power)
			: this(significand, new Plural(_base), power)
		{


		}


		public Float(BigInteger significand, BigInteger base_)
			: this(significand, base_, 0)
		{
		}


		public Float(Float other)
			: this(other.significand, other.base_, other.power)
		{
		}


		public Float(BigInteger significand)
			: this(significand, 2)
		{
		}
		public Float()
			: this(0)
		{
		}

		#endregion
		#region instance methods
		public override string ToString()
		{
			var r = significand.ToString();	//todo: this need to be based on base.
			var counter = power;
			if (power == 0)
			{
				return r;

			}
			if (power > 0)
			{
				
					r += nilnul_obj.str.X.Repeat(0, power);
				
				return r;
			}
			var significandLength = r.Length;
			var offset = significandLength + power;
			if (offset <= 0)
			{
				r = "."+nilnul_obj.str.X.Repeat(0, -(offset)) + significand  ;
				return r;


			}
			if (offset==0)
			{
				return r;
				
			}
			//offset >0.

			return r.Insert((int)(offset),".");	//todo:biginteger
			//return r;



		}

		/// <summary>
		/// 
		/// </summary>
		public Float reduce2()
		{
			if (_significand == 0)
			{
				_power = 0;
				return this;
			}
			BigInteger remainder;
			var q = BigInteger.DivRem(_significand, _base, out remainder);

			while (remainder == 0)
			{
				_significand = q;
				_power++;

				q = BigInteger.DivRem(_significand, _base, out remainder);

			}
			return this;

		}


		/// <summary>
		/// 
		/// </summary>
		public Float reduce()
		{
			if (_significand == 0)
			{
				_power = 0;
				return this;
			}

			while (_significand.IsEven)
			{
				_significand /= 2;
				_power++;

			}
			return this;

		}

		public Float negate()
		{
			_significand = -_significand;
			return this;
		}

		public Float negate2()
		{
			_significand = -_significand;
			return this;
		}

		public RationalI eval()
		{
			throw new NotImplementedException();
		}

		public bool Equals(Float other)
		{
			return FloatX.Eq(this, other);
		}

		public void morePrecision(BigInteger siginificandNewLastDigit)
		{

			assertIsDigit(siginificandNewLastDigit);

			significand = significand * base_ + siginificandNewLastDigit;

			power -= 1;

		}

		public Float toMorePresion(
			BigInteger siginificandNewLastDigit

			)
		{

			var r = new Float(this);

			r.morePrecision(siginificandNewLastDigit);
			return r;

		}

		public void assertIsDigit(BigInteger digit)
		{

			AssertX.True(digits().contains(new Natural2(digit)));

		}

		public nilnul.num.natural.collection.Interval digits()
		{
			return new natural.collection.Interval(base_);
		}

		#endregion

		#region static

		static public void AssertSameBase(Float x, Float y)
		{
			SameBaseX.AssertSameBase(x, y);

		}

		static public Float Negate(Float a)
		{

			return new Float(-a._significand, a.@base_, a._power);

		}

		static public Float Multiply(Float a, Float b)
		{
			nilnul.num.natural.relation.EqualX.Assert(a.@base_, b.@base_);
			return new Float(a._significand * b._significand, a.@base_, a._power + b._power).reduce2();

		}

		static public implicit operator Float(BigInteger a)
		{
			return new Float(a, 2, 0);
		}

		static public implicit operator Float(int a)
		{
			return new Float(a, 2, 0);
		}

		static public implicit operator Float(uint a)
		{
			return new Float(a, 2, 0);
		}
		static public implicit operator Float(Natural a)
		{
			return new Float(a, 2, 0);
		}
		static public implicit operator Float(Natural2 a)
		{
			return new Float(a, 2, 0);
		}
		static public implicit operator Float(Plural a)
		{
			return new Float(a, 2, 0);
		}



		static public Float operator *(Float a, Float b)
		{

			return Multiply(a, b);

		}

		static public Float operator *(Float a, Count b)
		{

			return Multiply(a, b);

		}



		static public Float Subtract(Float a, Float b)
		{
			return Add(a, b.negate());
		}
		static public Float operator +(Float a, Float b)
		{


			return Add(a, b);



		}
		static public Float operator -(Float a)
		{


			return (a.MemberwiseClone() as Float).negate2();



		}

		static public Float operator -(Float a, Float b)
		{


			return Add(a, -b);



		}

		static public Float Add(Float a, Float b)
		{
			nilnul.num.natural.relation.EqualX.Assert(a.@base_, b.@base_);

			a.reduce2();
			b.reduce2();
			if (a._power < b._power)
			{
				return _Add(b, a).reduce();
			}
			return _Add(a, b).reduce();



		}
		static private Float _Add(Float powerMax, Float _powerSmaller)
		{


			var t = powerMax.power - _powerSmaller.power;

			return new Float(powerMax._significand * nilnul.num.integer.PowX.Pow(powerMax.base_, t)+_powerSmaller.significand
				,
				powerMax.base_
				,
				_powerSmaller.power

				);

			//throw new NotImplementedException();

		}





		static public bool operator ==(Float a, Float b)
		{
			return FloatX.Eq(a, b);

		}
		static public bool operator !=(Float a, Float b)
		{
			return !(a == b);

		}

		static public bool operator <=(Float a, Float b)
		{
			AssertSameBase(a, b);

			var c = a - b;
			return c.significand <= 0;



		}


		static public bool operator <(Float a, Float b)
		{
			AssertSameBase(a, b);

			var c = a - b;
			return c.significand < 0;



		}

		static public bool operator >(Float a, Float b)
		{
			AssertSameBase(a, b);

			var c = a - b;
			return c.significand > 0;



		}

		static public bool operator >=(Float a, Float b)
		{
			AssertSameBase(a, b);

			var c = a - b;
			return c.significand >= 0;



		}
		#endregion

	}
}
