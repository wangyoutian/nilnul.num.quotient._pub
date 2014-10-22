using nilnul.bit;
using nilnul.num.natural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using SI=nilnul.num.rational.float_.SignificandIndex;

namespace nilnul.num.rational.float_
{
	public partial class Float<TPluralSingleton>
		:Float3
		where TPluralSingleton:nilnul.num.natural.Plural2.Noun,new()
	{
		static public TPluralSingleton Base=SingletonByDefaultNew<TPluralSingleton>.Instance;


		public Float(
			SI si

			)
			:base(
				Base.val.val
			,si
			)
		{

		}
		public Float3(BigInteger base_, SignificandIndex si)
			: this(new natural.rel.Plural.BigInt.Asserted(base_), si)
		{

		}
		public Float3(BigInteger radix)
			: this(radix, 0)
		{


		}
		public Float3()
			: this(2)
		{

		}
		public Float3(
			BigInteger base_,
			BigInteger significand,
			BigInteger index
			)
			: this(base_, new SignificandIndex(significand, index))
		{

		}

		public Float3(
			Float3 other
			)
			: this(other.base_.val, other._significandIndex.significand, other._significandIndex.index)
		{

		}
		public Float3(BigInteger radix, BigInteger significand)
			: this(radix, significand, 0)
		{

		}

		public void reduce()
		{
			if (significand == 0)
			{
				index = 0;
			}

			BigInteger remainder;
			var q = BigInteger.DivRem(significand, baseAsBigInt, out remainder);

			while (remainder == 0)
			{
				significand = q;
				index++;

				q = BigInteger.DivRem(significand, baseAsBigInt, out remainder);

			}
		}

		public void appendZero()
		{
			significand *= _base.val;
			index--;
		}

		public void appendOne()
		{
			appendZero();
			significand++;
		}

		public void append(BigInteger digits)
		{



		}

		public nilnul.num.natural.collection.Interval digits()
		{
			return new natural.collection.Interval(baseAsBigInt);
		}

		public void assertIsDigit(BigInteger digit)
		{

			AssertX.True(digits().contains(new Natural2(digit)));

		}

		public void morePrecision(BigInteger siginificandNewLastDigit)
		{

			assertIsDigit(siginificandNewLastDigit);

			significand = significand * baseAsBigInt + siginificandNewLastDigit;

			index -= 1;

		}

		public Float3 toMorePresion(
	BigInteger siginificandNewLastDigit

	)
		{

			var r = new Float3(this);

			r.morePrecision(siginificandNewLastDigit);
			return r;

		}





		public Float3 toReduce()
		{
			var r = new Float3(this);
			r.reduce();
			return r;
		}


		public override string ToString()
		{
			return toStr_linear_0_prepended2();
		}

		public string toStr_exp()
		{
			var r = significand.ToString();	//todo: this need to be based on base.
			return r + "*" + this.baseAsBigInt.ToString() + "^" + this.index.ToString();

		}

		public string toStr_func()
		{
			return string.Format("nilnul.num.rational.float_.Float3({0},{1},{2})", baseAsBigInt, significand, index);


		}

		public string toStr_linear()
		{
			var r = significand.ToString();	//todo: this need to be based on base.

			var counter = index;
			if (index == 0)
			{
				return r;

			}
			if (index > 0)
			{

				r += nilnul.obj.str.X.Repeat(0, index);

				return r;
			}
			var significandLength = r.Length;
			var offset = significandLength + index;

			if (offset <= 0)
			{
				r = "." + nilnul.obj.str.X.Repeat(0, -(offset)) + significand;
				return r;


			}
			if (offset == 0)
			{
				return r;

			}
			//offset >0.

			return r.Insert((int)(offset), ".");	//todo:biginteger

		}

		public string toStr_linear_no0_intFirst_()
		{

			var r = significand.ToString();	//todo: this need to be based on base.
			var counter = index;
			if (index == 0)
			{
				return r;

			}
			if (index > 0)
			{

				r += nilnul.obj.str.X.Repeat(0, index);

				return r;
			}

			var significandLength = r.Length;
			var offset = significandLength + index;

			if (offset <= 0)
			{
				r = "." + nilnul.obj.str.X.Repeat(0, -(offset)) + significand;
				return r;


			}
			if (offset == 0)
			{
				return r;

			}
			//offset >0.

			return r.Insert((int)(offset), ".");	//todo:biginteger

		}


		public string toStr_linear_no_0_prepend()
		{
			var r = magnitudeAsBigInt.ToString();	//todo: this need to be based on base.
			var counter = index;
			if (index == 0)
			{
				return sign < 0 ? "-" : "" + r;

			}
			if (index > 0)
			{

				r += nilnul.obj.str.X.Repeat(0, index);

				return sign < 0 ? "-" : "" + r;
			}

			var magniLength = r.Length;
			var offset = magniLength + index;

			if (offset <= 0)
			{
				r = "." + nilnul.obj.str.X.Repeat(0, -(offset)) + r;
				return sign < 0 ? "-" : "" + r;


			}
			if (offset == 0)
			{
				return sign < 0 ? "-" : "" + r;

			}
			//offset >0.

			return sign < 0 ? "-" : "" + r.Insert((int)(offset), ".");	//todo:biginteger

		}

		public string toStr_linear_0_prepended()
		{

			var r = magnitudeAsBigInt.ToString();	//todo: this need to be based on base.

			var counter = index;

			if (index == 0)
			{
				return (sign < 0 ? "-" : "") + r;

			}
			if (index > 0)
			{

				r += nilnul.obj.str.X.Repeat(0, index);

				return (sign < 0 ? "-" : "") + r;
			}

			var significandLength = r.Length;
			var offset = significandLength + index;

			if (offset <= 0)
			{
				r = "0." + nilnul.obj.str.X.Repeat(0, -(offset)) + r;
				return (sign < 0 ? "-" : "") + r;


			}
			if (offset == 0)
			{
				return (sign < 0 ? "-" : "") + r;

			}
			//offset >0.

			return (sign < 0 ? "-" : "") + r.Insert((int)(offset), ".");	//todo:biginteger

		}


		public string toStr_linear_0_prepended2()
		{

			var r = nilnul.num.natural.op.ToStrX.Do(magnitudeAsBigInt, baseAsBigInt);
			var counter = index;
			if (index == 0)
			{
				return (sign < 0 ? "-" : "") + r;
			}
			if (index > 0)
			{
				r += nilnul.obj.str.X.Repeat(0, index);
				return (sign < 0 ? "-" : "") + r;
			}

			var significandLength = r.Length;
			var offsetOfDot = significandLength + index;

			if (offsetOfDot <= 0)
			{
				r = "0." + nilnul.obj.str.X.Repeat(0, -(offsetOfDot)) + r;
				return (sign < 0 ? "-" : "") + r;

			}
			if (offsetOfDot == 0)
			{
				return (sign < 0 ? "-" : "") + r;
			}
			return (sign < 0 ? "-" : "") + r.Insert((int)(offsetOfDot), ".");

		}

		public Rational_InheritFraction2 toRational(
   )
		{

			return (significand) * nilnul.num.rational.op.PowX.Eval_basePlural2(_base.val, index)
			;


		}





		static public Float3 FroRational(
			BigInteger radix_plural,
			Rational_InheritFraction rational
			,
			natural.Natural_bigInteger digits
		)
		{


			var intFrac = rational.ToIntAndProper();

			BigInteger quotient = intFrac.Item1;
			BigInteger remainder = intFrac.Item2.numerator;



			BigInteger index = 0;



			while (digits > 0)
			{

				quotient = quotient * radix_plural + BigInteger.DivRem(remainder * radix_plural, rational.denominatorAsBigInt, out remainder);
				digits--;
				index--;

			}
			return new Float3(radix_plural, quotient, index);

			throw new NotImplementedException();
		}






		static public Float3 Multi(
				BigInteger radix_plural,
				SignificandIndex significandIndex1
				,
				SignificandIndex significandIndex2



				)
		{
			return new Float3(radix_plural, significandIndex1.significand * significandIndex2.significand, significandIndex1.index + significandIndex2.index);


			throw new NotImplementedException();
		}

		static public Float3 Square(Float3 a

			)
		{
			return Multi(a.baseAsBigInt, a._significandIndex, a.significandIndex);
		}

		public Float3 toSquare()
		{
			return Square(this);
		}

		public void negate()
		{
			this.significand = -this.significand;

		}

		static public Float3 Negate(
		   Float3 a
			)
		{

			var b = new Float3(a);
			b.negate();
			return b;


		}

		static public Float3 _Subtract(
			BigInteger radix_plural,
			SignificandIndex a,

			SignificandIndex b

			)
		{

			return _Add(radix_plural, a, b.toNegate());



		}
		static public Float3 Subtract(
			BigInteger radix_plural,
			SignificandIndex a,

			SignificandIndex b

			)
		{

			return _Add(radix_plural, a, b.toNegate());



		}

		static public Float3 _Add(

			BigInteger radix_plural,
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

		static public Float3 _Add_smallerFirst(BigInteger radix_plural, SignificandIndex _powerSmaller, SignificandIndex powerMax)
		{


			var t = powerMax.index - _powerSmaller.index;

			return new Float3(
				radix_plural
				,

				powerMax.significand * nilnul.num.natural.op.PowX2.Do_basePlural_indexNonNeg(radix_plural, t) + _powerSmaller.significand
				,
				_powerSmaller.index

			);

			throw new NotImplementedException();

		}





		public partial class Radix
		{

			static public Float2 Multi(
				BigInteger radix,
				SignificandIndex significandIndex1
				,
				SignificandIndex significandIndex2



				)
			{


				throw new NotImplementedException();
			}



		}

	}
}
