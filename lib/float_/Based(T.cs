using nilnul.bit;
using nilnul.num.natural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.rational.float_
{
	public partial class Based<TBase>
		: Based2
		where TBase : natural.be.plural.bigint.Asserted, new()
	{

		static public TBase Radix = SingletonByDefaultNew<TBase>.Instance;

		static public BigInteger BaseAsBigint = Radix.val;


		public Based()
			: base(Radix.val)
		{


		}
		public Based(BigInteger significand)
			: base(Radix.val, significand)
		{

		}
		public Based(BigInteger significand, BigInteger index)
			: base(Radix.val, significand, index)
		{

		}
		public Based(rational.Float float_)
			: base(Radix.val, float_)
		{

		}


		static public Based<TBase> Subtract(
			Based<TBase> a,

			Based<TBase> b

			)
		{

			return Add(a, b.toNegate());



		}

		static public Based<TBase> operator -(
			Based<TBase> a,
			Based<TBase> b
			){
				return Subtract(a, b);
		
		}

		public  Based<TBase> toNegate()
		{
			var b = base.toNegate();
			return new Based<TBase>(b.significand, b.index);
		}

		static public Based<TBase> Negate(Based<TBase> a) {
			return new Based<TBase>(a.toNegate().float_);
		
		}

		static public Based<TBase> operator -(Based<TBase> a){
			return Negate(a);
		}




		static public Based<TBase> Add(

			Based<TBase> a, Based<TBase> b
			)
		{

			if (b.index < a.index)
			{
				return _Add_smallerFirst(b, a);
			}
			return _Add_smallerFirst(a, b);


			throw new NotImplementedException();

		}

		static public Based<TBase> operator +(Based<TBase> a, Based<TBase> b) {
			return Add(a,b);
		}

		static public Based<TBase> _Add_smallerFirst(Based<TBase> _powerSmaller, Based<TBase> powerMax)
		{


			var t = powerMax.index - _powerSmaller.index;

			return new Based<TBase>(

				powerMax.significand * nilnul.num.natural.op.PowX2.Do_basePlural_indexNonNeg(BaseAsBigint, t) + _powerSmaller.significand
				,
				_powerSmaller.index

			);

			throw new NotImplementedException();

		}

		static public Based<TBase> Multi(
			Based<TBase> significandIndex1
			,
			Based<TBase> significandIndex2
		)
		{
			return new Based<TBase>( significandIndex1.significand * significandIndex2.significand, significandIndex1.index + significandIndex2.index);


			throw new NotImplementedException();
		}









	}
}