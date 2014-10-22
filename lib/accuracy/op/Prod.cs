using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.accuracy.op
{
	public partial class Prod
	{
		static public Accuracy2 Eval(IEnumerable<Accuracy2> accuracies) {
			if (accuracies.Count()==0)
			{
				return Accuracy2.CreateSingle(1);
			}

			return Multi.Eval(
				
				accuracies.First(), 
				
				Eval(accuracies.Skip(1))
				
			);
		}
	}
}
