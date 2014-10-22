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

	public partial class Accuracy2
		:
		interval.be.Accuracy.Expr
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
		public Accuracy2(Interval2 interval)
			: base(interval)
		{

		}

		public Accuracy2(ext.comparer.Bounded x)
			:this(
				new Interval2(x)
			)
		{

		}

		public Accuracy2(ext.comparer.bounded.Restricted.Expr restricted)
			: this(
				new Interval2(restricted)
			)
		{

		}


		public Accuracy2(R lower, bool lowerClose, R upper, bool upperClose)
			: base(new Interval2(
				lower, lowerClose
				,
				upper, upperClose

			))
		{

		}

		public Accuracy2(ext.Bound lower, ext.Bound upper)
			: base(new Interval2(lower, upper))
		{

		}


		public ExtendedI midpoint {

			get {
				return ext.op.Scale.Half(
					ext.op.Add.Eval(lower.pinpoint,upper.pinpoint)
					
				);
			}
		
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
		public Accuracy2 circumscribed {
			get { 
				return CreateSymmetricFroAbs(
					ext.bound.UpperComparer.Max(
						ext.bound.op.Abs.Eval(val.val.lower),
						val.val.upper
					)
				);
		
			}
		}

		public Accuracy2 span
		{
			get
			{
				return CreateSymmetric(
					ext.bound.UpperComparer.Min(
						ext.bound.op.Abs.Eval(val.val.lower),
						val.val.upper
					)
				);
			}
		}
		public Accuracy2 inscribed
		{
			get
			{
				return CreateSymmetric(
					ext.bound.UpperComparer.Min(
						ext.bound.op.Abs.Eval(val.val.lower),
						val.val.upper
					)
				);
			}
		}

		public Accuracy2 half() {
			return accuracy.op.Scale.Half(this);
		}
		public bool isZero()
		{

			return lower.isZeroClose() && upper.isZeroClose();

		}

		public bool isSubSetOf(Accuracy2 other) {

			return accuracy.rel.Subset.Eval(this, other);
		
		}
		public bool isNotSubSetOf(Accuracy2 other) {

			return !isSubSetOf(other);
		
		}

		public override string ToString()
		{
			return val.ToString();
		}


		public bool contains(Rational_InheritFraction2 item)
		{
			return val.contains(item);
			throw new NotImplementedException();
		}

		public bool isBounded()
		{

			return lower.isFinite() && upper.isFinite();

		}

		public bool isNotBounded()
		{

			return !isBounded();

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

		public static Accuracy2 CreateClopen(R a, R b)
		{

			return new Accuracy2(
				Interval2.CreateClopen(a, b)

			);

		}
		public static Accuracy2 CreateClose(R a, R b)
		{

			return new Accuracy2(
				Interval2.CreateClose(a, b)

			);

		}

		public static Accuracy2 CreateClopen(int a, R b)
		{

			return new Accuracy2(
				Interval2.CreateClopen(a, b)

			);

		}
		public static Accuracy2 CreateOpen(int a, R b)
		{

			return new Accuracy2(
				Interval2.CreateOpen(a, b)

			);

		}

		static public Accuracy2 CreateSingle(R x)
		{
			return new Accuracy2(x, true, x, true);

		}



		public static Accuracy2 CreateSymmetric(ext.Bound cut)
		{


			if (ext.Comparer.IsNeative(cut.pinpoint))
			{
				return new Accuracy2(
					cut,

					rational.ext.bound.op.Abs.Eval(cut)


				);

			}

			return new Accuracy2(

						rational.ext.bound.op.Negate.Eval(cut)
							,
						cut

				);

		}

		static public Tuple<Rational_InheritFraction2, Accuracy2> _Shift__intervalNotEmpty_bounded(Interval2 interval_nonEmpty_bounded) {

			throw new NotImplementedException();


			


		}

		public static Accuracy2 CreateSymmetricFroAbs(ext.Bound nonNegBound)
		{


		

			return new Accuracy2(

						rational.ext.bound.op.Negate.Eval(nonNegBound)
							,
						nonNegBound

				);

		}

		public static Accuracy2 CreateSymmetricOpenFroAbs(R x)
		{




			return new Accuracy2(

						-x, false
							,
						x, false

				);

		}

		public static Accuracy2 CreateSymmetricOpenUnit()
		{




			return CreateSymmetricOpenFroAbs(1);
		}



		public static Accuracy2 CreateSymmetric(bool openFalseCloseTrue, R pinpoint)
		{

			return CreateSymmetric(
				new ext.Bound(openFalseCloseTrue, pinpoint)
			);

		}

		public static Accuracy2 CreateSymmetricOpen(R pinpoint)
		{

			return CreateSymmetric(
				false, pinpoint
			);

		}

		public static Accuracy2 CreateSymmetricClose(R pinpoint)
		{

			return CreateSymmetric(
				true, pinpoint
			);

		}


		public static Accuracy2 CreateLowerZeroClose(R upper, bool openFalseCloseTrue)
		{
			return new Accuracy2(
				0, true
				,
				upper,
				openFalseCloseTrue

			);
		}
		public static Accuracy2 CreateLowerZeroClose(ext.Bound upper)
		{
			return new Accuracy2(
				ext.Bound.CreateZeroClose()
				,
				upper


			);
		}

		public static Accuracy2 ZeroSingleton = CreateZero();
		public static Accuracy2 CreateZero()
		{

			return new Accuracy2(
				ext.Bound.CreateZeroClose()
				,
				ext.Bound.CreateZeroClose()

			);
		}




	}
}
