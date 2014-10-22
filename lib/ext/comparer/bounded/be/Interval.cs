using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational.ext.comparer.bounded.be
{
	public class Interval
		:
		nilnul.bit.Be<Bounded>
	{
		static public bool Eval(Bounded obj)
		{
			//return nilnul.order.ext.comparer.bounded.Restricted<R,rational.Comparer>.Be(
			//	obj
			//);

			return _restricted.Lower.IsRestricted(obj.lower) && _restricted.Upper.IsRestricted(obj.upper) && ext.comparer.bounded.be.NonEmpty.Eval(obj);


		}
		/// <summary>
		/// allow empty to make intersect close. for example [5,3) intersect [-3,0) = [5,0)
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		static public bool Eval_allowEmpty(Bounded obj)
		{
			//return nilnul.order.ext.comparer.bounded.Restricted<R,rational.Comparer>.Be(
			//	obj
			//);
			return _restricted.Lower.IsRestricted(obj.lower) && _restricted.Upper.IsRestricted(obj.upper);
		}

		static public bool Eval_containsNoInf_nonEmpty(Bounded obj) {
			//return nilnul.order.ext.comparer.bounded.Restricted<R,rational.Comparer>.Be(
			//	obj
			//);

			return ContainsNoInf.Eval(obj)  && ext.comparer.bounded.be.NonEmpty.Eval(obj);
				
				
		}


		public Interval()
			:
			//base(Eval_containsNoInf_nonEmpty)
			base(Eval_allowEmpty)
		{

		}

		public class Expr
			:nilnul.bit.be.Asserted<Bounded,Interval>
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
