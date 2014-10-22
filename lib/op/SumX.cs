using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q=nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational.op
{
	public partial class SumX
	{

		static public Q Eval(params  Q[] operands)
		{
			return Eval(operands as IEnumerable<Q>);
		
		}

		static public Q Eval(IEnumerable<Q> operands) { 
			if (operands.Count()==0)
			{
				return 0;
				
			}
			return nilnul.num.rational.Rational_InheritFraction2.Add(operands.First(), Eval(operands.Skip(1)));
	
		}

	}
}
