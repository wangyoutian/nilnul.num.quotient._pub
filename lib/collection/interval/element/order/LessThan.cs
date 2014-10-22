using nilnul.order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.collection.interval
{
	/// <summary>
	/// max is less than min.
	/// </summary>
	public partial class LessThan
		:OrderI<Interval>
		
	{

		public bool contains(Interval first, Interval second)
		{
			if (first.right==null)
			{
				return false;
				
			};

			if (second.left==null)
			{
				return false;
				
			}

			if (order.LessThan.Instance.contains(first.right.pinpoint,second.left.pinpoint))
			{
				return true;
			}

			if (Rational_InheritFraction.Equals(first.right.pinpoint,second.left.pinpoint))
			{

				return nilnul.bit.op.NandX.Exec( first.right.eq , second.left.eq);
				
			}
			return false;


		}
		static public partial class X
		{

				static public bool Contains(Interval first, Interval second)
		{
			if (first.right==null)
			{
				return false;
				
			};

			if (second.left==null)
			{
				return false;
				
			}

			if (order.LessThan.Instance.contains(first.right.pinpoint,second.left.pinpoint))
			{
				return true;
			}

			if (Rational_InheritFraction.Equals(first.right.pinpoint,second.left.pinpoint))
			{

				return nilnul.bit.op.NandX.Exec( first.right.eq , second.left.eq);
				
			}
			return false;


		}
		}
	}
}
