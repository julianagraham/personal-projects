using System.Runtime.ConstrainedExecution;

namespace ArcadePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Player's starting variables
            string playerName = "Jules";
            int coins = 30;
            int credits = 0;
            int creditPrice = 5;
            int tickets = 0;
            int ticketsEarnedPerGame = 12;
            bool gameWorking = true;
            int prizeCost = 10;
            int prizesPurchased = 0;
            bool canAffordPrize = false;

            //Display player's starting stats
            Console.WriteLine("PIXEL ARCADE");
            Console.WriteLine($"Welcome, {playerName}!");
            Console.WriteLine();
            Console.WriteLine("PLAYER STATS");
            Console.WriteLine($"Coins: {coins}");
            Console.WriteLine($"Credits: {credits}");
            Console.WriteLine($"Tickets: {tickets}");

            // Check if player can afford to buy one credit
            if (coins >= creditPrice)
            {
                Console.WriteLine($"{playerName} can buy a credit!");

                credits = BuyCredit(credits);
                Console.WriteLine($"Back in main, credits: {credits}");

                coins = SpendCoins(creditPrice, coins);
                Console.WriteLine($"Back in main, coins: {coins}");
            } else
            {
                Console.WriteLine("Sorry, you don't have enough coins.");
            }

            // Check if player has enough credits to play a game
            if (credits >= 1 && gameWorking)
            {
                Console.WriteLine("The game is ready!");

                credits = UseCredit(credits);
                Console.WriteLine($"Back in main, credits: {credits}. You are ready to play.");

                tickets = EarnTickets(ticketsEarnedPerGame, tickets);
                Console.WriteLine($"Back in main: {tickets} tickets");

                canAffordPrize = CanAffordPrize(tickets, prizeCost);
            } else if (credits == 0 && gameWorking)
            {
                Console.WriteLine("Sorry, you need more credits!");
            } else if (credits >= 1 && !gameWorking)
            {
                Console.WriteLine("Sorry, the game is not working.");
            } else
            {
                Console.WriteLine("Sorry, you don't have enough credits and the game is not working.");
            }

            // Check if player can afford a prize
            if (canAffordPrize)
            {
                Console.WriteLine("You can afford the prize!");

                tickets = SpendTickets(tickets, prizeCost);
                Console.WriteLine($"Back in main, tickets: {tickets}");

                prizesPurchased = PrizeGained(prizesPurchased);
                Console.WriteLine($"Back in main, prizes: {prizesPurchased}");
            } else
            {
                Console.WriteLine("Sorry, you don't have enough tickets for the prize.");
            }
        }

        // Handle buying a game credit
        static int BuyCredit(int credits)
        {
            credits += 1;

            Console.WriteLine($"You have purchased {credits} credit!");

            return credits;
        }

        // Handle spending coins
        static int SpendCoins(int creditPrice, int coins)
        {
            coins -= creditPrice;

            Console.WriteLine($"You have spent: {creditPrice} coins. You now have: {coins} coins remaining.");

            return coins;
        }

        // Use one credit to play the game
        static int UseCredit(int credits)
        {
            credits -= 1;

            Console.WriteLine($"You have used 1 credit to play the game. You now have: {credits} credits left");

            return credits;
        }

        // Handle earning tickets
        static int EarnTickets(int ticketsEarnedPerGame, int tickets)
        {
            tickets += ticketsEarnedPerGame;

            Console.WriteLine($"You have earned {ticketsEarnedPerGame} tickets!");
            Console.WriteLine($"You now have: {tickets} tickets.");

            return tickets;
        }

        // Check if player can afford prize
        static bool CanAffordPrize(int tickets, int prizeCost)
        {
            
            if (tickets >= prizeCost)
            {
                return true;
            } else
            {
                return false;
            }
        }

        // Handle buying a prize
        static int SpendTickets(int tickets, int prizeCost)
        {
            tickets -= prizeCost;

            Console.WriteLine($"You spent {prizeCost} tickets. You now have {tickets} tickets remaining.");

            return tickets;
        }

        // Add purchased prize to player's total
        static int PrizeGained(int prizesPurchased)
        {
            prizesPurchased += 1;

            Console.WriteLine($"You have purchased {prizesPurchased} prizes!");

            return prizesPurchased;
        }
    }
}