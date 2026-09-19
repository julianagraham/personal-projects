namespace PotionDungeon
{
    class Program
    {
        static void Main(string[] args)
        {
            // Player's starting variables
            string playerName = "Jules";
            int gold = 25;
            int health = 100;
            int potions = 0;
            int potionPrice = 8;
            int monsterHealth = 30;
            int swordDamage = 12;
            bool hasSword = true;

            // Display player's starting stats
            Console.WriteLine("POTION DUNGEON");
            Console.WriteLine();
            Console.WriteLine($"Welcome, {playerName}!");
            Console.WriteLine();
            Console.WriteLine("YOUR STATS");
            Console.WriteLine($"Health: {health}");
            Console.WriteLine($"Gold: {gold}");
            Console.WriteLine($"Potions: {potions}");
            Console.WriteLine($"Sword Damage: {swordDamage}");

            // Check if player has at least one potion
            if (potions >= 1)
            {
                Console.WriteLine("You already have a potion!");
            } else
            {
                Console.WriteLine("You don't have any potions!");
            }

            // Check if player can afford a potion
            if (gold >= potionPrice)
            {
                Console.WriteLine("You can buy a potion!");

                potions = BuyPotion(potions, potionPrice);
                Console.WriteLine($"Back in main: {potions} potions");

                gold = SpendGold(gold, potionPrice);
                Console.WriteLine($"Back in main: {gold} gold");
            } else
            {
                Console.WriteLine("Sorry, you need more gold.");
            }

            // Check if player is ready to fight a monster
            Console.WriteLine("A monster appears!");

            if (hasSword)
            {
                Console.WriteLine("You are ready to fight the monster!");

                monsterHealth = AttackMonster(monsterHealth, swordDamage);
                Console.WriteLine($"Back in Main, Monster health: {monsterHealth} ");
            } else
            {
                Console.WriteLine("Sorry, your sword is not ready yet!");
            }
        }
         // Handle buying a potion
        static int BuyPotion(int potions, int potionPrice)
        {
             potions += 1;
            Console.WriteLine($"You bought a potion for {potionPrice} coins!");
            Console.WriteLine($"You now have {potions} potions!");

            return potions;
        }
        // Subtract the potion cost from the player's gold
        static int SpendGold(int gold, int potionPrice)
        {
            gold -= potionPrice;
            Console.WriteLine($"You have {gold} gold left!");

            return gold;
        }

        // Handle attacking the monster
        static int AttackMonster(int monsterHealth, int swordDamage)
        {
            monsterHealth -= swordDamage;
            Console.WriteLine($"You attack the monster for {swordDamage} damage");
            Console.WriteLine($"Monster health: {monsterHealth}");

            return monsterHealth;
        }
    }
}