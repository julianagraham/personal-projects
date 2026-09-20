namespace PetGroomingSalon
{
    class Program
    {
        static void Main(string[] args)
        {
            // Salon's starting variables
            string shopName = "Paws & Bubbles";
            int salonMoney = 50;
            int dogsGroomed = 0;
            int groomingPrice = 15;
            bool shampooAvailable = true;
            bool clippersWorking = true;

            // Display salon's starting stats
            Console.WriteLine($"Welcome to {shopName}!");
            Console.WriteLine();
            Console.WriteLine("SALON STATS");
            Console.WriteLine();
            Console.WriteLine($"Money: ${salonMoney}");
            Console.WriteLine($"Dogs groomed: {dogsGroomed}");
            Console.WriteLine($"Grooming price: ${groomingPrice}");

            // Check whether the salon is ready to groom a dog
            if (shampooAvailable && clippersWorking)
            {
                Console.WriteLine("The salon is ready to groom!");

                dogsGroomed = GroomDog(dogsGroomed);
                Console.WriteLine($"Back in main, dogs groomed: {dogsGroomed}");

                salonMoney = GroomPayment(salonMoney, groomingPrice);
                Console.WriteLine($"Back in main, salon money: ${salonMoney}");
            } else if (!shampooAvailable && clippersWorking)
            {
                Console.WriteLine("Sorry, the salon has no shampoo!");
            } else if (shampooAvailable && !clippersWorking)
            {
                Console.WriteLine("Sorry, the clipper's are not working!");
            } else
            {
                Console.WriteLine("Sorry, the salon is out of equipment!");
            }
        }
        // Handle a dog getting groomed
        static int GroomDog(int dogsGroomed)
        {
            dogsGroomed += 1;

            Console.WriteLine($"The salon has groomed {dogsGroomed} dog!");

            return dogsGroomed;
        }
        // Handle receiving payment
        static int GroomPayment(int salonMoney, int groomingPrice)
        {
            salonMoney += groomingPrice;

            Console.WriteLine($"The salon has earned: {groomingPrice}");

            return salonMoney;
        }
    }
}