using nilnul.num.rational.cut;
using nilnul.order.cut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational.interval
{
	public partial class Interval
		:nilnul.order.cut.Interval<R,Comparer,rational.cut.Cut>
	{
		public Interval(Cut a, Cut b )
			:base(a,b)
		{

		}

		static public Interval Create(R a, bool lowerOpenFalseCloseTrue, R b, bool upperOpenFalseCloseTrue) {

			
			return new Interval(
				new Cut(lowerOpenFalseCloseTrue,a)
				,
				new Cut(upperOpenFalseCloseTrue,b)
			);
		
		}

		static public Interval CreateOpen(R a,R b
			
		) {

			if (a==null)
			{
				if (b==null)
				{
					return new Interval(null, null);
				}
				return new Interval(null, new Cut(false, b));
			}
			if (b==null)
			{
				return new Interval(new Cut(false, a), null);
				
			}
			return Create(a, false, b, false);
		
		}

		static public Interval CreateClopen(R a, R b

)
		{
			
		
			return new Interval(new Cut(true,a), b==null?null:new Cut(false,b));

		}

		static public Interval CreateClose(R a,R b) {
			return Create(a, true, b, true);
		}

		static public Interval CreateOpenClose(R a, R b) { 
				return new Interval(
					a==null?null: new Cut(false,a)
					,
					new Cut(true,b)
				);
	
		
		}



		


	}
}
