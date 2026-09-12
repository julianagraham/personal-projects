import java.util.Scanner;

public class HauntedFearMeter {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        System.out.println("What is your name? ");
        String playerName = scanner.nextLine();
        System.out.println("What is your fear level? ");
        int fearLevel = scanner.nextInt();

        if (fearLevel >= 70) {
            System.out.println(playerName + " panics and runs away!");
        } else if (fearLevel >= 30) {
            System.out.println(playerName + " is nervous, but keeps going.");
        } else {
            System.out.println(playerName + " isn't scared at all!");
        }
        
        scanner.close();
    }
}
