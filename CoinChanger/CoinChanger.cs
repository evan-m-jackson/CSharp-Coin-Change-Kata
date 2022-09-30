namespace CoinChanger;
public class CoinChanger
{
    public string change(int number)
    {
        string result = "";
        int remaining = number;

        do
        {
            if (remaining >= 5)
            {
                result += "5, ";
                remaining -= 5;
            }

            else
            {
                result += "1, ";
                remaining -= 1;
            }

            
        } while (remaining > 0);
        return result.Remove(result.Length - 2);
    }
}
