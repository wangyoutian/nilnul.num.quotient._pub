using nilnul_obj.op;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace nilnul.num.rational
{
	public class Subtract:ClosedBiOpI<RationalI>
	{

		static private readonly Subtract _Instance = new Subtract();
		static public Subtract Instance
		{
			get
			{
				return _Instance;
			}
		}
		public Subtract()
		{
		}
				
		static public RationalI Eval(RationalI a,RationalI b) {

			return Add.Eval(a, b.Negate());
		
		}
	

		public Func<RationalI, RationalI, RationalI> func
		{
			get { return Eval; }
		}

		public override string ToString()
		{
			return "-";
		}
	}
}
