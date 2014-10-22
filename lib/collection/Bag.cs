using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.collection
{
	public partial class Bag:
		nilnul.num.natural.collection.Bag<Rational_InheritFraction,Rational_InheritFraction.Eq>
	{

		public Bag(IEnumerable<Rational_InheritFraction> numbers)
			:base(
			numbers
			
			)

		{
		}
					

	}
}
