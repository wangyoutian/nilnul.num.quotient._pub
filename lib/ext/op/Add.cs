using nilnul.order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.ext.op
{
	public partial class Add
	{
		static public ExtendedI Eval(ExtendedI x, ExtendedI y) {
			if (x is NegInf)
			{
				if (y is NegInf)
				{
					return NegInf.Singleton;
					
				}
				if (y is Literal)
				{
					return NegInf.Singleton;
					
				}
				throw new Exception();
			}
			if (x is Literal)
			{
				if (y is NegInf)
				{
					return NegInf.Singleton;
					
				}
				if (y is Literal)
				{

					return new Literal( (x as Literal).val + (y as Literal).val);
				}
				if (y is PosInf)
				{
					return PosInf.Singleton;
				}
				
			}

			if (y is NegInf)
			{
				throw new Exception();
				
			}
			if (y is Literal)
			{
				return PosInf.Singleton;
			}
			return PosInf.Singleton;
		
		}

		static public ExtendedI Eval(ExtendedI<Rational_InheritFraction2> x, ExtendedI<Rational_InheritFraction2> y) {

			return Eval(
				ExtendedX.Create(x)
				,
				ExtendedX.Create(y)
				);
		
		}
	}
}
