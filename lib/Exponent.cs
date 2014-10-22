using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.natural;

namespace nilnul.num.rational
{
	public partial class Exponent
	{
		private BigInteger _power=0;

		public BigInteger power
		{
			get { return _power; }
			set { _power = value; }
		}

		private Plural _base_=(Plural)2;

		public Plural base_
		{
			get { return _base_; }
			set { _base_ = value; }
		}
		
		

		public Exponent(Plural base_, BigInteger power)
		{
			this.power = power;
			this.base_ = base_;

		}
					
	}
}
