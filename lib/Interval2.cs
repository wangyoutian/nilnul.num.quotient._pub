using nilnul.num.rational.cut;
using nilnul.order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational
{
	public partial class Interval2
		: 
		nilnul.num.rational.ext.comparer.bounded.Restricted.Expr
	//,	nilnul.order.ext.comparer.bounded.Restricted<Rational_InheritFraction2,Comparer>.Expr
	{



		public Interval2( ext.Bound left,ext.Bound right)
			:base(left,right)
		{

		}

		public Interval2(ext.comparer.bounded.Restricted.Expr restrcited)
			:base(restrcited)
		{

		}

		public Interval2(
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



		public Interval2(
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


		public Interval2(R a, bool lowerOpenFalseCloseTrue, R b, bool upperOpenFalseCloseTrue)
			:this(new ext.Bound(lowerOpenFalseCloseTrue,a),new ext.Bound(upperOpenFalseCloseTrue,b))
		{

		}

		public Interval2(ExtendedI x, bool lowerClose, ExtendedI y, bool upperClose)
			: this(
				new ext.Bound(lowerClose, x)
			,
			new ext.Bound(upperClose, y)
			)
		{

		}

		public Interval2(ExtendedI<R> x, bool lowerClose, ExtendedI<R> y, bool upperClose)
			: this(
				new ext.Bound(lowerClose, x)
			,
			new ext.Bound(upperClose, y)
			)
		{

		}



		static public Interval2 Create(R a, bool lowerOpenFalseCloseTrue, R b, bool upperOpenFalseCloseTrue)
		{


			return new Interval2(
				new ext.Bound(lowerOpenFalseCloseTrue, a)
				,
				new ext.Bound(upperOpenFalseCloseTrue, b)
			);

		}

		static public Interval2 Create(ExtendedI a, bool lowerOpenFalseCloseTrue, R b, bool upperOpenFalseCloseTrue)
		{


			return new Interval2(
				new ext.Bound(lowerOpenFalseCloseTrue, a)
				,
				new ext.Bound(upperOpenFalseCloseTrue, b)
			);

		}

		static public Interval2 Create(ExtendedI<R> a, bool lowerOpenFalseCloseTrue, R b, bool upperOpenFalseCloseTrue)
		{


			return new Interval2(
				new ext.Bound(lowerOpenFalseCloseTrue, a)
				,
				new ext.Bound(upperOpenFalseCloseTrue, b)
			);

		}

		static public Interval2 Create(R a, bool lowerOpenFalseCloseTrue, ExtendedI<R> b, bool upperOpenFalseCloseTrue)
		{


			return new Interval2(
				new ext.Bound(lowerOpenFalseCloseTrue, a)
				,
				new ext.Bound(upperOpenFalseCloseTrue, b)
			);

		}

		static public Interval2 CreateOpen(R a, R b)
		{
			return Create(a, false, b, false);
		}
		static public Interval2 CreateOpen_aftOrdered(R a, R b)
		{
			if (a<b)
			{
				return CreateOpen(a, b);
				
			}
			return CreateOpen(b, a);
			//return Create(a, false, b, false);
		}

		static public Interval2 CreateOpen(ExtendedI a, R b)
		{
			return Create(a, false, b, false);
		}
		static public Interval2 CreateOpen(ExtendedI<R> a, R b)
		{
			return Create(a, false, b, false);
		}
		static public Interval2 CreateOpen(R a, ExtendedI<R> b)
		{
			return Create(a, false, b, false);
		}

		static public Interval2 CreateClopen(R a, R b

)
		{


			return new Interval2(a,true,b,false);

		}
		static public Interval2 CreateSingleton(R x)
		{
			return new Interval2(x, true, x, true);
		}

		static public Interval2 CreateSingleton(ExtendedI x)
		{
			return new Interval2(x, true, x, true);
		}
		static public Interval2 CreateSingleton(ExtendedI<R> x)
		{
			return new Interval2(x, true, x, true);
		}

		static public Interval2 CreateClose(R a, R b)
		{
			return Create(a, true, b, true);
		}

		static public Interval2 CreateOpenClose(R a, R b)
		{
			return new Interval2(
				a,true
				,
				b,true
			);


		}

		static public Interval2 CreateZero() {
			return new Interval2(0, true, 0, true);
		
		}


		

		
					
	}
}
