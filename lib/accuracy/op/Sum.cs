using nilnul.num.rational.accuracy.bounded;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.accuracy.op
{
	public partial class Sum
	{

		static public Accuracy Eval() {
			return Accuracy.CreateZero();
		}

		static public Accuracy Eval(IEnumerable<Accuracy> a_nonEmpty)
		{
			var r = a_nonEmpty.First();

			for (int i = 1; i < a_nonEmpty.Count(); i++)
			{
				r = Add.Eval(r, a_nonEmpty.ElementAt(i));
			}
			return r;


			throw new NotImplementedException();
		}

		static public Accuracy Eval(params Accuracy[] a_nonEmpty)
		{
			return Eval(a_nonEmpty.AsEnumerable());


			throw new NotImplementedException();
		}

		static public Accuracy1 Eval(IEnumerable<Accuracy1> accuracies)
		{

			if (accuracies.Count() == 0)
			{
				return Accuracy1.CreateZero();

			}
			return Add.Eval(
				accuracies.First()
				,
				Eval(accuracies.Skip(1))
			);
		}

		static public Accuracy2 Eval(IEnumerable<Accuracy2> accuracies)
		{

			if (accuracies.Count() == 0)
			{
				return Accuracy2.CreateZero();

			}
			return Add.Eval(
				accuracies.First()
				,
				Eval(accuracies.Skip(1))
			);
		}

			static public Accuracy2 Eval(params Accuracy2[] a_nonEmpty)
		{
			return Eval(a_nonEmpty.AsEnumerable());


			throw new NotImplementedException();
		}




	}
}
