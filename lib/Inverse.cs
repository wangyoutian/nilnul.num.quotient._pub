using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.rational
{
	static public partial class InverseX
	{
		static public RationalI Inverse(this RationalI x) {

			return Divide.Eval(x.Denominator(), x.Numerator());
		
		}
	}
}
