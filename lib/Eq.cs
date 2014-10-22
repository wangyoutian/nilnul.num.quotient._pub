using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.num.rational
{
	 public partial class Eq
		 :IEqualityComparer<Rational_InheritFraction2>
	{

		

		

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

		 static public bool Equal(RationalI a, RationalI b)
		 {
			 //return a.nonNeg==b.nonNeg && nint.func.EqualX.Equal( a.denominator,b.denominator) &&  nint.func.EqualX.Equal(a.numerator,b.numerator);

			 return Subtract.Eval(a, b).Numerator().IsZero;

		 }


		public bool Equals(Rational_InheritFraction2 x, Rational_InheritFraction2 y)
		{
			return x - y == 0;

			//return Subtract.Eval(x, y).Numerator().IsZero;

			throw new NotImplementedException();
		}

		public int GetHashCode(Rational_InheritFraction2 obj)
		{
			throw new NotImplementedException();
		}
	}

	
}
