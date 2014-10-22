using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.natural;
using nilnul.num.rational.float_.rel;

namespace nilnul.num.rational
{

	
	static public partial class FloatX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="significand"></param>
		/// <param name="base"></param>
		/// <returns></returns>
		/// <remarks>
		/// shift significand to power
		/// </remarks>
		static public Tuple<natural.Natural, BigInteger> SignificandToPower(this BigInteger significand, Plural @base)
		{

			Natural n = (Natural)0;
			BigInteger remainder = 0;

			var d = BigInteger.DivRem(significand, @base, out remainder);
			while (remainder == 0)
			{
				significand = d;
				n++;

				d = BigInteger.DivRem(significand, @base, out remainder);

			}

			return new Tuple<Natural, BigInteger>(n, significand);



		}

		static public void AssertSameBase(Float a,Float b) {

			 SameBaseX.AssertSameBase(a, b);
			
		}

		static public bool Eq(Float a,Float b) { 
			AssertSameBase(a,b);

			return a.reduce2().significand == b.reduce2().significand && a.power == b.power;
		
		}
	}
}
