using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.integer;
using nilnul.order;

namespace nilnul.num.rational.decimal_
{
	public class Order:TotalOrderA<Float>
	{

		static private readonly Order _Instance = new Order();
		static public Order Instance
		{
			get
			{
				return _Instance;
			}
		}
		private Order()
		{
		}
				
		public override Sign compare(Float x, Float y)
		{
			Float.AssertSameBase(x, y);
			//var c = x - y;
			return nilnul.order.SignX.ToSign( (x-y).significand);
		
			
			
		}
	}
}
