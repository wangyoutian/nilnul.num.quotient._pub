using nilnul.bit;
using nilnul.num.natural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.rational.float_
{
	public partial class SignificandIndex
	{
		public partial class Float

		{
			public partial class PluralAsBase<TPluralSingleton>
				:Float
				where TPluralSingleton:natural.be.Plural.BigInt.Suite.Ed,new()

			{

				static public natural.be.Plural.BigInt.Suite.Ed Radix = SingletonByDefaultNew<TPluralSingleton>.Instance;
				public PluralAsBase()
					:base(SingletonByDefaultNew<TPluralSingleton>.Instance.val)
				{

				}







			}
			
		}





	}
}