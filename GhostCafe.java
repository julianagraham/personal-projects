public class GhostCafe {
    public static void main(String[] args) {
        // create strings and ints //
        String playerName = "Mochi";
        int startingCoins = 30;
        int cookiePrice = 4;
        int cookiesBought = 3;
        int totalCost = cookiePrice * cookiesBought;
        int coinsRemaining = startingCoins - totalCost;

        System.out.println("Welcome, " + playerName + "!");
        System.out.println();
        System.out.println("Cookies bought: " + cookiesBought);
        System.out.println("Price per cookie: " + cookiePrice + " coins");
        System.out.println("Total cost: " + totalCost + " coins");
        System.out.println("Coins remaining: " + coinsRemaining + " coins");

    }
}