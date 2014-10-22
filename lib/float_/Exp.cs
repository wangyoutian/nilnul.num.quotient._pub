using nilnul.num.natural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.rational.float_
{
	public partial class Exp
	{
		private nilnul.num.natural.Plural2	_base;

		public  nilnul.num.natural.Plural2	@base
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

		public Exp(Plural2 @base,BigInteger index)
		{
			this._base = @base;
			this._index = index;

		}

		static public Rational_InheritFraction Pow(BigInteger base_plural, BigInteger index) {

			return nilnul.num.rational.op.PowX.Eval(base_plural, index);
		}
		
		
	}
}
