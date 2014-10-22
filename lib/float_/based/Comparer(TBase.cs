using nilnul.bit;
using nilnul.num.natural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.rational.float_.based
{
	public class Comparer<TBase>
		: IComparer<Based<TBase>>
		//where TBase : natural.be.plural.bigint.Asserted, new()
		where TBase : natural.be.plural.bigint.Asserted, new()
	{

		public int Compare(Based<TBase> x, Based<TBase> y)
		{
			return (x - y).sign;
			throw new NotImplementedException();
		}
		public class Le :
			nilnul.order.total.Le_boxComparer<Based<TBase>, Comparer<TBase>>
		{

			public class Ext
				: nilnul.order.extended.Order<Based<TBase>, Le>
			{

			}

		}

	}





}