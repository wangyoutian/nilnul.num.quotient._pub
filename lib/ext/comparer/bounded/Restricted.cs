using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational.ext.comparer.bounded
{
	public class Restricted
		:
		nilnul.bit.Be<Bounded>
	{
		static public bool Be(Bounded obj) {
			//return nilnul.order.ext.comparer.bounded.Restricted<R,rational.Comparer>.Be(
			//	obj
			//);

			return comparer.bounded.be.Interval.Eval_allowEmpty(obj);

			//return _restricted.Lower.IsRestricted(obj.lower) && _restricted.Upper.IsRestricted(obj.upper)  && ext.comparer.bounded.be.NonEmpty.Eval(obj);
				
				
		}

		public Restricted()
			:base(Be)
		{

		}

		public class Expr
			:nilnul.bit.be.Asserted<Bounded,Restricted>
			,
			nilnul.collection.ContainsI<R>
		{
			public Expr(Bounded bounded)
				:base(bounded)
			{

			}

			public Expr(Bound lower, Bound upper)
				:this(new Bounded(lower,upper))
			{

			}

			public Expr(Expr restricted)
				:this(restricted.val.lower,restricted.val.upper)
			{

			}

			public bool isBounded() {
				return val.lower.isNotInf() && val.upper.isNotInf();
			}


			public bool contains(R item)
			{
				return val.contains(
					new ext.Literal(item)	
				);
				throw new NotImplementedException();
			}

			public override string ToString()
			{
				return val.ToString();
			}
		}


	}
}
