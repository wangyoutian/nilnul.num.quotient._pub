using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.order
{
	public partial class LessThanOrEqualTo2

		:
		nilnul.order.TotalOrderI3<Rational_InheritFraction>
		,
		nilnul.order.total.unbound.dense.OrderI<Rational_InheritFraction>
		//,
		
		//nilnul.order.TotalOrderI2< Rational_InheritFraction>
		

	{

		public LessThanOrEqualTo2()
		{
		}
					
		public  bool contains(Rational_InheritFraction x, Rational_InheritFraction y)
		{
			return ( (x-y).sign <= 0);
		}

		static public LessThanOrEqualTo2 Instance = SingletonByDefaultNew<LessThanOrEqualTo2>.Instance;



		
	}
}
