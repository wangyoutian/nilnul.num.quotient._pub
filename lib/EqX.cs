using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.num.rational
{
	static public partial class EqualX
	{

		

		static public bool Equal(RationalI a, int b)
		{
			return Equal(a, b.ToRational());
		}


		static public bool Equal(RationalI a, RationalI b)
		{
			//return a.nonNeg==b.nonNeg && nint.func.EqualX.Equal( a.denominator,b.denominator) &&  nint.func.EqualX.Equal(a.numerator,b.numerator);

			return Subtract.Eval(a,b).Numerator().IsZero;

		}

		//static public bool Equal(ConstI<RationalI> a,ConstI<RationalI> b) {

		//	return Equal(a.eval(), b.eval());
		
		//}
		//public bool? eval(ExprI a,ExprI b)
		//{
		//    ExprI a2 = a.eval();
		//    ExprI b2 = b.eval();
		//    if (a2 is RationalI && b is RationalI)
		//    {
		//        return eval((RationalI)a, (RationalI)b);

		//    }
		//    else
		//    {
		//        return null;
		//    }

		//}

	}

	
}
