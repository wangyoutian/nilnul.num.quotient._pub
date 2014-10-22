using nilnul.num.rational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.set
{
	static public partial class SumX
	{
		static public Rational_InheritFraction Sum(IEnumerable<Rational_InheritFraction> x) {
			//add is associative, with zero element of zero.

			return x.Aggregate((Rational_InheritFraction)0,Rational_InheritFraction.Add);
		
		}
	}
}
