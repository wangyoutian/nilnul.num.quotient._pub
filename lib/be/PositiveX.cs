using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.be
{

	static public partial class PositiveX
	{
		static public bool Eval(
			Rational_InheritFraction2 x
		)
		{
			return x > 0;
			
		}


	
		public partial class Be
			: nilnul.bit.Be<Rational_InheritFraction2>
		{
			public Be()
				:base(Eval)
			{

			}
		}

		public class Asserted:nilnul.bit.be.Asserted<Rational_InheritFraction2,Be>
		{
			public Asserted(Rational_InheritFraction2 val)
				:base(val)
			{

			}


		}

		
		public partial class Assertion
			:nilnul.bit.be.Assertion<Rational_InheritFraction2,Be>
		{

		}

		

	






	}



}
