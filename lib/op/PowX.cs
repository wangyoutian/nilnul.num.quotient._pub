using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.rational.op
{
	public partial class PowX
	{

		static public Rational_InheritFraction2 Do(Rational_InheritFraction2 r,BigInteger index) {
			return Rational_InheritFraction2.Divide(
				Do(r.numerator,index)
				,
				Do(r.denominatorAsBigInt,index)
			);
		}
		static public Rational_InheritFraction Eval(
			BigInteger base_,
			BigInteger index
			) {
				if (index>=0)
				{
					return new Rational_InheritFraction( nilnul.num.int_.op.Pow.Eval(base_, index));
					
				}
				return new Rational_InheritFraction(1, nilnul.num.int_.op.Pow.Eval(base_, -index));

				


			throw new NotImplementedException();
		}

		static public Rational_InheritFraction2 Do(
		BigInteger base_,
		BigInteger index
		)
		{
			if (index >= 0)
			{
				return new Rational_InheritFraction2(nilnul.num.int_.op.Pow.Eval(base_, index));

			}
			return  Rational_InheritFraction2.Create(1, nilnul.num.int_.op.Pow.Eval(base_, -index));




			throw new NotImplementedException();
		}



		static public Rational_InheritFraction Eval_basePlural(
	BigInteger base_plural,
	BigInteger index
	)
		{
			if (index >= 0)
			{
				return new Rational_InheritFraction(nilnul.num.int_.op.Pow.Eval(base_plural, index));

			}
			return new Rational_InheritFraction(1, nilnul.num.int_.op.Pow.Eval(base_plural, -index));




			throw new NotImplementedException();
		}

		static public Rational_InheritFraction2 Eval_basePlural2(
BigInteger base_plural,
BigInteger index
)
		{
			if (index >= 0)
			{
				return new Rational_InheritFraction2(nilnul.num.int_.op.Pow.Eval(base_plural, index));

			}
			return Rational_InheritFraction2.Create(1, nilnul.num.int_.op.Pow.Eval(base_plural, -index));




			throw new NotImplementedException();
		}


		static public Rational_InheritFraction Eval_Zero_Zero_retOne(
	)
		{
			return 1;

			throw new NotImplementedException();
		}

		static public Rational_InheritFraction Eval_Zero_Zero_exception(
)
		{
			throw new DivideByZeroException();

			throw new NotImplementedException();
		}


	}
}
