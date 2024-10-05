using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace babyshop
{
   
    public class BabyDress
    {
    private static List<BabyDress> DressesCart { get; set; } = new List<BabyDress>() { };
            public int Size { get; set; }
            public string Color { get; set; }
            public string Brand { get; set; }
            public double Price { get; set; }

        
    }
}
