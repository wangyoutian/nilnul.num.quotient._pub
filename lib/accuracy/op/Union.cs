using nilnul.num.rational.accuracy.bounded;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational.accuracy.op
{
	public partial class Union
	{
		static public Accuracy Eval(Accuracy a,Accuracy b) {

			return new Accuracy(
				cut.op.Min.Eval(a.lower,b.lower)
				,
				cut.op.Max.Eval(a.upper,b.upper)
			);

			


			throw new NotFiniteNumberException();
		}

		static public Accuracy1 Eval(Accuracy1 a,Accuracy1 b) {

			return new Accuracy1(
				ext.bound.LowerComparer.Min(a.lower,b.lower)
				,
				ext.bound.UpperComparer.Max(a.upper,b.upper)
			);
		
		}
	}
}
