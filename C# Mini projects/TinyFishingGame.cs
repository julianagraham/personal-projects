namespace FishingPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Player's starting variables
            string playerName = "Jules";
            int coins = 20;
            int fishCaught = 0;
            int rodLevel = 1;
            bool hasBait = false;
            int baitPrice = 5;
            int fishValue = 3;
            bool rodReady = true;

            // Display the player's starting stats
            Console.WriteLine("UNDERWATER FISHING");
            Console.WriteLine();
            Console.WriteLine($"Welcome, {playerName}!");
            Console.WriteLine();
            Console.WriteLine("YOUR STATS");
            Console.WriteLine($"Coins: {coins}");
            Console.WriteLine($"Fish caught: {fishCaught}");
            Console.WriteLine($"Rod Level: {rodLevel}");
            Console.WriteLine($"Bait Available: {hasBait}");

            // Check whether the player already has bait
            if (hasBait)
            {
                Console.WriteLine("Your fishing rod is ready!");
            } else
            {
                Console.WriteLine("You need more bait!");
            }

            // Check whether the player can afford bait
            if (coins >= baitPrice)
            {
                Console.WriteLine("You bought some bait!");
                coins -= baitPrice;
                hasBait = true;
                Console.WriteLine($"Coins remaining: {coins}");
                Console.WriteLine($"Bait available: {hasBait}");
            } else
            {
                Console.WriteLine("You don't have enough coins to buy bait!");
            }

            // Check whether the player is ready to fish
            if (hasBait && rodReady)
            {
                Console.WriteLine("You can fish!");

                fishCaught = CatchFish(fishCaught, fishValue);
                Console.WriteLine($"Back in Main: {fishCaught}");

                coins = GiveCoins(coins, fishValue);
                Console.WriteLine($"Back in Main: {coins}");

            } else if (!hasBait && rodReady)
            {
                Console.WriteLine("Sorry, you need more Bait.");
            
            } else if (hasBait && !rodReady)
            {
                Console.WriteLine("Sorry, your rod is not ready.");
            } else
            {
                Console.WriteLine("Sorry, your rod is not ready and you dont have enough bait!");
            }
        }
        // Handle catching a fish
        static int CatchFish(int fishCaught, int fishValue)
        {
            Console.WriteLine("You caught a fish!");
            Console.WriteLine($"This fish is worth {fishValue} coins!");

            fishCaught += 1;

            Console.WriteLine($"Total fish caught: {fishCaught}");

            return fishCaught;
        }
        // Add the fish reward to the player's coins
        static int GiveCoins(int coins, int fishValue)
        {
            coins += fishValue;

            Console.WriteLine($"{fishValue} coins have been rewarded to you!");
            Console.WriteLine($"Total coins: {coins}");

            return coins;
        }
    }
}