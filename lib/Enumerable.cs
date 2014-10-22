using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace nilnul.num.rational
{
    public partial class Enumerable
    {
        
		/// <summary>
		/// this 
		/// </summary>
		/// <returns></returns>
		static public IEnumerable<Fraction__LazyValidated> Enumerate()
		{
			yield return new Fraction__LazyValidated(0, 1);
			for (BigInteger sum = 2; ; sum++)
			{
				BigInteger num;
				for (num = 0; num < sum; num++)
				{
					BigInteger den = sum - num;
					//is j, i-j coprime

					if (BigInteger.GreatestCommonDivisor(num, den) == 1)
					{
						yield return new Fraction__LazyValidated(num, den);
						yield return new Fraction__LazyValidated(-num, den);

					}

				}


			}
		}

		/// <summary>
		/// this is simplified version.
		/// </summary>
		/// <returns></returns>

		static public IEnumerable<RationalI> Enumerate2()
		{
			yield return new BigInt(0);
			for (BigInteger sum = 2; ; sum++)
			{
				BigInteger num;
				for (num = 0; num < sum; num++)
				{
					BigInteger den = sum - num;
					//is j, i-j coprime

					if (BigInteger.GreatestCommonDivisor(num, den) == 1)
					{
						yield return Divide.Eval(-num, den);
						yield return Divide.Eval(num, den);

					}

				}


			}
		}


		static public IEnumerable<Rational_InheritFraction2> Enumerate_rationalInheritFraciton()
		{
			yield return new Rational_InheritFraction2(0);
			for (BigInteger sum = 2; ; sum++)
			{
				BigInteger num;
				for (num = 0; num < sum; num++)
				{
					BigInteger den = sum - num;
					//is j, i-j coprime

					if (BigInteger.GreatestCommonDivisor(num, den) == 1)
					{
						yield return new Rational_InheritFraction2(-num, den);
						yield return new Rational_InheritFraction2(num, den);

					}

				}


			}
		}




		static public IEnumerable<Fraction__LazyValidated> EnumerateBefore(Fraction__LazyValidated r) {

			return Enumerate().TakeWhile(c => c.neq(r.standardizeSelf()));
			

		
		}


		static public IEnumerable<RationalI> EnumerateBefore2(RationalI x)
		{

			return Enumerate2().TakeWhile(c => c.Neq(x));



		}

		static public IEnumerable<Rational_InheritFraction2> EnumerateBefore2(Rational_InheritFraction2 x)
		{

			return Enumerate_rationalInheritFraciton().TakeWhile(c =>c!=x);



		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="r"></param>
		/// <returns></returns>
		static public IEnumerable<Fraction__LazyValidated> EnumerateCover(Fraction__LazyValidated r)
		{


			return EnumerateBefore(r).Union(new[] { r.standardizeSelf() });



		}

		/// <returns></returns>
		static public IEnumerable<RationalI> EnumerateCover2(RationalI r)
		{


			return EnumerateBefore2(r).Union(new[] { r.Simplify() });



		}	/// <returns></returns>
		static public IEnumerable<Rational_InheritFraction2> EnumerateCover2(Rational_InheritFraction2 r)
		{


			return EnumerateBefore2(r).Union(new[] { r });



		}
    }
}
