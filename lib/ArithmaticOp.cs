using nilnul_obj.op;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace nilnul.num.rational
{
	/// <summary>
	/// add,subtract,multiply,divide
	/// </summary>
	public partial class ArithmaticOp
	{
		///give the four BiOp()
		///

		static public Func<RationalI, RationalI, RationalI>[] funcs = {
				Add.Eval
				,
				Subtract.Eval
				,
				MultiplyX.Multiply
				,
				DivideX.Divide
			};

		static public HashSet<ClosedBiOpI<RationalI>> ops=new HashSet<ClosedBiOpI<RationalI>>();

		static ArithmaticOp() {
			var ops2 = new ClosedBiOpI<RationalI>[] {Add.Instance,Subtract.Instance,Multiply.Instance,Divide.Instance};

			foreach (var item in ops2)
			{
				ops.Add(item);
				
			}
		}
		
		
	}
}
