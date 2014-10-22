using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.collection
{
	public partial class Bag3 :
		nilnul.num.natural.collection.Bag<Rational_InheritFraction, Rational_InheritFraction.Eq>
	{

		public Bag3()
		{
		}


		public Bag3(IEnumerable<Rational_InheritFraction> numbers)
			: base(numbers)
		{
		}

		public class EmptyAdj :
			nilnul.bit.AdjectiveI2<Bag3>
		{

			public bool be(Bag3 val)
			{
				return val.cardinality > 0;

				throw new NotImplementedException();
			}
		}

		 public partial class Empty2 :
			nilnul.bit.AdjectiveTowardNoun<Bag3, EmptyAdj>
		{
		}


		static public partial class Empty
		{
			static public bool Be(Bag3 bag)
			{

				return bag.cardinality > 0;

			}

			public class Adj
				: nilnul.bit.Adjective_FroFunc<Bag3>
			{

				public Adj()
					: base(Be)
				{
				}
			}

			public class Assertion
				: nilnul.bit.AssertionFroAdjSingleton<Bag3, Adj>
			{

			}

			public class Noun
				: nilnul.bit.AdjectiveType<Bag3, Adj>
			{

				public Noun(Bag3 bag)
					: base(bag)
				{
				}


			}

			public class NounAntonym
				: nilnul.bit.AdjectiveAntonymType<Bag3, Adj>
			{

				public NounAntonym(Bag3 bag)
					: base(bag)
				{
				}


			}


		}


	}
}
