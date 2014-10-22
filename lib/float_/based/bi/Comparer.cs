using nilnul.bit;
using nilnul.num.natural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.rational.float_.based.bi
{
	public class Comparer
		: based.Comparer<natural.be.plural.bigint.asserted.Two>
		,
		IComparer<Binary>
	{

	


		public int Compare(Binary x, Binary y)
		{
			return base.Compare(x, y);
			throw new NotImplementedException();
		}

		public class Le
			:nilnul.order.total.Le_boxComparer<Binary,Comparer>
		{
			
		}

		public class Lt
			:nilnul.order.total.Lt_boxComparer<Binary,Comparer>
		{

		}

		public class Ge
			:nilnul.order.total.Ge_boxComparer<Binary,Comparer>
		{

		}

		public class Gt
			:nilnul.order.total.Ge_boxComparer<Binary,Comparer>
		{
			
		}
		public class Eq
			:nilnul.order.be.total.Eq_boxComparer<Binary,Comparer>
		{

		}
		public class Ne
			:nilnul.order.rel.total.comparer.Ne<Binary,Comparer>
		{
			
		}


	}





}