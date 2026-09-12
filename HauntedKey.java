import java.util.Scanner;

public class HauntedKey {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        System.out.println("What is your name? ");
        String playerName = scanner.nextLine();
        System.out.println("How many keys do you have? ");
        int startingKeys = scanner.nextInt();

        if (startingKeys == 3) {
            System.out.println("The secret door opens for " + playerName + "!");
        } else {
            System.out.println("The secret door remains locked. ");
        }
        scanner.close();
    }
}