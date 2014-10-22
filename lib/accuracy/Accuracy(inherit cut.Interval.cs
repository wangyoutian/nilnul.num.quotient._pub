using nilnul.num.rational.cut;
using nilnul.order.cut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational.accuracy
{

    public partial class Accuracy
		:interval.Interval
    {

		public Accuracy()
			:this(null,null)
		{

		}
		public static Accuracy CreateClopen(R a, R b) {

			return new Accuracy(
				interval.Interval.CreateClopen(a,b)
								
			);
	
		}

		public static Accuracy CreateClopen(int a, R b) {

			return new Accuracy(
				interval.Interval.CreateClopen(a,b)
								
			);
	
		}

		public static Accuracy CreateSymmetric(Cut cut) {

			if (cut==null)
			{
				return new Accuracy();
				
			}
			if (cut.pinpoint<=0)
			{
				return new Accuracy(
					cut,
					rational.cut.op.Negate.Eval(cut)
					
					
				);
				
			}

			return new Accuracy(

						rational.cut.op.Negate.Eval(cut)
							,
						cut
	
				);
		
		}

		public static Accuracy CreateSymmetric(bool openFalseCloseTrue,R pinpoint)
		{

			return CreateSymmetric(
				new Cut(openFalseCloseTrue,pinpoint)	
			);

		}


		public static Accuracy CreateLowerZeroClose(R upper, bool openFalseCloseTrue) {
			return new Accuracy(
				interval.Interval.Create(0,true,upper,openFalseCloseTrue)	
			);
		}

		public static Accuracy CreateZero() {

			return new Accuracy(
				Cut.CreateZeroClose()
				,
				Cut.CreateZeroClose()
					
			);
		}


		public Accuracy(interval.Interval interval)
			:this(interval.lower,interval.upper)
		{


		}

		public Accuracy(Cut a,Cut b)
			:base(a,b)
		{
			nilnul.bit.Assertion.True(contains(0));

		}

		public Accuracy getRadiusAccuracy() {
			return CreateSymmetric(
				cut.op.Min.Eval(
					cut.op.Abs.Eval(this.lower)
					,
					this.upper
				)
			);
		}
		public R radius {

			get {
				if (lower==null)
				{
					if (upper==null)
					{
						return null;
					}
					return upper.pinpoint;
					
				}
				if (upper==null)
				{
					return lower.pinpoint;
					
				}

				return rational.op.MinX.Do(lower.pinpoint, upper.pinpoint);
			}
		}

    }
}
