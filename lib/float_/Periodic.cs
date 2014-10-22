using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.rational.float_
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>recurring, cyclic, repeating, recurring...</remarks>
	public partial class Periodic
	{

		private Based2 _float;

		public Based2 float_
		{
			get { return _float; }
			set { _float = value; }
		}

		private nilnul.num.natural.Natural_bigInteger _recurSpan;
		public nilnul.num.natural.Natural_bigInteger recurSpan
		{
			get { return _recurSpan; }
			set { _recurSpan = value; }
		}


		public BigInteger significand
		{
			get
			{

				return _float.significand;

			}
		}

		public BigInteger radixAsBigInt
		{
			get
			{
				return _float.baseAsBigInt;
			}
		}

		public BigInteger indexAsBigInt
		{
			get
			{
				return _float.index;
			}
		}
		public int indexAsInt
		{
			get
			{
				return _float.indexAsInt;
			}
		}



		public int sign
		{
			get
			{
				return significand.Sign;
			}
		}

		public BigInteger magnitudeAsBigInt
		{
			get
			{
				return BigInteger.Abs(significand);
			}
		}


		public BigInteger recurSpanAsBigInt
		{
			get { return _recurSpan.val; }
			set
			{
				this._recurSpan = new natural.Natural_bigInteger(value);
			}
		}
		public int recurSpanAsInt
		{
			get { return (int)_recurSpan.val; }
			set
			{
				this._recurSpan = new natural.Natural_bigInteger(value);
			}
		}


		public BigInteger recurPart()
		{


			return _float.significand % nilnul.num.natural.op.PowX2.Do_basePlural_indexNonNeg(_float.base_.val, recurSpan.val);



		}

		public override string ToString()
		{
			return toTxt();
		}
		public string ToStr()
		{
			if (recurSpan == 0)
			{
				return _float.ToString();//.toStr_linear_0_prepended2();
			}
			var magStr = nilnul.num.natural.op.ToStrX.Do(magnitudeAsBigInt, radixAsBigInt);
			if (magStr.Length < recurSpanAsInt)
			{
				magStr = magStr.PadLeft(recurSpanAsInt, '0');
			}
			var recurPartStr = magStr.Substring(
				magStr.Length - (int)recurSpanAsBigInt
				, recurSpanAsInt
			);
			var unRecur = magStr.Length - recurPartStr.Length;
			var suffix = magStr.Substring(0, unRecur);
			var index = this.indexAsInt;
			index += recurSpanAsInt;
			while (index > 0)
			{
				index -= recurPartStr.Length;
				suffix += recurPartStr;
			}
			var offset = suffix.Length + index;
			if (offset <= 0)
			{
				suffix = "0." + nilnul.obj.str.X.Repeat(0, -(offset)) + suffix;// +magStr;// +significandStr;
			}
			else
			{
				suffix = suffix.Insert(offset, ".");
			}
			suffix += "(" + recurPartStr + ")";
			return (sign < 0 ? "-" : "") + suffix;
		}
		public const string separatorForLatterCycle = "(";

		public string toTxt()
		{
			if (recurSpan == 0)
			{
				return _float.ToString();//.toStr_linear_0_prepended2();
			}
			var magStr = nilnul.num.natural.op.ToStrX.Do(magnitudeAsBigInt, radixAsBigInt);
			if (magStr.Length < recurSpanAsInt)
			{
				magStr = magStr.PadLeft(recurSpanAsInt, '0');
			}
			var recurPartStr = magStr.Substring(
				magStr.Length - (int)recurSpanAsBigInt
				, recurSpanAsInt
			);
			var unRecur = magStr.Length - recurPartStr.Length;
			var suffix = magStr.Substring(0, unRecur);
			var index = this.indexAsInt;
			index += recurSpanAsInt;
			while (index > 0)
			{
				index -= recurPartStr.Length;
				suffix += recurPartStr;
			}
			var offset = suffix.Length + index;
			if (offset <= 0)
			{
				suffix = "0." + nilnul.obj.str.X.Repeat(0, -(offset)) + suffix;// +magStr;// +significandStr;
			}
			else
			{
				suffix = suffix.Insert(offset, ".");
			}
			suffix += separatorForLatterCycle + recurPartStr;
			return (sign < 0 ? "-" : "") + suffix;
		}

		//public  string ToStr_decimal()
		//{
		//	if (recurSpan == 0)
		//	{
		//		return _float.toStr_linear_0_prepended();
		//	}
		//	var magStr = magnitudeAsBigInt.ToString();
		//	if (magStr.Length < recurSpanAsInt)
		//	{
		//		magStr = magStr.PadLeft(recurSpanAsInt, '0');
		//	}
		//	var recurPartStr = magStr.Substring(
		//		magStr.Length - (int)recurSpanAsBigInt
		//		, recurSpanAsInt
		//	);
		//	var unRecur = magStr.Length - recurPartStr.Length;
		//	var suffix = magStr.Substring(0, unRecur);
		//	var index = this.indexAsInt;
		//	index += recurSpanAsInt;
		//	while (index > 0)
		//	{
		//		index -= recurPartStr.Length;
		//		suffix += recurPartStr;
		//	}
		//	var offset = suffix.Length + index;
		//	if (offset <= 0)
		//	{
		//		suffix = "0." + nilnul.obj.str.X.Repeat(0, -(offset)) + suffix;// +magStr;// +significandStr;
		//	}
		//	else
		//	{
		//		suffix = suffix.Insert(offset, ".");
		//	}
		//	suffix += "(" + recurPartStr + ")";
		//	return (sign < 0 ? "-" : "") + suffix;
		//}

		public string ToMathMl()
		{
			throw new NotImplementedException();
		}

		public string ToStr_func()
		{
			return string.Format("nilnul.num.rational.float_.Periodic({0},{1},{2})", radixAsBigInt, _float.toStr_func(), recurSpan);

			throw new NotImplementedException();
		}



		public Periodic()
			: this(2, 0, 0, 0)
		{


		}

		private Periodic(Based2 float_, BigInteger recurSpan_natural)
		{
			this.float_ = float_;
			this.recurSpanAsBigInt = recurSpan_natural;



		}


		public Periodic(Based2 float_, natural.Natural_bigInteger recurSpan_natural)
		{
			this.float_ = float_;
			this._recurSpan = recurSpan_natural;



		}



		public Periodic(BigInteger radix_plural, BigInteger significand, BigInteger index, BigInteger recurSpan_natural)
			: this(new Based2(radix_plural, significand, index), recurSpan_natural)
		{

		}

		public Periodic(BigInteger radix_plural, Float float_, BigInteger recurSpan_natural)
			: this(new Based2(radix_plural, float_), recurSpan_natural)
		{

		}

		/// <summary>
		/// let 03.09(99) be 03.09+.01
		/// </summary>
		public void foldRimmings()
		{


		}

		static public bool LessThanOne(Periodic p)
		{

			///

			return p.toRational() < 1;

			throw new NotImplementedException();


		}

		static public bool IsNonNegative(Periodic p)
		{

			///

			return p.toRational() >= 0;

			throw new NotImplementedException();


		}


		public void set(BigInteger finite, Based2 recur)
		{

			///assert finite as 
			///



		}

		public Rational_InheritFraction toRational()
		{
			return ToRational(this);

		}
		static public Rational_InheritFraction ToRational(
			Periodic p
			)
		{

			var recurPart = p.recurPart();

			return (p.significand - recurPart) * nilnul.num.rational.op.PowX.Eval_basePlural(p.radixAsBigInt, p.indexAsBigInt)
				+

				nilnul.num.rational.Rational_InheritFraction.Divide(
					recurPart
					,
					nilnul.num.int_.op.PowX.Eval_basePlural_indexNoNeg(p.radixAsBigInt, p.recurSpanAsBigInt) - 1
				)
				*
				  nilnul.num.rational.op.PowX.Eval(p.float_.base_.val, (p.recurSpan + p.indexAsBigInt))
			;


		}
		static public Periodic FroRational(Rational_InheritFraction2 r)
		{
			return FroRational(10, r);
		}

		static public Periodic FroRational_binary(Rational_InheritFraction2 r)
		{
			return FroRational(2, r);
		}




		static public Periodic FroRational(BigInteger radix_plural, Rational_InheritFraction2 r)
		{
			var intProper = r.ToIntAndProper();
			BigInteger significand = intProper.Item1;
			BigInteger remainder = intProper.Item2.numerator;

			List<BigInteger> remainders = new List<BigInteger>();
			List<Rational_InheritFraction2> propers = new List<Rational_InheritFraction2>();

			BigInteger quotient;

			BigInteger recurSpan = -1;
			BigInteger index = 0;

			while (recurSpan == -1)
			{
				if (remainder == 0)
				{
					recurSpan = 0;
					return new Periodic(radix_plural, significand, index, 0);




				}

				remainders.Add(remainder);
				//quotient = BigInteger.DivRem(remainder * radix_plural, r.denominatorAsBigInt, out remainder);
				significand = significand * radix_plural
					+ BigInteger.DivRem(remainder * radix_plural, r.denominatorAsBigInt, out remainder);	//remainder &isin; [0,  denominator)

				index--;
				recurSpan = remainders.IndexOf(remainder);


			}


			return new Periodic(radix_plural, significand, index, remainders.Count - recurSpan);


			throw new NotImplementedException();

		}


	}
}
