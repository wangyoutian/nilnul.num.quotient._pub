using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.rational
{
    class Program
    {
        static void Main(string[] args)
        {
			foreach (var item in Countable.Enumerate().Take(50))
	{
		Console.WriteLine(item);
		 
	}
			
			
		
        }
    }
}
