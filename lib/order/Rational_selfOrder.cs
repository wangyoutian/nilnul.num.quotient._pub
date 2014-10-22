using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.order
{
	public partial class Rational_self
		:
		nilnul.num.rational.Rational_InheritFraction
		,
		nilnul.order.TotalOrderOnTypeI<Rational_self>
	{

		public Rational_self(Rational_InheritFraction val)
			:base(val)
		{
		}



		public  nilnul.order.TotalOrderI3<Rational_self> order
		{
			get {

				return SingletonByDefaultNew<LessThanOrEqualTo2>.Instance as nilnul.order.TotalOrderI3<Rational_InheritFraction> as nilnul.order.TotalOrderI3<Rational_self>;

				
				throw new NotImplementedException(); 
			
			}
		}
	}
}
