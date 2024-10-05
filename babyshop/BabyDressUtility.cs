using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace babyshop
{
    public class BabyDressUtility:BabyDress
    {
        internal static void AddDressToCart(BabyDress dress)
        {
            throw new NotImplementedException();
        }

        public void AddDressToCart(BabyDress dress, BabyDress dress1)
        {
            Program.DressesCart.Add(dress);
        }
        public bool RemoveDressFromCart(string brand)
        {
            foreach (var dress in Program.DressesCart)
            {
                if (dress.Brand == brand)
                {
                    Program.DressesCart.Remove(dress);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}
