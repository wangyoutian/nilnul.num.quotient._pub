using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.rational
{
	/// <summary>
	/// all rationalI, be it resided in Integer, or In Fraction, is closed under some operation.
	/// </summary>
	static public partial class RationalX
	{

		static public BigInteger Denominator(this RationalI q) {
			return q.ToFraction().denominator;
		}


		static public BigInteger Numerator(this RationalI q)
		{
			return q.ToFraction().numerator;
		}



		static public RationalI Simplify(this RationalI r) {

			if (r is Fraction__LazyValidated)
			{
				return 						((Fraction__LazyValidated)r).Simplify();
					
			}
			if (r is BigInt)
			{
				return Simplify(((BigInt)r));
				
			}

			if (r is Fraction_noZero)
			{

				
			}
			throw new UnknownTypeException(typeof(RationalI),typeof( Fraction__LazyValidated),typeof( BigInt));
			
		}

		/// <summary>
		/// this is not necessary on BigInt. So we write it here.
		/// </summary>
		/// <param name="i"></param>
		/// <returns></returns>
		static public RationalI Simplify(this BigInt i ) {

			return i;
		
		}

		static public BigInt ToRational(this BigInteger i) {

			return new BigInt(i);
		
		}


		static public BigInt ToRational(this int i)
		{

			return new BigInt(i);

		}




		static public RationalI Simplify(this Fraction__LazyValidated i)
		{

			return Divide.Eval(
						i.numerator,
						i.denominator
					);

		}


		static public Fraction__LazyValidated ToFraction(this RationalI q) {

			if (q is Fraction__LazyValidated)
			{
				return (Fraction__LazyValidated)q;
			}
			if (q is BigInt)
			{
				return ToFraction((BigInt)q);
				
			}
			throw new UnknownTypeException();

		
		}

		static public Fraction__LazyValidated ToFraction(BigInt i) {
			return new Fraction__LazyValidated(i);
		
		}

		

		static public RationalI Parse(string s) {
			//
			var terms=s.Split(new []{Divide.Sign},StringSplitOptions.RemoveEmptyEntries);

			if (terms.Length==0)
			{
				throw new ArgumentException("empty string.");
				
			}
			if (terms.Length==1)
			{
				return new BigInt( BigInteger.Parse(terms[0]));

				
			}
			if (terms.Length==2)
			{
				return new Fraction__LazyValidated(BigInteger.Parse(terms[0]), BigInteger.Parse(terms[1]));
				
			}
			throw new ArgumentException(string.Format("Only two terms are expected across the {0}",Divide.Sign));


		}

		static public bool Eq(BigInt a,BigInt b) {

			return a.eq(b);
		
		}

		static public bool Eq(Fraction__LazyValidated a,Fraction__LazyValidated b) {

			return a.eq(b);
		
		}

		static public bool Eq(Fraction__LazyValidated a,BigInt b) {

			return a.eq(b);
		
		}



		static public bool Eq(this RationalI a,RationalI b) {

			return Eq(a.ToFraction(), b.ToFraction());

		
		}

		static public bool Neq(this RationalI a, RationalI b)
		{

			return !Eq(a.ToFraction(), b.ToFraction());


		}



	}
}
