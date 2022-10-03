namespace CoinChanger;
public class CoinChanger
{
    public String change(int coin) {
        int remaining_coins = coin;
        string result = "";

        while (remaining_coins > 0){
                int amount_of_change = cent_amount(remaining_coins);
                result += denomination(amount_of_change);
                remaining_coins -= amount_of_change;
        }

        return result[0..^2];
    }

    private int cent_amount(int number) {
        if (number >= 10){
            return 10;
        }
        else if (number >= 5) {
            return 5;
        }
        else {
            return 1;
        }
    }

    private String denomination(int number) {
        if (number == 10){
            return "Dime, ";
        }
        else if (number == 5) {
            return "Nickel, ";
        }
        else{
            return "Penny, ";
        }
    }
}
