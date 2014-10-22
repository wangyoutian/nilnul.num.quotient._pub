using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.neighbor
{
	public partial class Inf
		:NeighborI
	{
		public ExtendedI radius
		{
			get {
				return new ext.PosInf();
				
				throw new NotImplementedException(); 
			
			}
		}

		public bool open
		{
			get {
				return true;
				throw new NotImplementedException(); }
		}

		public bool contains(Rational_InheritFraction2 item)
		{
			return true;
			throw new NotImplementedException();
		}
	}
}
