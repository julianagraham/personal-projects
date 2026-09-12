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
        System.out.println("Welcome to Blackwood Mansion, " +playerName + "!");
        System.out.println();
        System.out.println("STARTING INVENTORY");
        System.out.println();
        System.out.println("Keys: " + keys);
        System.out.println("Candles: " + candles);
        System.out.println("Fear: " + fear + "/100");

        scanner.close();
    }
}