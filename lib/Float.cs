using nilnul.bit;
using nilnul.num.natural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.rational
{
	public class Float
	{
		private BigInteger _significand;

		public BigInteger significand
		{
			get { return _significand; }
			set { _significand = value; }
		}
		private BigInteger _index;

		public BigInteger index
		{
			get { return _index; }
			set { _index = value; }
		}
		public Float(BigInteger s, BigInteger i)
		{
			this._significand = s;
			this._index = i;

		}
		public Float(BigInteger significand)
			:this(significand,0)
		{

		}
		public Float(
			Float si
			)
			: this(si._significand, si._index)
		{

		}

		public int signAsInt
		{
			get { return significand.Sign; }
		}



		public void negate()
		{
			_significand = -_significand;
		}

		public Float toNegate()
		{
			var r = new Float(this);
			r.negate();
			return r;

		}

		static public Float Square(Float a) {
			return new Float(a._significand * a._significand, a.index * 2);
		}




		static public Float Subtract(
			BigInteger radix_plural,
			Float a,

			Float b

		)
		{

			return _Add(radix_plural, a, b.toNegate());



		}



	

		static public Float _Add(BigInteger radix_plural,

			Float a, Float b
		)
		{

			if (b.index < a.index)
			{
				return _Add_smallerFirst(radix_plural, b, a);
			}
			return _Add_smallerFirst(radix_plural, a, b);


			throw new NotImplementedException();

		}



		static public Float _Add_smallerFirst(BigInteger radix_plural, Float _powerSmaller, Float powerMax)
		{


			var t = powerMax.index - _powerSmaller.index;

			return new Float(


				powerMax.significand * nilnul.num.natural.op.PowX2.Do_basePlural_indexNonNeg(radix_plural, t) + _powerSmaller.significand
				,
				_powerSmaller.index

			);

			throw new NotImplementedException();

		}








	}
}