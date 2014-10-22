using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.integer;
using nilnul.order;
using nilnul.num.rational.float_.rel;

namespace nilnul.num.rational.float_
{
	public class Order:TotalOrderA<Float3.SignificandIndex>
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
				
		public override Sign compare(Float3.SignificandIndex x, Float3.SignificandIndex y)
		{


			//var c = x - y;
			return nilnul.order.SignX.ToSign( (x-y).significand);
		
			
			
		}
	}
}
