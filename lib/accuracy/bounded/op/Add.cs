using nilnul.num.rational.accuracy.bounded;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.accuracy.bounded.op
{
	public partial class Add
	{
		static public FiniteI Eval(FiniteI a, FiniteI b)
		{
			if (a is OpenLeftI)
			{
				if (a is OpenRightI)
				{
					return _CreateOpen(a, b);

				}
				if (a is CloseRightI)
				{
					if (b is OpenRightI)
					{
						return _CreateOpen(a, b);

					}
					return _CreateOpenClose(a, b);
				}
			}
			if (a is OpenRightI)
			{
				if (b is OpenLeftI)
				{
					return _CreateOpen(a, b);
					
				}
				return _CreateClopen(a, b);
			}
			if (a is CloseRightI)
			{
				if (b is OpenLeftI)
				{
					if (b is OpenRightI)
					{
						return _CreateOpen(a, b);
					}
					return _CreateOpenClose(a, b);
					
				}
				if (b is OpenRightI)
				{
					return _CreateClopen(a, b);
					
				}
				return _CreateClose(a, b);
			}
			throw new NotImplementedException();
		}

		static public Open2 Eval(Open2 a, Open2 b)
		{

			return new Open2(a.lowerBound + b.lowerBound, a.upperBound + b.upperBound);


			throw new NotImplementedException();

		}

		static public Close2 Eval(Close2 a, Close2 b)
		{
			return new Close2(a.lowerBound + b.lowerBound, a.upperBound + b.upperBound);

		}

		static public Clopen Eval(Clopen a, Clopen b)
		{

			return new Clopen(a.lowerBound + b.lowerBound, b.upperBound + b.upperBound);

		}

		static public OpenClose Eval(OpenClose a, OpenClose b)
		{
			return new OpenClose(a.lowerBound + b.lowerBound, b.upperBound + b.upperBound);

		}

		static public Open2 Eval(Open2 a, FiniteI b)
		{
			return new Open2(a.lowerBound + b.lowerBound, b.upperBound + b.upperBound);
		}

		static public Open2 Eval(FiniteI b, Open2 a)
		{
			return Eval(a, b);
		}

		static public Open2 Eval(Clopen a, OpenClose b)
		{
			return _CreateOpen(a, b);
		}

		static public Open2 Eval(OpenClose a, Clopen b)
		{

			return _CreateOpen(a, b);

		}

		static private Open2 _CreateOpen(FiniteI a, FiniteI b)
		{
			return new Open2(a.lowerBound + b.lowerBound, b.upperBound + a.upperBound);

		}

		static private Close2 _CreateClose(FiniteI a, FiniteI b)
		{
			return new Close2(a.lowerBound + b.lowerBound, b.upperBound + a.upperBound);

		}
		static private Clopen _CreateClopen(FiniteI a, FiniteI b)
		{
			return new Clopen(a.lowerBound + b.lowerBound, b.upperBound + a.upperBound);

		}
		
		static private OpenClose _CreateOpenClose(FiniteI a, FiniteI b)
		{
			return new OpenClose(a.lowerBound + b.lowerBound, b.upperBound + a.upperBound);

		}


	}
}
