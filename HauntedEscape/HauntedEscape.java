import java.util.Scanner;

public class HauntedEscape {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);


        System.out.println("===============================");
        System.out.println("        HAUNTED ESCAPE         ");
        System.out.println("===============================");
        System.out.println();
        System.out.println("Escape the mansion before it's too late!");
        System.out.println();

        System.out.println("What is your name? ");
        String playerName = scanner.nextLine();
        System.out.println();
        int fear = 0;
        int keys = 0;
        int candles = 1;
        System.out.println("Welcome to Blackwood Mansion, " + playerName + "!");
        System.out.println();
        System.out.println("STARTING INVENTORY");
        System.out.println();
        System.out.println("Keys: " + keys);
        System.out.println("Candles: " + candles);
        System.out.println("Fear: " + fear + "/100");

        System.out.println();
        System.out.println("Where would you like to go?");
        System.out.println();
        System.out.println("1. Kitchen");
        System.out.println("2. Upstairs");
        System.out.println("3. Basement");
        System.out.println();
        System.out.println("Enter your choice: ");
        int roomChoice = scanner.nextInt();
        System.out.println();

        if (roomChoice == 1) {
            System.out.println("You enter the kitchen.");
            System.out.println("You find a rusty key beside the sink.");
            System.out.println("What do you do? ");
            System.out.println();
            System.out.println("1. Take the key");
            System.out.println("2. Leave the key");
            int kitchenChoice = scanner.nextInt();

            if (kitchenChoice == 1) {
                System.out.println("You take the key.");
                keys += 1;
            } else if (kitchenChoice == 2) {
                System.out.println("You leave the key.");
                fear += 2;
            } else {
                System.out.println("Invalid choice.");
            }
        } else if (roomChoice == 2) {
            System.out.println("You go upstairs.");
            System.out.println("You find an old candle on a dresser.");
            System.out.println("What do you do? ");
            System.out.println();
            System.out.println("1. Take the candle");
            System.out.println("2. Leave the candle");
            int upstairsChoice = scanner.nextInt();
            
            if (upstairsChoice == 1) {
                System.out.println("You take the candle.");
                candles += 1;
            } else if (upstairsChoice == 2) {
                System.out.println("You leave the candle.");
                fear += 5;
            } else {
                System.out.println("Invalid choice.");
            }
        } else if (roomChoice == 3) {
            System.out.println("You enter the basement.");
            System.out.println("Something whispers your name from the darkness.");
            System.out.println();
            System.out.println("You notice a small wooden box in the corner.");
            System.out.println();
            System.out.println("What do you do?");
            System.out.println();
            System.out.println("1. Open the box");
            System.out.println("2. Leave the basement");
            int basementChoice = scanner.nextInt();
     
            if (basementChoice == 1) {
                System.out.println("You found a key.");
                keys += 1;
                fear += 20;
            } else if (basementChoice == 2) {
                System.out.println("You leave the basement.");
                fear += 10;
            } else {
                System.out.println("Invalid choice.");
            }

        } else {
            System.out.println("Invalid choice.");
        }

        System.out.println();
        System.out.println("CURRENT STATUS");
       
        if (fear >= 100) {
            System.out.println();
            System.out.println("Your fear has reached 100. You are too terrified to escape.");
        } else if (keys >= 1) {
            System.out.println("You found a key. You may be one step closer to escaping.");
        } else {
            System.out.println("You still need to find a key.");
        }
        System.out.println();
        System.out.println("Keys: " + keys);
        System.out.println("Candles: " + candles);
        System.out.println("Fear: " + fear + "/100");

        scanner.close();
    }
}
