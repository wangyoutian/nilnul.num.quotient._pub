using nilnul.bit;
using nilnul.num.natural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.rational.float_
{
	public partial class SignificandIndex
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
		public SignificandIndex(BigInteger s, BigInteger i)
		{
			this._significand = s;
			this._index = i;

		}
		public SignificandIndex(
			SignificandIndex si
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

		public SignificandIndex toNegate()
		{
			var r = new SignificandIndex(this);
			r.negate();
			return r;

		}




		static public SignificandIndex Subtract(
			BigInteger radix_plural,
			SignificandIndex a,

			SignificandIndex b

		)
		{

			return _Add(radix_plural, a, b.toNegate());



		}



	

		static public SignificandIndex _Add(BigInteger radix_plural,

			SignificandIndex a, SignificandIndex b
		)
		{

			if (b.index < a.index)
			{
				return _Add_smallerFirst(radix_plural, b, a);
			}
			return _Add_smallerFirst(radix_plural, a, b);


			throw new NotImplementedException();

		}



		static public SignificandIndex _Add_smallerFirst(BigInteger radix_plural, SignificandIndex _powerSmaller, SignificandIndex powerMax)
		{


			var t = powerMax.index - _powerSmaller.index;

			return new SignificandIndex(


				powerMax.significand * nilnul.num.natural.op.PowX2.Do_basePlural_indexNonNeg(radix_plural, t) + _powerSmaller.significand
				,
				_powerSmaller.index

			);

			throw new NotImplementedException();

		}








	}
}