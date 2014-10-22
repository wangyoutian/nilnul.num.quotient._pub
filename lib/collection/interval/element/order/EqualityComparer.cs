using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.collection.interval
{
	/// <summary>
	/// max=min && min=max
	/// </summary>
	public partial class Equality
		:
		nilnul.relation.EquivalentRelationI<Interval>,
		
		IEqualityComparer<Interval>

	{
		public bool Equals(Interval x, Interval y)
		{

			return SingletonByDefaultNew<nilnul.num.rational.collection.Interval.Cut.EqualityComparer>.Instance.Equals(x.left, y.left)
				&&
				SingletonByDefaultNew<nilnul.num.rational.collection.Interval.Cut.EqualityComparer>.Instance.Equals(x.right, y.right)
			;
		}



		public int GetHashCode(Interval obj)
		{
			return obj.left.GetHashCode() ^ obj.right.GetHashCode();
		}
		static public partial class EqualityX
		{

			static public bool Contains(Interval x, Interval y)
			{
				return SingletonByDefaultNew<nilnul.num.rational.collection.Interval.Cut.EqualityComparer>.Instance.Equals(x.left, y.left)
		&&
		SingletonByDefaultNew<nilnul.num.rational.collection.Interval.Cut.EqualityComparer>.Instance.Equals(x.right, y.right)
	;
			}


		}

		public bool contains(Interval first, Interval second)
		{
			return EqualityX.Contains(first,second);
		}
	}


}
