using nilnul.order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational.ext
{
	public partial class Comparer
		:
		nilnul.order.ext.Comparer<R,rational.Comparer,ExtendedI>
		
	{

		static public Comparer Singleton = SingletonByDefault<Comparer>.Instance;

		
		static public bool IsNeative(R x)
		{

			return Singleton.Compare(x, new R(0)) < 0;

		}
		static public bool IsNeative(ExtendedI x)
		{

			return Singleton.Compare(x, new R(0)) < 0;

		}

		static public int SignInInt(ExtendedI x) {
			return Singleton.Compare(x, ExtendedX.Create( 0) as ExtendedI);
		}

		static public bool IsNeative(ExtendedI<R> x)
		{

			return Singleton.Compare(x, new R(0)) < 0;

		}
	static public bool IsPositive(R x)
		{

			return Singleton.Compare(x, new R(0)) > 0;

		}
		static public bool IsZero(R x)
		{

			return Singleton.Compare(x, new R(0)) == 0;

		}

		static public bool IsNotZero(R x)
		{

			return Singleton.Compare(x, new R(0)) != 0;

		}

		static public bool IsNotNeg(R x)
		{

			return Singleton.Compare(x, new R(0)) >= 0;

		}

		static public bool IsNotPos(R x)
		{

			return Singleton.Compare(x, new R(0)) <= 0;

		}


		
	}
}
