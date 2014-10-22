using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational
{

	/// <summary>
	/// interval contains 0
	/// </summary>

	public partial class Accuracy1
		: nilnul.bit.be.Asserted<Interval2, nilnul.num.rational.Accuracy1.Adj>
		,
		nilnul.collection.ContainsI<Rational_InheritFraction2>
		,
		nilnul.order.bound.Pair_TBoundI<ext.Bound>
	{
		static public bool Be(
				Interval2 interval

		)
		{

			return interval.contains(0);
			throw new NotImplementedException();
		}

		public class Adj :
			nilnul.bit.Be<Interval2>
		{
			public Adj()
				: base(Be)
			{

			}

		}
		public Accuracy1(Interval2 interval)
			: base(interval)
		{

		}

		public Accuracy1(ext.comparer.bounded.Restricted.Expr restricted)
			:this(
				new Interval2(restricted)
			)
		{

		}

		public Accuracy1(R lower, bool lowerClose, R upper, bool upperClose)
			:base(new Interval2(
				lower,lowerClose
				,
				upper,upperClose
				
			))
		{

		}

		public Accuracy1(ext.Bound lower, ext.Bound upper)
			:base(new Interval2(lower,upper))
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
			get
			{
				return val.val.upper;

				throw new NotImplementedException();
			}
		}

		public ext.Bound lower
		{
			get
			{
				return val.val.lower;
				throw new NotImplementedException();
			}
		}

		public static Accuracy1 CreateClopen(R a, R b)
		{

			return new Accuracy1(
				Interval2.CreateClopen(a, b)

			);

		}

		public static Accuracy1 CreateClopen(int a, R b)
		{

			return new Accuracy1(
				Interval2.CreateClopen(a, b)

			);

		}

		public static Accuracy1 CreateSymmetric(ext.Bound cut)
		{

			
			if (ext.Comparer.IsNeative(cut.pinpoint) )
			{
				return new Accuracy1(
					cut,

					rational.ext.bound.op.Abs.Eval(cut)


				);

			}

			return new Accuracy1(

						rational.ext.bound.op.Negate.Eval(cut)
							,
						cut

				);

		}

		public static Accuracy1 CreateSymmetric(bool openFalseCloseTrue, R pinpoint)
		{

			return CreateSymmetric(
				new ext.Bound(openFalseCloseTrue, pinpoint)
			);

		}


		public static Accuracy1 CreateLowerZeroClose(R upper, bool openFalseCloseTrue)
		{
			return new Accuracy1(
				0, true
				,
				upper,
				openFalseCloseTrue

			);
		}
		public static Accuracy1 CreateLowerZeroClose(ext.Bound upper)
		{
			return new Accuracy1(
				ext.Bound.CreateZeroClose()
				,
				upper
				

			);
		}

		public static Accuracy1 CreateZero()
		{

			return new Accuracy1(
				ext.Bound.CreateZeroClose()
				,
				ext.Bound.CreateZeroClose()

			);
		}




	}
}
