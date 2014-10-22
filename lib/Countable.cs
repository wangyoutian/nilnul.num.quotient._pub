using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace nilnul.num.rational
{
    public partial class Countable
    {
        static public IEnumerable<Fraction> Enumerate()
        {
			yield return new Fraction(0, 1);
            for (BigInteger sum = 2; ; sum++)
            {
                BigInteger num;
                for ( num = 0; num < sum; num++)
                {
                    BigInteger den = sum - num;
                    //is j, i-j coprime

                    if (BigInteger.GreatestCommonDivisor(num,den)==1)
                    {
						yield return new Fraction(num,den);
						yield return new Fraction(-num, den);
                        
                    }

                }


            }
        }


		
		
    }
}
