namespace CoffeeShopPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Shop's starting stats
            string shopName = "Bean & Bloom";
            int shopMoney = 20;
            int coffeesMade = 0;
            int coffeePrice = 5;
            bool milkAvailable = true;
            bool hasCoffeeBeans = true;

            // Display the shop's starting stats
            Console.WriteLine($"{shopName}");
            Console.WriteLine();
            Console.WriteLine($"Welcome to {shopName}!");
            Console.WriteLine();
            Console.WriteLine("SHOP STATS");
            Console.WriteLine($"Money: ${shopMoney}");
            Console.WriteLine($"Coffees made: {coffeesMade}");
            Console.WriteLine($"Coffee price: ${coffeePrice}");

            // Check whether the shop has enough supplies
            if (hasCoffeeBeans && milkAvailable)
            {
                Console.WriteLine("The shop has everything needed to make coffee!");

                coffeesMade = MakeCoffee(coffeesMade);
                Console.WriteLine($"Back in Main, coffees made: {coffeesMade}");
                
                shopMoney = SellCoffee(shopMoney, coffeePrice);
                Console.WriteLine($"Back in main, shop money: ${shopMoney}");
            } else if (!hasCoffeeBeans && milkAvailable)
            {
                Console.WriteLine("The shop is out of coffee beans!");
            } else if (hasCoffeeBeans && !milkAvailable)
            {
                Console.WriteLine("The shop is out of milk!");
            } else
            {
                Console.WriteLine("The shop is out of all supplies!");
            }

        }
        // Handle making a coffee
        static int MakeCoffee(int coffeesMade)
        {
            coffeesMade += 1;

            Console.WriteLine($"The shop has made {coffeesMade} coffee!");
            
            return coffeesMade;
        }

        // Handle selling the coffee
        static int SellCoffee(int shopMoney, int coffeePrice)
        {
            shopMoney += coffeePrice;

            Console.WriteLine($"The shop has earned ${coffeePrice}!");
            Console.WriteLine($"The shop now has ${shopMoney}");

            return shopMoney;
        }
    }
}