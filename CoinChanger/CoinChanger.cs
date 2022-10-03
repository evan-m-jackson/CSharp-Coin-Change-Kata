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
                
                if (remaining_coins > 0){
                    result = comma_added(result);
                }
        }

        return result;
    }

    private int cent_amount(int number) {
        if (number >= 25){
            return 25;
        }
        else if (number >= 10){
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
        if (number == 25){
            return "Quarter";
        }
        if (number == 10){
            return "Dime";
        }
        else if (number == 5) {
            return "Nickel";
        }
        else{
            return "Penny";
        }
    }

    private String comma_added(String str) {
        return str += ", ";
    }
}
