using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.ext.comparer.bounded.be
{
	public partial class NonEmpty
	{
		static public bool Eval(Bounded x) {

			var t = ext.Comparer.Singleton.Compare(x.lower.pinpoint, x.upper.pinpoint);


			if (
				
				t<0
				
			)
			{
				return true;

			}
			if (t==0)
			{
				if (x.lower.openFalseCloseTrue )
				{
					if (x.upper.openFalseCloseTrue)
					{
						return true;
					}
					return false;
					
				}
				return false;
				
			}
			return false;
		
		}
	}
}
