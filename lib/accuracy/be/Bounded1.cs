using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.accuracy.be
{
	public partial class Bounded1
		:nilnul.bit.Be<rational.Accuracy1>
		

	{
		static public bool Be(rational.Accuracy1 accuracy) {

			return !( accuracy.lower is ext.InfI)&& !( accuracy.upper is ext.InfI);

			throw new NotImplementedException();
		}
		public Bounded1()
			:base(Be)
		{


		}




	}
}
