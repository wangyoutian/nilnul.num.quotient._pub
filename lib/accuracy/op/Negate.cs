using nilnul.num.rational.accuracy.bounded;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.accuracy.op
{
	public partial class Negate
	{
		static public Accuracy Eval(Accuracy a) {

			return new Accuracy(
				cut.op.Negate.Eval(a.upper)
				,
				cut.op.Negate.Eval(a.lower)
			);

			throw new NotFiniteNumberException();
		}

		static public Accuracy1 Eval(Accuracy1 x)
		{
			return new Accuracy1(
				ext.bound.op.Negate.Eval(x.upper)
				,
				ext.bound.op.Negate.Eval(x.lower)

			);

		}
		static public Accuracy2 Eval(Accuracy2 x)
		{
			return new Accuracy2(
				ext.bound.op.Negate.Eval(x.upper)
				,
				ext.bound.op.Negate.Eval(x.lower)

			);

		}
	}
}
