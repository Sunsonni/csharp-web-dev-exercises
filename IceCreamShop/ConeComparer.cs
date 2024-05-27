using System;

namespace IceCreamShop 
{
    public class ConeComparer : IComparer<Cone>
    {
        public int Compare(Cone x, Cone y)
        {
            double difference = x.Cost - y.Cost;
            if(difference == 0)
            {
                return 0;
            }
            else if (difference < 0)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
    }
}