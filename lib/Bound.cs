using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational
{
	public partial class Bound
		:nilnul.order.Bound<Rational_InheritFraction2>
	{
		public Bound(bool openFalseCloseTrue, Rational_InheritFraction2 bound)
			:base(openFalseCloseTrue,bound)
		{

		}

		static public Bound Multi(Bound x, Bound y) {

			return new Bound(x.openFalseCloseTrue && y.openFalseCloseTrue, x.pinpoint * y.pinpoint);
		}

		static public Bound operator *(Bound x, Bound y) {
			return Multi(x, y);
		}

		static public Bound Abs(Bound x) {
			return new Bound(
				x.eq
				,
				x.pinpoint.toAbs()
			);
		}

		static public Bound CreateZeroClose() {
			return new Bound(true, 0);
		}

		static public Bound Add(Bound x,Bound y) {
			return new Bound(
				x.eq&&y.eq
				,
				x.pinpoint+y.pinpoint	
			);
		}

		static public Bound Negate(Bound x) {

			return new Bound(
				x.eq
				,
				-x.pinpoint
			);
		
		}

		static public Bound Inverse(Bound x) {
			return new Bound(x.eq, x.pinpoint.toInverse());
		}

		static public bool Eq(Bound x, Bound y) {

			return nilnul.order.bound.Eq_comparerSingle<Q, num.rational.Eq>.Singleton.Equals(x, y);
		
		}

	
	}
}
