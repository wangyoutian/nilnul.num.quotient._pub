using nilnul.order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.order
{
	public partial class LessThan
		:
		
		//OrderI<Rational_InheritFraction>
		//,

		StrictTotalOrderI<Rational_InheritFraction>

	{
		public bool contains(Rational_InheritFraction x, Rational_InheritFraction y)
		{
			return ((x - y).sign < 0);
		}

		public class Singleton : SingletonByDefault<LessThan> { 
		
		}
		
		static public LessThan Instance = Singleton.Instance;

		static public nilnul.order.ComparerFroTotalOrder3<Rational_InheritFraction> comparer = new nilnul.order.ComparerFroTotalOrder3<Rational_InheritFraction>(Instance);

		public class SortedSet
			:SortedSet<Rational_InheritFraction>
		{

			public SortedSet()
				:base(comparer)
			{
			}
					
 
		
		}

	}
}
