using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.rational
{
	static public partial class ExponentX
	{
		static public void AssertSameBase(Exponent a,Exponent b) {

			nilnul.num.natural.relation.EqualX.Assert(a.base_, b.base_);
			
		}

	}
}
