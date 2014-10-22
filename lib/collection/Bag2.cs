using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.collection
{
	public partial class Bag2:
		nilnul.num.natural.collection.Bag<Rational_InheritFraction,Rational_InheritFraction.Eq>
	{

		public Bag2()
			
		{
		}
					

		public Bag2(IEnumerable<Rational_InheritFraction> numbers)
			:base(numbers)

		{
		}
					

	}
}
