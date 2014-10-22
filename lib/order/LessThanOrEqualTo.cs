using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.order
{
	public partial class LessThanOrEqualTo

		:
		nilnul.order.TotalOrderA2<Rational_InheritFraction>
		//,
		
		//nilnul.order.TotalOrderI2< Rational_InheritFraction>
		

	{
		public override bool contains(Rational_InheritFraction x, Rational_InheritFraction y)
		{
			return ( (x-y).sign <= 0);
		}



		static public nilnul.order.OrderFullFledged<Rational_InheritFraction> FullFledged = new nilnul.order.OrderFullFledged<Rational_InheritFraction>(new LessThanOrEqualTo());

		public class Singleton : SingletonByDefault<LessThanOrEqualTo>
		{

		}

		static public LessThanOrEqualTo Instance = Singleton.Instance;

		public class OrderedSet
			:HashSet<Rational_InheritFraction>
		{ 

		
		}



		


		
	}
}
