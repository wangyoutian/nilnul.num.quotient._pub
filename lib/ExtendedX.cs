using nilnul.num.rational.ext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.rational
{
	static public partial class ExtendedX
	{
		static public ExtendedI Create(
			nilnul.order.ExtendedI<Rational_InheritFraction2> x
			
		) {
			if (x is nilnul.order.ext.NegInfI)
			{
				return ext.NegInf.Singleton;
			}
			if (x is nilnul.order.ext.PosInfI)
			{
				return ext.PosInf.Singleton;
				
			}
			return new ext.Literal(x as nilnul.order.ext.Literal<Rational_InheritFraction2>);
		
		}

		static public ext.Literal Create(int x) {

			return new ext.Literal(x);
		}

		static public ext.Literal Create(Rational_InheritFraction2 x) {
			return new ext.Literal(x);
		}

		static public ext.Literal CreateZero() {
			return Create(0);
		}

		static public bool IsZero(this ExtendedI x) {

			return x is Literal && (x as Literal).val == 0;
		
		}

		static public ext.Literal CreateOne() {
			return new ext.Literal(1);
		}
	}
}
