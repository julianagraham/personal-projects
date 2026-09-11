import java.util.Scanner;

public class HauntedPetShop {
     public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

            System.out.println("HAUNTED PET SHOP");
            System.out.println();
            System.out.print("What is your name? ");
            String playerName = scanner.nextLine();
            System.out.println("How many coins do you have? ");
            int startingCoins = scanner.nextInt();
            System.out.println("How many ghost cats would you like to adopt? ");
            int ghostCatsBought = scanner.nextInt();
            int ghostCatPrice = 12;
            System.out.println("The shop charges " + ghostCatPrice + " coins per ghost cat.");
            
            int totalCost = ghostCatPrice * ghostCatsBought;

            if (startingCoins >= totalCost) {

            int coinsRemaining = startingCoins - totalCost;

            System.out.println();
            System.out.println("ADOPTION SUMMARY");
            System.out.println();
            System.out.println("Customer: " + playerName);
            System.out.println("Ghost cats adopted: " + ghostCatsBought);
            System.out.println("Price per ghost cat: " + ghostCatPrice + " coins");
            System.out.println("Total cost: " + totalCost + " coins");
            System.out.println("Coins remaining: " + coinsRemaining + " coins");
            } else {

                System.out.println();
                System.out.println("ADOPTION FAILED");
                System.out.println();
                System.out.println("Sorry, " + playerName + "!");
                System.out.println("You don't have enough coins.");
            }
            scanner.close();
     }
}