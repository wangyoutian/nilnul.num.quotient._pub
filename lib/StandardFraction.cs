using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.rational
{
	/// <summary>
	/// coprime.
	/// </summary>
	public partial class StandardFraction
	{
		private BigInteger _numerator;

		public BigInteger numerator
		{
			get { return _numerator; }
			//set { _numerator = value; }
		}

		private BigInteger _denominator;

		public BigInteger denominatro
		{
			get { return _denominator; }
			//set { _denominator = value; }
		}


		public StandardFraction(BigInteger numerator,BigInteger denominator)
		{
			var gcd=BigInteger.GreatestCommonDivisor(numerator, denominator);
			if (denominator<=0)
			{
				_numerator = -numerator / gcd;
				_denominator = -denominator / gcd;


			}
			else
			{
				_numerator = numerator / gcd;
				_denominator = denominator / gcd;
			}


		}
					
		
		
	}
}
