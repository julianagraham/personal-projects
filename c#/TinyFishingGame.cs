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
        }
    }
}