using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using R=nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational.accuracy.op
{
	public partial class Multi
	{
		static public Accuracy Eval(Accuracy a, Accuracy b)
		{
			return new Accuracy(
				cut.op.Min.Eval(
					cut.op.Multi.Eval(a.lower,b.upper)
					,
					cut.op.Multi.Eval(a.upper,a.lower)
				)
				,
				cut.op.Max.Eval(
					cut.op.Multi.Eval(a.lower,b.lower)
					,
					cut.op.Multi.Eval(a.upper,a.upper)
				)
				
			);




			throw new NotFiniteNumberException();
		}

		static public Accuracy1 Eval(Accuracy1 x, Accuracy1 y)
		{

			return new Accuracy1(

				ext.bound.LowerComparer.Min(
					nilnul.num.rational.ext.bound.op.Multi.Eval(x.lower, y.upper)
					,
					nilnul.num.rational.ext.bound.op.Multi.Eval(x.upper, y.lower)
				)
				,
				ext.bound.UpperComparer.Max(
					nilnul.num.rational.ext.bound.op.Multi.Eval(x.lower, y.lower)
					,
					nilnul.num.rational.ext.bound.op.Multi.Eval(x.upper, y.upper)


				)
			);




		}
		static public Accuracy2 Eval(Accuracy2 x, Accuracy2 y)
		{

			return new Accuracy2(

				ext.bound.LowerComparer.Min(
					nilnul.num.rational.ext.bound.op.Multi.Eval(x.lower, y.upper)
					,
					nilnul.num.rational.ext.bound.op.Multi.Eval(x.upper, y.lower)
				)
				,
				ext.bound.UpperComparer.Max(
					nilnul.num.rational.ext.bound.op.Multi.Eval(x.lower, y.lower)
					,
					nilnul.num.rational.ext.bound.op.Multi.Eval(x.upper, y.upper)


				)
			);




		}

	
	}
}
