using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

using nilnul.num.natural;

using Fraction2 = nilnul.num.rational.Fraction_natural;
using nilnul_obj.op;

using R = nilnul.num.rational.Rational_InheritFraction;
using Q = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational.op
{
	public partial class DivideX
	{

		static public Q Half() {
			return Inverse(2);
		}

		static public Q Inverse(int i)
		{
			return Q.Inverse(i);
		}
		static public Q Inverse(BigInteger i)
		{
			return Q.Inverse(i);
		}
		/// <summary>
		/// note this is different from Fraction.Simplify in that Divide is in the domain Rational. Fraction.simplify is in the domain of Fraction.
		/// </summary>
		/// <param name="numerator"></param>
		/// <param name="denominator"></param>
		/// <returns></returns>
		static public RationalI Eval(BigInteger numerator, BigInteger denominator)
		{

			if (denominator == 0)
			{
				throw new DivideByZeroException();

			}

			BigInteger gcd = BigInteger.GreatestCommonDivisor(numerator, denominator);

			///gcd cannot be zero due to normalizeSign(). so gcd>0.


			numerator = numerator / gcd;
			denominator = denominator / gcd;

			if (denominator < 0)
			{
				denominator = -denominator;
				numerator = -numerator;


			}

			if (denominator == 1)
			{
				return new BigInt(numerator);

			}
			return new Fraction__LazyValidated(numerator, denominator);

		}



		static public Fraction2 _Eval2(BigInteger numerator_natural, BigInteger _denominator_positive)
		{

			BigInteger gcd = BigInteger.GreatestCommonDivisor(numerator_natural, _denominator_positive);

			///gcd cannot be zero due to normalizeSign(). so gcd>0.

			numerator_natural = numerator_natural / gcd;
			_denominator_positive = _denominator_positive / gcd;
		
			return new Fraction2(numerator_natural, _denominator_positive);

		}


		static public Fraction2 Eval(Natural2 numerator, PositiveNatural3 denominator)
		{

			return _Eval2(numerator.val, denominator.val.val);
			

		}

		static public Fraction_noZero Eval1(BigInteger numerator, BigInteger denominator)
		{

			if (denominator == 0)
			{
				throw new DivideByZeroException();

			}

			BigInteger gcd = BigInteger.GreatestCommonDivisor(numerator, denominator);

			///gcd cannot be zero due to normalizeSign(). so gcd>0.


			numerator = numerator / gcd;
			denominator = denominator / gcd;

			if (denominator < 0)
			{
				denominator = -denominator;
				numerator = -numerator;


			}

		
			return new Fraction_noZero(numerator, denominator).reduce1();

		}

		static public Rational_InheritFraction Eval3(BigInteger numerator, BigInteger denominator)
		{

			return new Rational_InheritFraction(numerator, denominator);

			

		}

		static public Rational_InheritFraction2 Do(BigInteger numerator, BigInteger denominator)
		{

			return Rational_InheritFraction2.Create(numerator, denominator);



		}

		static public Rational_InheritFraction2 Eval4(BigInteger numerator, BigInteger denominator)
		{

			return Rational_InheritFraction2.Create(numerator, denominator);



		}

		static public Rational_InheritFraction2 Eval(Rational_InheritFraction2 a, Rational_InheritFraction2 b)
		{

			return Rational_InheritFraction2.Divide(a, b);
		
		}

	


	

		
	}




}
