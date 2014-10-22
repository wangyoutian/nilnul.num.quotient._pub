using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.ext.bound.op
{
	public partial class Multi
	{
		static public Bound Eval(Bound x,Bound y) {
			return new Bound(
				x.openFalseCloseTrue&&y.openFalseCloseTrue
				,
				ext.op.Multi.Eval(x.pinpoint,y.pinpoint)
				
			);
		}
	}
}
