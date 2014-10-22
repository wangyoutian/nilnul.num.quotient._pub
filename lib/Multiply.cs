using nilnul_obj.op;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace nilnul.num.rational
{
	 public class Multiply 
	:ClosedBiOpI<RationalI>
	{

		static private readonly Multiply _Instance = new Multiply();
		static public Multiply Instance
		{
			get
			{
				return _Instance;
			}
		}
		public Multiply()
		{
		}
				

		public Func<RationalI, RationalI, RationalI> func
		{
			get { return MultiplyX.Multiply; }
		}

		public override string ToString()
		{
			return "*";
		}
	}

	static public partial class MultiplyX
	{
		static public RationalI Multiply(this RationalI a,RationalI b) {

			return Divide.Eval(a.Numerator() * b.Numerator(), a.Denominator() * b.Denominator());
		
		}
	}
}
