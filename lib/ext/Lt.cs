using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xr = nilnul.num.rational.ExtendedI;
using R = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational.ext
{
	public partial class Lt
	{
		static public bool Contains(Xr a,Xr b) {

			if (a is NegInf)
			{
				if (! (b is NegInf))
				{
						return true;
			
					
				}
				
			}
			if (b is PosInf)
			{
				if (!(a is PosInf))
				{
					return true;
					
				}
				
			}

			if (a is R && b is R )
			{
				return (R)a< (R)b;
				
			}
				return false;


		
		}
	}
}
