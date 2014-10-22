using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.accuracy.bounded.op
{
	public partial class Subtract
	{
		static public FiniteI Eval(FiniteI a,FiniteI b) {

			return 	Add.Eval(a,Negate.Eval( b));


			throw new NotFiniteNumberException();
		}
	}
}
