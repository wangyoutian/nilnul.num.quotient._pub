using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num.rational.Rational_InheritFraction2;
using r = nilnul.num.rational;
namespace nilnul.num.rational.bound.pair.be
{
	public partial class Nonempty
	{
		static public bool Eval(Pair x) {
			return Singleton.Eval(x)  ||Spanned.Eval(x);
		}

		public class Be
			:nilnul.bit.Be<Pair>
		{
			public Be()
				:base(Eval)
			{

			}

		}

		public class Asserted
			:
			nilnul.bit.be.Asserted<Pair,Be>

		{
			

			public  Asserted(Pair x)
				:base(x)
			{

			}
			protected Asserted() { 
			
			}


			public Asserted(Bound lower, Bound upper)
				:this(new Pair(lower,upper))
			{

			}

			public override string ToString()
			{
				return val.ToString();
			}



			public Q midpoint {
				get {
					return   ( val.lower.pinpoint + val.upper.pinpoint ) /2;
				}
			}

			public Q span
			{
				get
				{
					return val.upper.pinpoint - val.lower.pinpoint;
				}
			}
			public Q diameter
			{
				get
				{
					return val.upper.pinpoint - val.lower.pinpoint;
				}
			}


			public bool spanLessThan(rational.be.Positive.Asserted diameter)
			{
				if (isClosed())
				{
					return span < diameter.val;

				}
				else
				{
					return span <= diameter.val;
				}

			}
			public bool notSpanLessThan(rational.be.Positive.Asserted diameter)
			{
				return !spanLessThan(diameter);

			}

			public bool containsZero() {
				return val.contains(0);
			}

			public bool isClosed() {
				return val.lower.eq && val.upper.eq;
			}


			public bool isSingleton() {
				return this.val.lower.pinpoint== this.val.upper.pinpoint;
			
			}
			static public Asserted Negate(Asserted x) {

				var r = new Asserted();

				r.valProtected = new Pair(

				   nilnul.num.rational.Bound.Negate(	x.val.upper)
				   ,
				   nilnul.num.rational.Bound.Negate(x.valProtected.lower)
						
				);
				return r;
			
			}

			static public Asserted Multi(
				Asserted x
				,
				Asserted y
			) {

				var lowerLower =  x.val.lower * y.val.lower;

				var lowerUpper = x.val.lower * y.val.upper;

				var upperLower = x.val.upper * y.val.lower;
				var upperUpper = x.val.upper * y.val.upper;

				var r = new Asserted();

				r.valSetter = new Pair(
					comparers.Lower.Min(lowerLower,lowerUpper,upperLower,upperUpper)
					,
					comparers.Upper.Max(lowerLower,lowerUpper,upperLower,upperUpper)
					
				);

				return r;


				throw new NotImplementedException();
			}

			static public Asserted Add(Asserted x, Asserted y) {

				var r = new Asserted();

				r.valProtected = new Pair(
					nilnul.num.rational.Bound.Add(x.val.lower,y.val.lower)
					,
					nilnul.num.rational.Bound.Add(x.val.upper,y.val.upper)
				);

				return r;


			
			}


			static public Asserted Abs(Asserted x) {
				var r=new Asserted();

				if (x.val.contains(0))
				{

					r.val = new Pair(

						Bound.CreateZeroClose()
						,
						bound.comparers.Upper.Max(  
							Bound.Abs(x.val.lower)
							,
							Bound.Abs(x.val.upper)
						)
						
					);

					return r;
					
				}

				var lowerAbs = Bound.Abs(x.val.lower);
				var upperAbs = Bound.Abs(x.val.upper);
				r.val = new Pair(
					bound.comparers.Lower.Min(lowerAbs,upperAbs
					
					)	
					,bound.comparers.Upper.Max(lowerAbs,upperAbs)
				);

				return r;

			
			}

		
			static public Asserted CreateSingleton(
				Q singleton

				)
			{

				var r = new Asserted();

				r.val = new Pair(true, singleton, true, singleton);
				return r;
			}
			static internal Asserted _CreateOpen(
				Q lower
				,
				Q upper

				)
			{

				var r = new Asserted();

				r.val = new Pair(false, lower, false, upper);
				return r;
			}
			static public Asserted CreateOpen(
				Q lower
				,
				Q upper

				)
			{

				return new r.bound.pair.be.Nonempty.Asserted(
					new r.Bound(false, lower)
					, new r.Bound(false, upper)
				);
			}

			static public Asserted CreateClose(
				Q lower
				,
				Q upper

				)
			{

				return new r.bound.pair.be.Nonempty.Asserted(
					new r.Bound(true, lower)
					, new r.Bound(true, upper)
				);
			}
			static public Asserted CreateClose_orderIfNeed(
				Q lower
				,
				Q upper

				)
			{
				if (lower>upper)
				{
					return CreateClose(upper, lower);
					
				}

				return CreateClose(lower, upper);
			}

			static public Asserted CreateOpen_orderIfNeed(Q x, Q y) {


				if (x<y)
				{
					return CreateOpen(x, y);
					
				}
				return CreateOpen(y, x);
			
			}


			
		}
	}
}
