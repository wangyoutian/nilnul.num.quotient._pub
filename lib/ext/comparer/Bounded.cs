using nilnul.order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational.ext.comparer
{
	public partial class Bounded
		:nilnul.order.ext.comparer.Bounded_ComparerSingleton<R,rational.Comparer,Bound>
	{
		public Bounded(Bound lower,Bound upper)
			:base(lower,upper)
		{

		}

		public Bounded(
			nilnul.order.ext.Bound<R> lower
			, 
			nilnul.order.ext.Bound<R> upper
		)
			:this(new Bound(lower.openFalseCloseTrue,lower.pinpoint)
			,new Bound(upper)
				
			)
		{


		}

		public Bounded(
			nilnul.order.Bound<ExtendedI<R>> lower
			,
			nilnul.order.Bound<ExtendedI<R>> upper
			
		)
			:
			this(
				new nilnul.order.ext.Bound<R>(lower)
				,
				new nilnul.order.ext.Bound<R>(upper)
			)
		{

		}

		public Bounded(
			nilnul.order.ext.comparer.Bounded<R,rational.Comparer> bounded
			
		)
			:this(bounded.lower,bounded.upper)
		{

		}


	}
}
