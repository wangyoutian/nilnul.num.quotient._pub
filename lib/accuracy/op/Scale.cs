using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using R=nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational.accuracy.op
{
	public partial class Scale
	{
		static public Accuracy Eval(R scale, Accuracy a)
		{
			if (scale==0)
			{
				return Accuracy.CreateZero();
				
			}

			return new Accuracy(
				cut.op.Scale.Eval(scale,a.lower)
				,
				cut.op.Scale.Eval(scale,a.upper)
					
			);
			throw new NotFiniteNumberException();
		}

		static public Accuracy2 Double(Accuracy2 accuracy) {

			return Eval(2, accuracy);
		
		}


	
		static public Accuracy2 Eval(R scale, Accuracy2 a) {
			if (scale==0)
			{
				return Accuracy2.CreateZero();
				
			}
			if (scale>0)
			{
				return new Accuracy2(
					ext.bound.op.Scale.Eval(scale,a.lower)
					,
					ext.bound.op.Scale.Eval(scale,a.upper)
				);
				
			}

			return new Accuracy2(
				
					ext.bound.op.Scale.Eval(scale,a.upper)
					,
					ext.bound.op.Scale.Eval(scale,a.lower)
			
			);
		}

		static public Accuracy2 Half(Accuracy2 x) {
			return Eval(R.CreateHalf(),x);
		}

		static public Accuracy1 Eval(R scale, Accuracy1 a) {
			if (scale==0)
			{
				return Accuracy1.CreateZero();
				
			}
			if (scale<0)
			{
				return new Accuracy1(
					ext.bound.op.Scale.Eval(scale,a.lower)
					,
					ext.bound.op.Scale.Eval(scale,a.upper)
				);
				
			}

			return new Accuracy1(
				
					ext.bound.op.Scale.Eval(scale,a.upper)
					,
					ext.bound.op.Scale.Eval(scale,a.lower)
			
			);
		}


		
	}
}
