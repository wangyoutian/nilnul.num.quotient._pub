using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.accuracy.be
{
	public partial class PositiveRadius
		:nilnul.bit.Be<rational.Accuracy1>
	{
		static public bool Be(rational.Accuracy1 accuracy) {

			return ext.rel.Eq.Eval(  accuracy.radius, 0);
		
		}

	

		public PositiveRadius()
			:base(Be)
		{

		}

	}
}
