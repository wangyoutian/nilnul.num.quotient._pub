using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational
{

	/// <summary>
	/// interval contains 0
	/// </summary>

	public partial class Accuracy
		:nilnul.obj.Be<Interval2>
	{
		static public bool Be(
				Interval2 interval
		
		) {

			return interval.contains(0);
			throw new NotImplementedException();
		}

		public class Adj:
			nilnul.obj.Be<Interval2>

		{
			public Adj()
				:base(Be)
			{

			}

		}
		public Accuracy()
			:base(Be)
		{

		}

		public class Expr
			:nilnul.bit.be.Asserted<Interval2,Accuracy>
			,
			nilnul.collection.ContainsI<Rational_InheritFraction2>
			,
			nilnul.order.bound.Pair_TBoundI<ext.Bound>

		{
			public Expr(Interval2 interval)
				:base(interval)
			{

			}
			
			public ExtendedI radius
			{

				get
				{

					return ext.op.Min.Eval(
						ext.op.Abs.Eval(val.val.lower.pinpoint),
						val.val.upper.pinpoint
					);
				}

			}



			public bool contains(Rational_InheritFraction2 item)
			{
				return val.contains(item);
				throw new NotImplementedException();
			}



			public ext.Bound upper
			{
				get {
					return val.val.upper;
					
					throw new NotImplementedException(); }
			}

			public ext.Bound lower
			{
				get {
					return val.val.lower;
					throw new NotImplementedException(); }
			}
		}




	}
}
