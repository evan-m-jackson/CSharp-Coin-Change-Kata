namespace CoinChanger;
public class CoinChanger
{
    public String change(int coin) {
        int remaining_coins = coin;
        string result = "";

        while (remaining_coins > 0){
            if (remaining_coins >= 5){
                result += "5, ";
                remaining_coins -= 5;
            } else {
                result += "1, ";
                remaining_coins -= 1;
            } 
            
        }

        return result[0..^2];
    }
}
