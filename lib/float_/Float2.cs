using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit;
using nilnul.num.natural;
using nilnul.num.rational.float_.rel;
using Plural = nilnul.num.natural.bigint.rel.Plural.Asserted;

namespace nilnul.num.rational.float_
{
	/// <summary>
	/// s*b^p
	/// </summary>
	/// 
	/// <remark>
	/// note the decimal in .net also has acuracy issues.
	/// </remark>
	public partial class Float2 
	{

		#region fields and properties

		private Exp_bigIntAssertedPluralAsBase _exp;

		public Exp_bigIntAssertedPluralAsBase exp
		{
			get { return _exp; }
			set { _exp = value; }
		}
		



		BigInteger _significand;

		public BigInteger significand
		{
			get
			{
				return _significand;
			}
			set
			{
				_significand = value;
			}
		}
	

		#endregion

		#region ctor

		public Float2(
			Exp_bigIntAssertedPluralAsBase exp
			,
			BigInteger significand
		)
		{
			this._exp = exp;
			this._significand = significand;

		}
		public Float2(
			BigInteger significand
			,
			Exp_bigIntAssertedPluralAsBase exp
		)
		{
			this._exp = exp;
			this._significand = significand;

		}


		public Float2(BigInteger significand, BigInteger base_, BigInteger power)
			:this(new Exp_bigIntAssertedPluralAsBase(base_,power),significand)
		{


		}
		


		public Float2(BigInteger significand, BigInteger base_)
			: this(significand, base_, 0)
		{
		}


		public Float2(Float2 other)
			: this(other.significand, other.exp)
		{
		}


		public Float2(BigInteger significand)
			: this(significand, 2)
		{
		}
		public Float2()
			: this(0)
		{
		}

		#endregion
		#region instance methods
		public override string ToString()
		{
			var r = significand.ToString();	//todo: this need to be based on base.

			return r + "*" + exp.ToString();



		}

		

		/// <summary>
		/// 
		/// </summary>
		public Float2 reduce2()
		{
			if (_significand == 0)
			{
				exp.index=0;
				return this;
			}
			BigInteger remainder;
			var q = BigInteger.DivRem(_significand, exp.@base.val, out remainder);

			while (remainder == 0)
			{
				_significand = q;
				exp.index++;

				q = BigInteger.DivRem(_significand, exp.@base.val, out remainder);

			}
			return this;

		}


		

		public Float2 negate()
		{
			_significand = -_significand;
			return this;
		}

	

		public RationalI eval()
		{
			throw new NotImplementedException();
		}


	

	
	

		#endregion

		#region static

	

	

	

		static public implicit operator Float2(BigInteger a)
		{
			return new Float2(a, 2, 0);
		}

		static public implicit operator Float2(int a)
		{
			return new Float2(a, 2, 0);
		}

		static public implicit operator Float2(uint a)
		{
			return new Float2(a, 2, 0);
		}
		static public implicit operator Float2(Natural a)
		{
			return new Float2(a, 2, 0);
		}
		static public implicit operator Float2(Natural2 a)
		{
			return new Float2(a, 2, 0);
		}
	



	

		
		static public Float2 operator -(Float2 a)
		{


			return (a.MemberwiseClone() as Float2).negate();



		}

		
		
		





	
		#endregion

	}
}
