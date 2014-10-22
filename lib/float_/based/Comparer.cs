using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.rational.float_.based
{
	public partial class Comparer
		:IComparer<Float>
	{
		static public int Compare(natural.rel.Plural.BigInt.Asserted base_,Float a,Float b ) {

			return Based2.Subtract(base_.val, a, b).sign;
 
		
		}

		private natural.rel.Plural.BigInt.Asserted _base;

		public natural.rel.Plural.BigInt.Asserted base_
		{
			get { return _base; }
			set { _base = value; }
		}
		

		public Comparer(
			nilnul.num.natural.rel.Plural.BigInt.Asserted base_
			)
		{
			this.base_ = base_;

		}

		public Comparer(BigInteger base_)
		:	this(
			new natural.rel.Plural.BigInt.Asserted(base_)
		)
		
		{

		}



		public int Compare(Float x, Float y)
		{

			return Compare(_base, x, y);
			throw new NotImplementedException();
		}
	}
}
