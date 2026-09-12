import java.util.Scanner;

public class GhostFearMeter {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        System.out.println("What is your name? ");
        String playerName = scanner.nextLine();
        System.out.println("What is your fear level?" );
        int fearLevel = scanner.nextInt();

        if (fearLevel >= 50) {
            System.out.println(playerName + " is too scared to continue!");
        } else {
            System.out.println(playerName + " bravely continues through the mansion!");
        }
    }
}
