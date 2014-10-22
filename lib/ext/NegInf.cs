using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.ext
{
	public partial class NegInf
		:
		nilnul.order.ext.NegInf<Rational_InheritFraction2>
		,

		ExtendedI
		,
		nilnul.order.ext.NegInfI
	{
		static public NegInf Singleton = SingletonByDefault<NegInf>.Instance;
	}
}
