namespace exam
{
    public class Program
    {
        static string Species = string.Empty;
        static void Main(string[] args)
        {
            
            fish fish = new fish();
            Fishutility fishUtility = new Fishutility();

            Console.WriteLine("Enter the species to buy");
            Species= Console.ReadLine();

            Console.WriteLine("Enter the price per fish");
            double PricePrefish=double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the number of fishes you need to buy");
            //int numberOfFishes=int.Parse( Console.ReadLine());

            if (fishUtility.BuyFish())
            {
                Console.WriteLine("Enter the number of fishes you need to buy");
                int n = int.Parse(Console.ReadLine());

                double TotalPrice = fishUtility.CalculatePrice(n);
                Console.WriteLine("Total cost is" + TotalPrice);

               
                fishUtility.AddFish(Species, PricePrefish);


            }
            else
            {
                Console.WriteLine($"{fishUtility.Species} species not found");
            }

           
        }
    }
}
