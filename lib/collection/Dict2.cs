using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.collection
{
	public partial class Dict2:
		nilnul.num.natural.collection.Dict<Rational_InheritFraction,Rational_InheritFraction.Eq>
			{

		public Dict2()
		{
		}
					

		public Dict2(IEnumerable<Rational_InheritFraction> numbers)
			:base(numbers)

		{
		}
					

	}
}
