using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.rational
{
	public struct  BigInt:


		
		RationalI
	{
		public BigInteger val;


		public BigInt(int i)
		{
			val = new BigInteger(i);
		}


		public BigInt(BigInteger b)
		{
			val = b;
		}

		public override string ToString()
		{
			return val.ToString();
		}

		// override object.Equals
		public override bool Equals(object obj)
		{
			//       
			// See the full list of guidelines at
			//   http://go.microsoft.com/fwlink/?LinkID=85237  
			// and also the guidance for operator== at
			//   http://go.microsoft.com/fwlink/?LinkId=85238
			//

			if (obj == null || GetType() != obj.GetType())
			{
				return false;
			}

			// TODO: write your implementation of Equals() here
			
			return eq((BigInt)obj);
		}

		public bool eq(BigInt other) {
			return other.val == this.val;
		
		}

		// override object.GetHashCode
		public override int GetHashCode()
		{
			// TODO: write your implementation of GetHashCode() here
			
			return val.GetHashCode();
		}



		public RationalI eval()
		{
			return this;
		}
	}
}
