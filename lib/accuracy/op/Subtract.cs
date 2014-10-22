using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.accuracy.op
{
	public partial class Subtract
	{
		static public Accuracy Eval(Accuracy a,Accuracy b) {

			return accuracy.op.Add.Eval(a, Negate.Eval(b));


			throw new NotFiniteNumberException();
		}

		static public Accuracy1 Eval(Accuracy1 x, Accuracy1 y) {

			return Add.Eval(
				x
				,
				Negate.Eval(y)
			);
		}
	}
}
