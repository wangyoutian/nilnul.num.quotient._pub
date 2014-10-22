using nilnul.num.natural;
using nilnul.num.rational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Fraction2 = nilnul.num.rational.Fraction_BigInteger_PositiveNatural3_;

namespace nilnul.num.rational.cf
{
	static public partial class CfX
	{

		static public Fraction2 ToFraction(IEnumerable<long> cf)
		{

			if (cf == null)
			{
				return null;
			}
			if (cf.Count()==0)
			{
				throw new Exception();
				
			}
			return ToFraction_countPositive(cf);


		}

		static public Fraction2 ToFraction_countPositive(IEnumerable<long> cf_countPositive) {

			
			if (cf_countPositive.Count()==1)
			{
				return new Fraction2(cf_countPositive.First(), 1);
				

			}
			var subFraction = Fraction2.Inverse( ToFraction_countPositive(cf_countPositive.Skip(1)));

			return Fraction2.AddAndSimplify(cf_countPositive.First(), subFraction);
		
		}



		static public BigInteger CalcFromPreviousTwoTerms(BigInteger aK,BigInteger termK_1,BigInteger termK_2) {
			return aK * termK_1 + termK_2;
		}

	

		
		



		static public List<long> FroDouble_nonNeg(double x_nonNeg, double tailUpper_nonNeg)
		{

			var intTail = nilnul_obj.num.NumX.IntegerAndTail_forNonNeg(x_nonNeg);

			var tail = intTail.Item2;

			var denominants = new List<long>();

			denominants.Add(intTail.Item1);

			if (tail > tailUpper_nonNeg)
			{

				var tailInverse = 1 / tail;

				var fraction = FroDouble_nonNeg(tailInverse, tailUpper_nonNeg);

				denominants.AddRange(fraction);


			}

			return denominants;

		}

	}
}
