using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational.neighbor
{
	public partial class Close2
		: FiniteA
	{
		



		public Close2(R lower, R upperOpenBound)
		{

			this.upperBound = upperOpenBound;
			this.lowerBound = lower;

		}

		public Close2(int a, R upperBound)
			: this(new R(a), upperBound)
		{

		}

		public Close2(int a, int b)
			: this(a, new R(b))
		{

		}

		static public Close2 CreateZero()
		{
			return new Close2(0, 0);
		}

		static public Close2 CreateLowerZero(R upper)
		{
			return new Close2(0, upper);

		}
		static public Close2 CreateUpperZero(R upper)
		{
			return new Close2(upper,0);

		}
		static public Close2 CreateSymmetric(R radius)
		{
			if (radius < 0)
			{
				return new Close2(radius, -radius);

			}
			return new Close2(-radius, radius);

		}



		public override bool contains(R n)
		{

			return n >= lowerBound && n <= upperBound;

		}





	
	}
}
