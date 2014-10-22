using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational
{

	static public partial class NonNegX
	{
		static public bool Be(
			Rational_InheritFraction x
		)
		{
			return x >= 0;
			
		}

		public partial class NonNeg
			: nilnul.bit.AdjectiveI2<Rational_InheritFraction>
		{
			public bool be(Rational_InheritFraction val)
			{
				return Be(val);
			}
		}

		public struct NonNegNotNull {
			NonNeg x;

			public NonNegNotNull(NonNeg x)
			{
				nilnul.NotNullX.AssertIsNotNull(x);
				this.x = x;

			}
					

		
		}

		public partial class Assertion
			:nilnul.bit.AssertionFroAdjSingleton<Rational_InheritFraction,NonNeg>
		{

			static public Assertion Instance = SingletonByDefaultNew<Assertion>.Instance;
		}

		

		public partial class NonNegRational
			:nilnul.bit.AdjectiveType<Rational_InheritFraction,NonNeg>
		{

			public NonNegRational(Rational_InheritFraction r)
				:base(r)
			{
			}

		}






	}



}
