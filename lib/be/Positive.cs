using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.be
{

	public partial class Positive
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

			public Asserted(Asserted x)
				:base(x.val)
			{


			}

			public void half() {
				val /= 2;
			}


			public Asserted toHalf() {

				var r= new Asserted(
					this
				);
				r.half();

				return r;
			
			}
			static public Asserted Half(Asserted x) {

				return new Asserted(
					x.val /2	
				);
			
			}

			public override string ToString()
			{
				return val.ToString();
			}

		}

		
		public partial class Assertion
			:nilnul.bit.be.Assertion<Rational_InheritFraction2,Be>
		{

		}

		

	






	}



}
