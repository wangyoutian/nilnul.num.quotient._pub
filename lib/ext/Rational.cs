using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational.ext
{
	public partial class Rational
		:nilnul.Box<R>
		,
		ExtendedI

	{

		public Rational(R r)
			:base(r)
		{

		}
	}
}
