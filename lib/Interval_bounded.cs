using nilnul.num.rational.cut;
using nilnul.order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational
{
	public partial class Interval_bounded
		: 
		nilnul.num.rational.ext.comparer.bounded.Restricted.Expr
	//,	nilnul.order.ext.comparer.bounded.Restricted<Rational_InheritFraction2,Comparer>.Expr
	{



		public Interval_bounded( ext.Bound left,ext.Bound right)
			:base(left,right)
		{

		}

		public Interval_bounded(ext.comparer.bounded.Restricted.Expr restrcited)
			:base(restrcited)
		{

		}

		public Interval_bounded(
			nilnul.order.ext.comparer.Bounded<Rational_InheritFraction2,rational.Comparer,ext.Bound> bounded
	
		)
			:this(
				bounded.lower
			,
			bounded.upper
			)
		{


		}

		public ExtendedI midpoint
		{

			get
			{
				return ext.op.Scale.Half(
					ext.op.Add.Eval(this.val.lower.pinpoint, this.val.upper.pinpoint)

				);
			}

		}

		public ExtendedI radius {
			get {
				return ext.op.Scale.Half(
							ext.op.Subtract.Eval(this.val.upper.pinpoint, this.val.lower.pinpoint)
				
				);
			}
		}



		public Interval_bounded(
			nilnul.order.ext.comparer.Bounded<Rational_InheritFraction2,rational.Comparer> bounded
	
		)
			:this(
				new ext.Bound(
				bounded.lower)

			,
			new ext.Bound(
			bounded.upper)
			)
		{


		}


		public Interval_bounded(R a, bool lowerOpenFalseCloseTrue, R b, bool upperOpenFalseCloseTrue)
			:this(new ext.Bound(lowerOpenFalseCloseTrue,a),new ext.Bound(upperOpenFalseCloseTrue,b))
		{

		}

		public Interval_bounded(ExtendedI x, bool lowerClose, ExtendedI y, bool upperClose)
			: this(
				new ext.Bound(lowerClose, x)
			,
			new ext.Bound(upperClose, y)
			)
		{

		}

		public Interval_bounded(ExtendedI<R> x, bool lowerClose, ExtendedI<R> y, bool upperClose)
			: this(
				new ext.Bound(lowerClose, x)
			,
			new ext.Bound(upperClose, y)
			)
		{

		}



		static public Interval_bounded Create(R a, bool lowerOpenFalseCloseTrue, R b, bool upperOpenFalseCloseTrue)
		{


			return new Interval_bounded(
				new ext.Bound(lowerOpenFalseCloseTrue, a)
				,
				new ext.Bound(upperOpenFalseCloseTrue, b)
			);

		}

		static public Interval_bounded Create(ExtendedI a, bool lowerOpenFalseCloseTrue, R b, bool upperOpenFalseCloseTrue)
		{


			return new Interval_bounded(
				new ext.Bound(lowerOpenFalseCloseTrue, a)
				,
				new ext.Bound(upperOpenFalseCloseTrue, b)
			);

		}

		static public Interval_bounded Create(ExtendedI<R> a, bool lowerOpenFalseCloseTrue, R b, bool upperOpenFalseCloseTrue)
		{


			return new Interval_bounded(
				new ext.Bound(lowerOpenFalseCloseTrue, a)
				,
				new ext.Bound(upperOpenFalseCloseTrue, b)
			);

		}

		static public Interval_bounded Create(R a, bool lowerOpenFalseCloseTrue, ExtendedI<R> b, bool upperOpenFalseCloseTrue)
		{


			return new Interval_bounded(
				new ext.Bound(lowerOpenFalseCloseTrue, a)
				,
				new ext.Bound(upperOpenFalseCloseTrue, b)
			);

		}

		static public Interval_bounded CreateOpen(R a, R b)
		{
			return Create(a, false, b, false);
		}
		static public Interval_bounded CreateOpen_aftOrdered(R a, R b)
		{
			if (a<b)
			{
				return CreateOpen(a, b);
				
			}
			return CreateOpen(b, a);
			//return Create(a, false, b, false);
		}

		static public Interval_bounded CreateOpen(ExtendedI a, R b)
		{
			return Create(a, false, b, false);
		}
		static public Interval_bounded CreateOpen(ExtendedI<R> a, R b)
		{
			return Create(a, false, b, false);
		}
		static public Interval_bounded CreateOpen(R a, ExtendedI<R> b)
		{
			return Create(a, false, b, false);
		}

		static public Interval_bounded CreateClopen(R a, R b

)
		{


			return new Interval_bounded(a,true,b,false);

		}
		static public Interval_bounded CreateSingleton(R x)
		{
			return new Interval_bounded(x, true, x, true);
		}

		static public Interval_bounded CreateSingleton(ExtendedI x)
		{
			return new Interval_bounded(x, true, x, true);
		}
		static public Interval_bounded CreateSingleton(ExtendedI<R> x)
		{
			return new Interval_bounded(x, true, x, true);
		}

		static public Interval_bounded CreateClose(R a, R b)
		{
			return Create(a, true, b, true);
		}

		static public Interval_bounded CreateOpenClose(R a, R b)
		{
			return new Interval_bounded(
				a,true
				,
				b,true
			);


		}

		static public Interval_bounded CreateZero() {
			return new Interval_bounded(0, true, 0, true);
		
		}


		

		
					
	}
}
