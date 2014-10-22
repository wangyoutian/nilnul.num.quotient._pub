using nilnul_obj.op;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace nilnul.num.rational
{
	public partial class Add:ClosedBiOpI<RationalI>
	{

		static private readonly Add _Instance = new Add();
		static public Add Instance
		{
			get
			{
				return _Instance;
			}
		}
		public Add()
		{
		}
				
		static public RationalI Eval(Fraction__LazyValidated a,Fraction__LazyValidated b) {

			return Divide.Eval(a.numerator * b.denominator + b.numerator * a.denominator, a.denominator * b.denominator);
		
		}

		static public RationalI Eval(RationalI a, RationalI b)
		{
			return Divide.Eval(a.Numerator() * b.Denominator() + b.Numerator() * a.Denominator(), a.Denominator() * b.Denominator());
			

		}




		public Func<RationalI, RationalI, RationalI> func
		{
			get { return Eval; }
		}

		public override string ToString()
		{
			return "+";
		}
	}
}
