namespace FishingPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // adding variables
            string playerName = "Jules";
            int coins = 20;
            int fishCaught = 0;
            int rodLevel = 1;
            bool hasBait = true;

            // adding starting stats
            Console.WriteLine("UNDERWATER FISHING");
            Console.WriteLine();
            Console.WriteLine($"Welcome, {playerName}!");
            Console.WriteLine();
            Console.WriteLine("YOUR STATS");
            Console.WriteLine($"Coins: {coins}");
            Console.WriteLine($"Fish caught: {fishCaught}");
            Console.WriteLine($"Rod Level: {rodLevel}");
            Console.WriteLine($"Bait Available: {hasBait}");
        }
    }
}