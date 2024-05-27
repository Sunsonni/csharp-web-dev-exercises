using System;
using System.Dynamic;

namespace IceCreamShop{
    public class FlavorComparer : IComparer<Flavor>
    {
        public int Compare(Flavor x, Flavor y)
        {
            if (x.Allergens.Count < y.Allergens.Count)
            {
                return 1; 
            }
            else if (x.Allergens.Count > y.Allergens.Count)
            {
                return -1;
            }
            else 
            {
                return 0;
            }
        }
    }
}