using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.collection
{
	public partial class Dict:
		nilnul.collection.bag.Bag_dictNatural<Rational_InheritFraction,Rational_InheritFraction.Eq>
	{

		public Dict()
			
		{
		}
					

		public Dict(IEnumerable<Rational_InheritFraction> numbers)
			:base(numbers)

		{
		}
					

	}
}
