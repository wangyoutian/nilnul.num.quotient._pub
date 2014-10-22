using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R=nilnul.num.rational.Rational_InheritFraction2;
using Xr = nilnul.num.rational.ExtendedI;
namespace nilnul.num.rational
{
	/// <summary>
	/// zero must be in this.
	/// </summary>
	public partial interface NeighborI
		:IntervalI
	{

		Xr radius { get; }

		bool open { get; }



	}
}
