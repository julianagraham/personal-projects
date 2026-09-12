import java.util.Scanner;

public class HauntedMansionDoor {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        System.out.println("What is your name? ");
        String playerName = scanner.nextLine();
        System.out.println();
        System.out.println("How old are you? ");
        int playerAge = scanner.nextInt();

        if (playerAge >= 18) {
            System.out.println("Welcome inside, " + playerName + "!");
        } else {
            System.out.println("Sorry, " + playerName + ". You cannot enter the mansion.");
        }

        scanner.close();
    }
}
