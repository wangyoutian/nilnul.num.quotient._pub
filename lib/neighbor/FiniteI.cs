using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;


namespace nilnul.num.rational.neighbor
{
	public partial interface FiniteI
		:collection.ContainsI
		,interval.LowerBoundI
		,interval.UpperBoundI
	{

		be.NonNegX.Asserted radius { get; }

		


		
	}
}
