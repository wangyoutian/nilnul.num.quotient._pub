using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace nilnul.num.rational.float_.rel
{
	static public partial class SameBaseX
	{
		public static void AssertSameBase(this Float x, Float y)
		{
			nilnul.num.natural.relation.EqualX.Assert(x.@base_, y.@base_);

		}
		public static void AssertSameBase(this Float3 x, Float3 y)
		{
			nilnul.bit.Assert.True(x.baseAsBigInt== y.baseAsBigInt);

		}
	}
}
