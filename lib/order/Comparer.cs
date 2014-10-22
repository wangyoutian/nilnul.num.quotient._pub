using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.order
{
	public partial class Comparer
		:
		nilnul.order.ComparerA<Rational_InheritFraction>
	{


		public class Singleton : SingletonByDefault<Comparer>
		{

		}

		static public Comparer Instance = Singleton.Instance;



		public override nilnul.order.Sign compare(Rational_InheritFraction x, Rational_InheritFraction y)
		{
			return (x - y).sign ; 
		}
	}
}
