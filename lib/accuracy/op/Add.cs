using nilnul.num.rational.accuracy.bounded;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.accuracy.op
{
	public partial class Add
	{
		static public Accuracy Eval(Accuracy	a, Accuracy b)
		{

			return new Accuracy(
				cut.op.Add.Eval(a.lower,b.lower)
				,
				cut.op.Add.Eval(a.upper,b.upper)
			);

			throw new NotImplementedException();
		}

		static public Accuracy1 Eval(Accuracy1 a, Accuracy1 b)
		{

			return new Accuracy1(

				num.rational.ext.comparer.bounded.restricted.op.Add.Eval(a.val, b.val)



			);


		}


		static public Accuracy2 Eval(Accuracy2 a, Accuracy2 b)
		{

			return new Accuracy2(

				num.rational.ext.comparer.bounded.restricted.op.Add.Eval(a.val, b.val)

			);


		}

	


	}
}
