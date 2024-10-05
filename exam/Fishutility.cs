using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    public class Fishutility:fish
    {

        public void AddFish(string speciecs,double pricePerFish)
        {
            this.Species= speciecs;
            this.PricePreFish = pricePerFish;
        }
        public bool BuyFish()
        {
            if(Species == "Clownfish")
            {
                return true;
            }
            else if (Species == "Goldfish")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double CalculatePrice(int numberOfFishes)
        {
            if (Species == "Clownfish")
            {
                return (numberOfFishes * PricePreFish) + 100;
          
            }
            else 
            {
               return (numberOfFishes * PricePreFish) + 150;
                
            }
           
            //switch (Species)
            //    case "Clownfish":

        }
    }
}
