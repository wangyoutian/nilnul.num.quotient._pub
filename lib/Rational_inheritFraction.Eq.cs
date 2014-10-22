using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.natural;
using Fraction=nilnul.num.rational.Fraction_BigInteger_PositiveNatural3_;

namespace nilnul.num.rational
{
	/// <summary>
	/// coprime.
	/// </summary>
	public partial class Rational_InheritFraction
		
	{
		public partial class Eq
			:
			nilnul.relation.EqualI<Rational_InheritFraction>
			,
			IEqualityComparer<Rational_InheritFraction>

		{


			public bool contains(Rational_InheritFraction first, Rational_InheritFraction second)
			{
				return first.numerator == second.numerator && first.denominator == second.denominator;

				throw new NotImplementedException();
			}

			public bool Equals(Rational_InheritFraction x, Rational_InheritFraction y)
			{
				return contains(x, y);
				throw new NotImplementedException();
			}

			public int GetHashCode(Rational_InheritFraction obj)
			{
				return obj.numerator.GetHashCode() ^ obj.denominator.GetHashCode();
				throw new NotImplementedException();
			}

		

			static public Eq Instance = SingletonByDefaultNew<Eq>.Instance;


		}


		
	}
}
