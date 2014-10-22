using nilnul.order;
using nilnul.order.comparer.ext;
using nilnul.order.ext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational.ext
{
	public partial class Bound
		:nilnul.order.ext.Bound<R>
	{
		public Bound(
			bool openFalseCloseTrue
			,
			ExtendedI<R> pinpoint
		)
			:base(openFalseCloseTrue,pinpoint)
		{

		}

		public Bound(bool openFalseCloseTrue,R pinpoint)
			:this(openFalseCloseTrue,new ext.Literal(pinpoint) as ExtendedI)
		{

		}

		public Bound(nilnul.order.ext.Bound<R> bound)
			:this(bound.openFalseCloseTrue,bound.pinpoint)
		{

		}

		public Bound(nilnul.order.Bound<ExtendedI<R>> bound)
			:this(
			bound.openFalseCloseTrue
			,
			bound.pinpoint
		)
		{

		}

		public bool isInfClose() {
			return openFalseCloseTrue && pinpoint is nilnul.order.ext.InfI;
		}

		public bool isNotInfClose() {
			return !isInfClose();
		}

		public bool isFinite() {
			return base.isFinite();
		}

		public bool isNotInf() {
			return !isInf();
		}

		public bool isNegOpen() {
			return pinpoint is nilnul.order.ext.NegInfI && !openFalseCloseTrue;
		}

		public bool isPosOpen() {
			return pinpoint is PosInfI && !openFalseCloseTrue;
		}


		public bool isNegInf()
		{
			return pinpoint is nilnul.order.ext.NegInfI;
		}
		public bool isNotNegInf()
		{
			return !isNegInf();
		}
		public bool isPosInf()
		{
			return pinpoint is nilnul.order.ext.PosInfI;
		}
		public bool isNotPosInf()
		{
			return !isPosInf();
		}

		public bool isZeroClose() {

			return ext.rel.Eq.Eval(pinpoint, 0) && openFalseCloseTrue;
		
		}

		static public Bound CreateZeroClose() {
			return new Bound(
				true,0	
			);
		
		}

	

		static public Bound Abs(Bound x) {
			return new Bound(x.openFalseCloseTrue, ext.op.Abs.Eval( x.pinpoint));
		}





		


		
	}
}
