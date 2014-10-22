using nilnul.num.natural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Fraction2 = nilnul.num.rational.Fraction_BigInteger_PositiveNatural3_;
using PositiveNatural = nilnul.num.natural.PositiveNatural_inheritNatural;

namespace nilnul.num.rational.cf
{
	/// <summary>
	///  isophism to rational
	/// </summary>
	/// <remarks>
	/// floor >=0
	/// denominators.count>=0 (  
	///		if count==0 is set to 0, then 1+0=1+1/0. 1+1+0=1+1/1
	///		recursive  )
	///		
	/// no sign.
	/// 
	/// standard.
	/// 
	/// 
	/// </remarks>
	
    public partial class ContinuedFraction2
        :IComparable<ContinuedFraction2>
    {

		BigInteger _floor;

		Tail _tail;
        public BigInteger floor
        {
            get
            {
                return _floor;
            }
            set
            {
                _floor = value;
            }
        }
        public Tail tail
        {
            get
            {
                return _tail;
            }
            set
            {
				if (value==null)
				{
					_tail = new Tail();
					
				}
               
                _tail = value;
            }
        }

		#region ctor
		public ContinuedFraction2()
		{
			tail = new Tail();
		}

		public ContinuedFraction2(BigInteger floor, Tail tail)
		{



			this._floor = floor;

			this.tail = tail;

		}


		public ContinuedFraction2(BigInteger floor, IEnumerable<PositiveNatural> denominators)
			
		{
			this._floor = floor;

			this.tail = new Tail(denominators);
		}
					

		public ContinuedFraction2(BigInteger floor, params PositiveNatural[] denominatorFloors)
		{



			this._floor = floor;

			this.tail = new Tail(denominatorFloors);

		}


					

		#endregion



				

		public Fraction2 toFraction() {
			return floor + tail.ToFraction();
			
		}


		public Rational_InheritFraction toRational()
		{
			return new Rational_InheritFraction(floor + tail.toRational());

		}
		public Rational_InheritFraction2 toRational2()
		{
			return new Rational_InheritFraction2(floor + tail.toRational());

		}



		static public Rational_InheritFraction ToRational(double x) {
			return ToCf(x).toRational();
		
		}

		static public Rational_InheritFraction2 ToRational2(double x)
		{
			return ToCf(x).toRational2();

		}


		static public Rational_InheritFraction ToRational(double x, nilnul.num.natural.Natural2 numberOfDenominators)
		{
			return ToCf(x, numberOfDenominators).toRational();

		}
		static public Rational_InheritFraction ToRational(double x, BigInteger numberOfDenominators)
		{
			return ToCf(x, new Natural2( numberOfDenominators)).toRational();

		}

		static public Rational_InheritFraction ToRational_tillDenominator(double x, int denominatorUpperbound)
		{

			return ToCf_tillDenominator(x, denominatorUpperbound).toRational();

		}

		static public Rational_InheritFraction ToRational_tillDenominator(double x, BigInteger denominatorUpperbound)
		{

			return ToCf_tillDenominator(x, denominatorUpperbound).toRational();

		}
		static public Rational_InheritFraction2 ToRational_tillDenominator2(double x, BigInteger denominatorUpperbound)
		{

			return ToCf_tillDenominator(x, denominatorUpperbound).toRational2();

		}


		static public Rational_InheritFraction ToRational(double x, int numberOfDenominators)
		{
			return ToCf(x, numberOfDenominators).toRational();

		}


        static public int Compare(ContinuedFraction2 a, ContinuedFraction2 b)
        {
            if (a.floor > b.floor)
            {
                return 1;

            }
            if (a.floor < b.floor)
            {
                return -1;

            }

           
          return a.floor.CompareTo(b.floor);


        }

     

        public int CompareTo(ContinuedFraction2 other)
        {
            return Compare(this,other);
        }

		#region static
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


		static public Tuple<BigInteger,List< PositiveNatural_inheritNatural>> FroDoubl(double x, double tailUpper_nonNeg)
		{

			
			var floor = Convert.ToInt64( Math.Floor(x));

			var tail = x-floor;
			tail = tail > 0 ? tail : 0;


			var tailCf = Tail.FroDouble_nonNeg(tail, tailUpper_nonNeg);

			var denominants = new List<long>();


		

			return new Tuple<BigInteger,List<PositiveNatural>>(
				floor,
				tailCf
				);

		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="tailWithPossible1End"></param>
		/// <returns></returns>
		static public ContinuedFraction2 ToCf(IEnumerable<PositiveNatural_inheritNatural> tailEndedWith1_) {

			if (tailEndedWith1_==null)
			{
				throw new ArgumentNullException();
				
			}
			if (tailEndedWith1_.Count()==0)
			{
				return new ContinuedFraction2();
				
			}

			if (tailEndedWith1_.Count()==1)
			{
				if (tailEndedWith1_.First()==1)
				{
					return new ContinuedFraction2(1);
					
				}
				else
				{
					return new ContinuedFraction2(0, tailEndedWith1_);
				}
				
			}

			var last=tailEndedWith1_.Last()+tailEndedWith1_.ElementAt(tailEndedWith1_.Count()-2);
			var front=tailEndedWith1_.Take(tailEndedWith1_.Count()-2);

			var newList=front.Union(new[]{last});


			return new ContinuedFraction2(0, newList);

		
		}

		static public ContinuedFraction2 ToCf(double x, Natural2 tailLength) {


			var floorTail = nilnul_obj.num.NumX.FloorAndTail(x);

			var tail = floorTail.Item2;

			var tailCf=Tail.FroDouble_nonNeg(tail,tailLength);

			return new ContinuedFraction2(floorTail.Item1, tailCf);
		
		}

		static public ContinuedFraction2 ToCf_tillDenominator(double x, int tillDenominator)
		{
			return ToCf_tillDenominator(x, new PositiveNatural3(tillDenominator));
		}

		static public ContinuedFraction2 ToCf_tillDenominator(double x, PositiveNatural3 tillDenominator)
		{

			var floorTail = nilnul_obj.num.NumX.FloorAndTail(x);

			var tail = floorTail.Item2;

			var tailCf = Tail.FroDouble_atDenominator(tail, tillDenominator.val);

			return new ContinuedFraction2(floorTail.Item1, tailCf);

		}


		static public ContinuedFraction2 ToCf_tillDenominator(double x, BigInteger tillDenominator)
		{

			return ToCf_tillDenominator(x, new PositiveNatural3(tillDenominator));

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="x"></param>
		/// <param name="tailLength"></param>
		/// <returns></returns>
		static public ContinuedFraction2 ToCf_overDenominator(double x, Natural2 tailLength)
		{
			///todo:

			var floorTail = nilnul_obj.num.NumX.FloorAndTail(x);

			var tail = floorTail.Item2;

			var tailCf = Tail.FroDouble_nonNeg(tail, tailLength);

			return new ContinuedFraction2(floorTail.Item1, tailCf);

		}

		static public ContinuedFraction2 ToCf(double x, int tailLength)
		{
			return ToCf(x, new Natural2(tailLength));

			

			

		}

		static public ContinuedFraction2 ToCf(double x)
		{


			var floorTail = nilnul_obj.num.NumX.FloorAndTail(x);
	

			return new ContinuedFraction2(floorTail.Item1, Tail.FroDouble_nonNeg(floorTail.Item2));

		}

		static public Fraction_BigInteger_PositiveNatural3_ ToFraction(double doubleNum) {

			return ToCf(doubleNum).toFraction();
 

		
		
		}

		


		#endregion






    }
}
