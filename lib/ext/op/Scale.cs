using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.ext.op
{
	public partial class Scale
	{
		static public ExtendedI Eval(ExtendedI x, Rational_InheritFraction2 scale) {

			if (scale==0)
			{
				return new Literal( 0);
				
			}
			if (scale<0)
			{
				return Negate.Eval(
					_Eval__scalePositive(
						x,-scale
					)

				);

				
			}

			return _Eval__scalePositive(x, scale);
		}

		static public ExtendedI _Eval__scalePositive(
			ExtendedI x, Rational_InheritFraction2 scale
		) {

			if (x is ext.InfI)
			{
				return x;
			}
			return new Literal((x as Literal).val * scale);
		

		}


		static public ExtendedI Half(ExtendedI x) {
			return Eval(x, Rational_InheritFraction2.CreateHalf());
		}

	}
}
