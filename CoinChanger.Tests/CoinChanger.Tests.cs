namespace CoinChanger.Tests;
public class CoinChangerTests
{
    [Theory]
    [InlineData(1, "1")]
    [InlineData(2, "1, 1")]
    [InlineData(3, "1, 1, 1")]
    [InlineData(4, "1, 1, 1, 1")]
    [InlineData(5, "5")]
    [InlineData(6, "5, 1")]
    [InlineData(7, "5, 1, 1")]
    [InlineData(8, "5, 1, 1, 1")]
    public void CoinChanger_Tests(int cents, String expected){
        var coinChanger = new CoinChanger();

        string result = coinChanger.change(cents);

        Assert.Equal(expected, result);
    }
}