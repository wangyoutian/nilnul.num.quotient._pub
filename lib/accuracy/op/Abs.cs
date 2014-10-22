using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.accuracy.op
{
	public partial class Abs
	{
		static public Accuracy Eval(Accuracy a)
		{

			if (a.radius == null)
			{
				return Accuracy.CreateClopen(0, a.radius);

			}

			return new Accuracy(

				nilnul.num.rational.cut.Cut.CreateZeroClose()
				,
				cut.op.Min.Eval(
					cut.op.Abs.Eval(a.lower),
					a.upper
				)


			);





			return Accuracy.CreateLowerZeroClose(a.radius, a.upper.openFalseCloseTrue);




			throw new NotFiniteNumberException();
		}

		static public rational.Accuracy1 Eval(rational.Accuracy1 a)
		{

			return Accuracy1.CreateLowerZeroClose(

				ext.bound.UpperComparer.Max(


					ext.bound.op.Abs.Eval(a.lower)
					,
					a.upper
				)

			);






			throw new NotFiniteNumberException();
		}
		static public rational.Accuracy2 Eval(rational.Accuracy2 a)
		{

			return Accuracy2.CreateLowerZeroClose(

				ext.bound.UpperComparer.Max(


					ext.bound.op.Abs.Eval(a.lower)
					,
					a.upper
				)

			);






			throw new NotFiniteNumberException();
		}




	}
}
