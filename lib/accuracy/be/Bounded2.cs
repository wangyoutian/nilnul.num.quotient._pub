using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.accuracy.be
{
	public partial class Bounded2
	{
		static public bool Eval(rational.Accuracy2 accuracy)
		{
			return !(accuracy.lower is ext.InfI) && !(accuracy.upper is ext.InfI);
			throw new NotImplementedException();
		}

		public class Be
		: nilnul.bit.Be<rational.Accuracy2>
		{
			public Be()
				: base(Eval)
			{
			}
		}
		public class Expr
			:nilnul.bit.be.Asserted<rational.Accuracy2,Be>
		{
			public Expr(rational.Accuracy2 accuracy)
				:base(accuracy)
			{
			}

			public Rational_InheritFraction2 radius {
				get {
					return val.radius as ext.Literal;
				}
			}
		}
	}
}
