using nilnul.num.natural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.rational.float_
{
	public partial class Exp_bigIntAssertedPluralAsBase
	{
		private nilnul.num.natural.rel.Plural.BigInt.Asserted _base;

		public  nilnul.num.natural.rel.Plural.BigInt.Asserted @base
		{
			get { return _base; }
			set { _base = value; }
		}
		private BigInteger _index;

		public BigInteger index
		{
			get { return _index; }
			set { _index = value; }
		}

		public Exp_bigIntAssertedPluralAsBase(nilnul.num.natural.rel.Plural.BigInt.Asserted @base, BigInteger index)
		{
			this._base = @base;
			this._index = index;

		}
		public Exp_bigIntAssertedPluralAsBase(BigInteger @base, BigInteger index)
			:this(new natural.rel.Plural.BigInt.Asserted(@base),index)
		{

		}

		public Rational_InheritFraction toRational() {
			return rational.op.PowX.Eval(_base.val, _index);
			
		}
		public string toMathMl() {
			return string.Format( "<msup><mn>{0}</mn><mn>{1}</mn></msup>",_base.val,_index);

			throw new NotImplementedException();
		}


		public string toStr() {
			return string.Format( "nilnul.num.rational.@float.Exp_bigIntAssertedAsBase({0},{1})",_base,_index);
			throw new NotImplementedException();
		}
		public override string ToString()
		{
			return _base.val.ToString()+"^"+_index.ToString();
		}

		static public Exp_bigIntAssertedPluralAsBase Multi(BigInteger index1, BigInteger index2, BigInteger radix) {

			return new Exp_bigIntAssertedPluralAsBase(radix, index1 + index2);
		
		}

		static public Exp_bigIntAssertedPluralAsBase Divide(
			BigInteger radix_plural
			,
			BigInteger index1
			,
			BigInteger index2
			
		) {
			return new Exp_bigIntAssertedPluralAsBase(radix_plural, index1 - index2);
		
		}

		static public Exp_bigIntAssertedPluralAsBase Inverse(Exp_bigIntAssertedPluralAsBase x) {

			return new Exp_bigIntAssertedPluralAsBase(x._base, -x._index);
		
		}
		
		
	}
}
