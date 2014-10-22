using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real
{
    public partial struct ContinuedFraction
        :IComparable<ContinuedFraction>
    {
        int _floor;
        uint[] _denominatorFloors;
        public int floor
        {
            get
            {
                return _floor;
            }
            set
            {
                _floor = value;
            }
        }
        public uint[] denominatorFloors
        {
            get
            {
                return _denominatorFloors;
            }
            set
            {
                Check(denominatorFloors);
                _denominatorFloors = value;
            }
        }

        static public void Check(uint[] denominatorFloors) {
            foreach (var item in denominatorFloors)
            {
                if (item==0)
                {
                    throw new Exception("All the denominator floors should be positive integers");
                    
                }

                
            }
            if (denominatorFloors.Length>0)
            {
                if (denominatorFloors.Last()==1)
                {
                    throw new Exception("The last denominator floor 1 should be rolled up to the second last denominator floor.");
                }
                
            }
        }

        public ContinuedFraction(int floor,params uint[] denominatorFloors)
        {
            Check(denominatorFloors);


            this._floor = floor;
            this._denominatorFloors = denominatorFloors;

        }

        public uint this[uint denominatorFloorsIndex]
        {
            get
            {
                if (denominatorFloorsIndex >= _denominatorFloors.Length)
                {
                    return 0;

                }
                return _denominatorFloors[denominatorFloorsIndex];
            }
        }



        static public int Compare(ContinuedFraction a, ContinuedFraction b)
        {
            if (a.floor > b.floor)
            {
                return 1;

            }
            if (a.floor < b.floor)
            {
                return -1;

            }

            if (a.denominatorFloors.Length<b.denominatorFloors.Length)
            {
                return -_compareDenominatorsLongToShort(ref b, ref a);
                
            }
            return _compareDenominatorsLongToShort(ref a, ref b);


        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        /// <remarks>a must be no shortr than b</remarks>
        static private int _compareDenominatorsLongToShort(ref ContinuedFraction a, ref ContinuedFraction b)
        {
            bool numeratorAlternated = false;
            for (uint i = 0; i < a.denominatorFloors.Length; i++)
            {
                if (i < b.denominatorFloors.Length)
                {
                    if (a[i] > b[i])
                    {
                        return numeratorAlternated ? 1 : -1;
                    }
                    if (a[i] < b[i])
                    {
                        return numeratorAlternated ? -1 : 1;
                    }
                }
                else// b[i]=+inf >a[i]
                {
                    return numeratorAlternated ? -1 : 1;
                }
                numeratorAlternated = !numeratorAlternated;
            }
            return 0;
        }

        public int CompareTo(ContinuedFraction other)
        {
            return Compare(this,other);
        }
    }
}
