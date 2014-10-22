using nilnul.order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.ext.op
{
	public partial class Multi
	{
		static public ExtendedI Eval(ExtendedI x, ExtendedI y) {
			if (x is NegInf)
			{
				if (y is NegInf)
				{
					return PosInf.Singleton;
					
				}
				if (y is Literal)
				{
					var yLiteral = y as Literal;
					if ((y as Literal).val==0)
					{
						return ExtendedX.Create( 0);
						
					}
					if (yLiteral.val<0)
					{
						return PosInf.Singleton;
						
					}

					return NegInf.Singleton;
					
				}
				return NegInf.Singleton;
			}
			if (x is Literal)
			{
				if (y is NegInf)
				{
					return Eval(y,x);
					
				}
				if (y is Literal)
				{


					return new Literal( (x as Literal).val * (y as Literal).val);
				}
				if (y is PosInf)
				{
					var signOfX = Comparer.SignInInt(x);
					if (signOfX==0)
					{
						return ExtendedX.Create(0);
						
					}
					if (signOfX<0)
					{
						return NegInf.Singleton;
						
					}
					return PosInf.Singleton;
				}
				
			}
			// x is pos Inf

			if (y is NegInf)
			{
				return NegInf.Singleton;
				
			}
			if (y is Literal)
			{
				return Eval(y,x);
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

		static public ExtendedI Eval(Rational_InheritFraction2 scale, ExtendedI<Rational_InheritFraction2> x) {
			return Eval(ExtendedX.Create(scale) as ExtendedI as ExtendedI<Rational_InheritFraction2>, x);
		}
	}
}
