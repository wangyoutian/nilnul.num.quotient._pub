using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational.accuracy
{
	static public   class FiniteX
	{
		static public bool IsSuperSetOf(this FiniteI superNeighbor, FiniteI sub) {

			if (superNeighbor.lowerBound>sub.lowerBound || superNeighbor.upperBound<sub.upperBound)
			{
				return false;
				
			}


			if (sub is Clopen || sub is Close2)
			{
				if (!superNeighbor.contains(sub.lowerBound))
				{
					return false;
					
				}
				
			}
			if (sub is OpenClose || sub is Close2 )
			{
				if (! superNeighbor.contains(sub.upperBound))
				{
					return false;
					
				}
				
			}
			return true;





			throw new NotImplementedException();
		
		}

		static public bool IsSuperSetOf(  ) { 



		
				throw new NotImplementedException();
	
		}


	}
}
