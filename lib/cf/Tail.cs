using nilnul.num.natural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fraction2 = nilnul.num.rational.Fraction_BigInteger_PositiveNatural3_;
using Fraction = nilnul.num.rational.Fraction_BigInteger_PositiveNatural3_;
using Positive = nilnul.num.natural.PositiveNatural_inheritNatural;
using System.Numerics;


namespace nilnul.num.rational.cf
{

	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// [0,1)
	/// 
	/// </remarks>
	public partial class Tail
		:
		IComparable<Tail>
	{
		nilnul.num.natural.PositiveNatural_inheritNatural[] _denominatorFloors;
		public PositiveNatural_inheritNatural[] denominatorFloors
		{
			get
			{
				return _denominatorFloors;
			}
			set
			{
				if (value == null)
				{
					_denominatorFloors = new PositiveNatural_inheritNatural[0];
					return;
				}

				var length = value.Length;

				if (length==1)
				{
					nilnul.bit.AssertX.True(
						value.Last() > 1
					);
				}

				if (length>1)
				{
					if (value[length-1]==1)
					{
						value[length-2]=value[length-1]+value[length-2];
						var newArray=new PositiveNatural_inheritNatural[length-1];
						Array.Copy(value, newArray, length - 1);
						_denominatorFloors = newArray;
						return;

						
					}
				}
				_denominatorFloors = value;
			}
		}

		#region ctor



		public Tail(params Positive[] denominatorFloors)
		{
			this.denominatorFloors = denominatorFloors;

		}


		public Tail(IEnumerable<Positive> denominatorFloors)
		{
			this.denominatorFloors = denominatorFloors.ToArray();

		}

		#endregion



		public Fraction2 ToFraction()
		{

			return _ToFraction(_denominatorFloors);
		}
		public Rational_InheritFraction toRational()
		{

			return _ToRational(_denominatorFloors);
		}

		public int CompareTo(Tail other)
		{
			return Compare(this, other);
		}
		#region static



		static private Fraction2 _ToFraction(IEnumerable<PositiveNatural_inheritNatural> denominators_notNull)
		{

			if (denominators_notNull.Count() == 0)
			{
				return new Fraction2();

			}

			return Fraction_BigInteger_PositiveNatural3_.Add(

					denominators_notNull.First(),
					_ToFraction(denominators_notNull.Skip(1))
				).inverse()

			;


		}


		static private Rational_InheritFraction _ToRational(IEnumerable<PositiveNatural_inheritNatural> denominators_notNull)
		{

			if (denominators_notNull.Count() == 0)
			{
				return new Rational_InheritFraction();

			}

			return Rational_InheritFraction.Inverse(Rational_InheritFraction.Add(

					denominators_notNull.First(),

					_ToRational(denominators_notNull.Skip(1))
				))

			;


		}



		static public List<PositiveNatural_inheritNatural> FroDouble_nonNeg(double tail, double tailUpper_nonNeg)
		{
			var denominants = new List<PositiveNatural_inheritNatural>();

			if (tail > tailUpper_nonNeg)
			{

				var tailInverse = 1 / tail;

				var fraction = FroDouble_nonNeg(tailInverse, tailUpper_nonNeg);

				denominants.AddRange(fraction);


			}

			return denominants;

		}



		/// <summary>
		/// 
		/// </summary>
		/// <param name="_tail_0to1_"></param>
		/// <param name="numberOfDenominators"></param>
		/// <returns></returns>

		static public List<PositiveNatural_inheritNatural> FroDouble_nonNeg(double _tail_0to1_, nilnul.num.natural.Natural2 numberOfDenominators)
		{
			var denominants = new List<PositiveNatural_inheritNatural>();

			if (numberOfDenominators == 0)
			{
				return denominants;

			}
			if (_tail_0to1_ == 0)
			{
				return denominants;

			}

			numberOfDenominators--;

			var tailInverse = nilnul_obj.num.NumX.FloorAndTail(1 / _tail_0to1_);
			denominants.Add(new PositiveNatural_inheritNatural(tailInverse.Item1));

			var fraction = FroDouble_nonNeg(tailInverse.Item2, numberOfDenominators);
			denominants.AddRange(fraction);

			return denominants;

		}


		static public List<PositiveNatural_inheritNatural> FroDouble_atDenominator(double _tail_0to1_, PositiveNatural3 denominatorLowerbound) {

			return FroDouble_atDenominator(_tail_0to1_, denominatorLowerbound.val);
			
		
		}

		static public List<BigInteger> RationalToTail(
			Rational_InheritFraction2 r__0_til_1	
		) {
			var denominants = new List<BigInteger>();
			while (r__0_til_1!=0)
			{
				r__0_til_1 = 1 / r__0_til_1;
				var intProper=r__0_til_1.ToIntAndProper();
				denominants.Add(  intProper.Item1);
				r__0_til_1 = intProper.Item2;
			}
			return denominants;
			throw new NotImplementedException();
		}


		static public List<PositiveNatural_inheritNatural> FroDouble_atDenominator(double _tail_0to1_, BigInteger denominatorLowerbound_positive)
		{
			var denominants = new List<PositiveNatural_inheritNatural>();

			if (_tail_0to1_ <= 0)
			{
				return denominants;
			}


			var tailInverse = nilnul_obj.num.NumX.FloorAndTail(1 / _tail_0to1_);
			denominants.Add(new PositiveNatural_inheritNatural(tailInverse.Item1));
			if (tailInverse.Item2 <= 0)
			{
				return denominants;

			}

			BigInteger denominator = tailInverse.Item1;
			BigInteger denominatorK_1 = 1;
			BigInteger denominatorK_2 = 0;
			BigInteger denominatorK = CfX.CalcFromPreviousTwoTerms(tailInverse.Item1, denominatorK_1, denominatorK_2);



			while (denominatorK < denominatorLowerbound_positive)
			{
				if (tailInverse.Item2 <= 0)
				{
					return denominants;
				}
				tailInverse = nilnul_obj.num.NumX.FloorAndTail(1 / tailInverse.Item2);
				denominants.Add(new PositiveNatural_inheritNatural(tailInverse.Item1));
				denominatorK_2 = denominatorK_1;
				denominatorK_1 = denominatorK;

				denominatorK = CfX.CalcFromPreviousTwoTerms(tailInverse.Item1, denominatorK_1, denominatorK_2);


			}

			return denominants;

		}


		static public List<PositiveNatural_inheritNatural> FroDouble_nonNeg(double tail_0to1_)
		{
			var denominants = new List<PositiveNatural_inheritNatural>();


			if (tail_0to1_ == 0)
			{
				return denominants;

			}


			var tailInverse = nilnul_obj.num.NumX.IntegerAndTail_forNonNeg(1 / tail_0to1_);
			denominants.Add(new PositiveNatural_inheritNatural(tailInverse.Item1));

			var fraction = FroDouble_nonNeg(tailInverse.Item2);
			denominants.AddRange(fraction);

			return denominants;

		}








		static public int Compare(Tail a, Tail b)
		{


			if (a._denominatorFloors.Length < b._denominatorFloors.Length)
			{
				return _compareDenominatorsLongToShort(b._denominatorFloors, a._denominatorFloors);

			}
			return _compareDenominatorsLongToShort(a._denominatorFloors, b._denominatorFloors);



		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		/// <remarks>a must be no shortr than b</remarks>
		static private int _compareDenominatorsLongToShort(IEnumerable<PositiveNatural_inheritNatural> a, IEnumerable<PositiveNatural_inheritNatural> b)
		{
			if (a.Count() == 0)
			{
				return 0;

			}

			if (b.Count() == 0)
			{
				return 1;

			}

			if (a.First() > b.First())
			{
				return -1;

			}

			if (a.First() < b.First())
			{
				return 1;

			}
			return _compareDenominatorsLongToShort(a.Skip(1), b.Skip(1));


		}
		#endregion


	}
}
