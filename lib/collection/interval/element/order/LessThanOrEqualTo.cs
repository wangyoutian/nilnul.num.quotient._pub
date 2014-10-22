using nilnul.order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.collection.interval
{
	/// <summary>
	/// max is less than or equal to min.
	/// </summary>
	public partial class LessThanOrEqualTo
		:OrderI<Interval>
		
	{

		public bool contains(Interval first, Interval second)
		{
			if (first.right == null)
			{
				return false;

			};

			if (second.left == null)
			{
				return false;

			}

			if (order.LessThan.Instance.contains(first.right.pinpoint, second.left.pinpoint))
			{
				return true;
			}

			if (Rational_InheritFraction.Equals(first.right.pinpoint, second.left.pinpoint))
			{

				return true;

			}

			return false;

			


		}
	}
}
