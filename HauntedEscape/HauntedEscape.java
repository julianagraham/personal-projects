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

            keys += 1;
            fear += 5;

        } else if (roomChoice == 2) {
            System.out.println("You go upstairs.");
            System.out.println("You find an old candle on a dresser.");

            candles += 1;
            fear += 15;

        } else if (roomChoice == 3) {
            System.out.println("You enter the basement.");
            System.out.println("Something whispers you name from the darkness.");

            fear += 30;

        } else {
            System.out.println("Invalid choice.");
        }

        System.out.println();
        System.out.println("CURRENT STATUS");
        System.out.println();
        System.out.println("Keys: " + keys);
        System.out.println("Candles: " + candles);
        System.out.println("Fear: " + fear + "/100");

        scanner.close();
    }
}
