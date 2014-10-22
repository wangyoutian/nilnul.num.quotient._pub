using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.ext
{
	public partial class PosInf
		:

		nilnul.order.ext.PosInf<Rational_InheritFraction2>
		,
		
		ExtendedI
		,
		nilnul.order.ext.PosInfI
	{
		static public PosInf Singleton = SingletonByDefault<PosInf>.Instance;

	}
}
