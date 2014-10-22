using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational
{

	static public partial class WithinClosedUnitX
	{
		static public bool Be(
			Rational_InheritFraction x
		)
		{
			return x >= 0&&x<=1;
			
		}

		public partial class WithinClosedUnit
			: nilnul.bit.AdjectiveI2<Rational_InheritFraction>
		{
			public bool be(Rational_InheritFraction val)
			{
				return Be(val);
			}
		}

		public partial class Assertion
			:nilnul.bit.AssertionFroAdjSingleton<Rational_InheritFraction,WithinClosedUnit>
		{

			static public Assertion Instance = SingletonByDefaultNew<Assertion>.Instance;
		}

		

		public partial class PositiveRational
			:nilnul.bit.AdjectiveType<Rational_InheritFraction,WithinClosedUnit>
		{

			public PositiveRational(Rational_InheritFraction r)
				:base(r)
			{
			}

		}






	}



}
