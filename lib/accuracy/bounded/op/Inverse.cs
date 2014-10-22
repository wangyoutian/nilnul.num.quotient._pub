using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.accuracy.bounded.op
{
	[Obsolete("division by zero",true)]
	public partial class Inverse
	{
		static public FiniteI Eval(FiniteI a)
		{

			if (a is OpenLeftI)
			{
				if (a is OpenRightI)
				{
					return new Open2(
						nilnul.num.rational.op.InverseX.Inverse(
						a.lowerBound)
						,
						nilnul.num.rational.op.InverseX.Inverse(
						a.upperBound
						)
						);

				}
				return new OpenClose(
					nilnul.num.rational.op.InverseX.Inverse(a.lowerBound)
					,

					nilnul.num.rational.op.InverseX.Inverse(a.upperBound)

					);

			}

			if (a is OpenRightI)
			{
				return new Clopen(

						nilnul.num.rational.op.InverseX.Inverse(a.lowerBound)
					,

					nilnul.num.rational.op.InverseX.Inverse(a.upperBound)
				);

			}

			return new Close2(
							nilnul.num.rational.op.InverseX.Inverse(a.lowerBound)
					,

					nilnul.num.rational.op.InverseX.Inverse(a.upperBound)



				);



			throw new NotFiniteNumberException();
		}
	}
}
