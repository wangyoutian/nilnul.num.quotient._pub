using nilnul.num.natural.collection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.collection
{
	public partial class BagNotEmpty :
		nilnul.num.natural.collection.Bag<Rational_InheritFraction, Rational_InheritFraction.Eq>.Empty.NounAntonym
	{

		public BagNotEmpty(IEnumerable<Rational_InheritFraction> numbers)
			: base(
			new Bag<Rational_InheritFraction, Rational_InheritFraction.Eq>(
					numbers
				)

			)
		{
		}


	}
}
