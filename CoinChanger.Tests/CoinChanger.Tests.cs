namespace CoinChanger.Tests;
public class CoinChangerTests
{
    [Theory]
    [InlineData(1, "Penny")]
    [InlineData(2, "Penny, Penny")]
    [InlineData(3, "Penny, Penny, Penny")]
    [InlineData(4, "Penny, Penny, Penny, Penny")]
    [InlineData(5, "Nickel")]
    [InlineData(6, "Nickel, Penny")]
    [InlineData(7, "Nickel, Penny, Penny")]
    [InlineData(8, "Nickel, Penny, Penny, Penny")]
    [InlineData(9, "Nickel, Penny, Penny, Penny, Penny")]
    [InlineData(10, "Dime")]
    public void CoinChanger_Tests(int cents, String expected){
        var coinChanger = new CoinChanger();

        string result = coinChanger.change(cents);

        Assert.Equal(expected, result);
    }
}