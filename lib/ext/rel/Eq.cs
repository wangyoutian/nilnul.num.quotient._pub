using nilnul.order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.ext.rel
{
	public partial class Eq
		:IEqualityComparer<ExtendedI>
	{
		static public Eq Singleton = SingletonByDefault<Eq>.Instance;
		public bool Equals(ExtendedI x, ExtendedI y)
		{
			return nilnul.order.ext.Eq<Rational_InheritFraction2, rational.Eq>.Eval(x, y);

			throw new NotImplementedException();
		}

		static public bool Eval(ExtendedI x, int y) {
			return Singleton.Equals(x, ExtendedX.Create(y));
		}
		static public bool Eval(ExtendedI<Rational_InheritFraction2> x, int y) {
			return Eval(x,

				new nilnul.order.ext.Literal<Rational_InheritFraction2>(y)
				
				);
		}

		static public bool Eval(
			ExtendedI<Rational_InheritFraction2> x
			,
			ExtendedI<Rational_InheritFraction2> y
			
		) {
			
				return nilnul.order.ext.Eq<Rational_InheritFraction2, rational.Eq>.Eval(x, y);

		}

		public int GetHashCode(ExtendedI obj)
		{
			if (obj is NegInf)
			{
				return int.MinValue;
				
			}
			if (obj is PosInf)
			{
				return int.MaxValue;
				
			}
			return (obj as ext.Literal).val.GetHashCode();

			throw new NotImplementedException();
		}
	}
}
