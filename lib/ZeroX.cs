using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit;

namespace nilnul.num.rational
{
	static public partial class ZeroX
	{
		static public bool Is(RationalI x) {

			return x.Simplify().Numerator() == 0;
		
		}

		static public bool Not(RationalI x) {

			return !Is(x);
		
		}

		static public void AssertIsZero(this RationalI x) {
			 Assert.True(Is(x));
		}

		static public void AssertNotZero(this RationalI x) {
			nilnul.bit.Assert.False(Is(x));
		}
	}
}
