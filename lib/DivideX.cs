using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.rational
{



	static public partial class DivideX
	{


		

		static public RationalI Divide(this RationalI a, RationalI b)
		{

			return a.Multiply(b.Inverse());

		}

		static public RationalI Divide(this int i, RationalI b)
		{

			return Divide(i.ToRational(), b);

		}
		static public RationalI Divide(this int i, BigInteger b)
		{

			return Divide(i.ToRational(), b.ToRational());

		}


		public const char Sign = '/';
	}

}
