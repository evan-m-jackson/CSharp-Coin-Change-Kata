namespace CoinChanger.Tests;

public class CoinChangerTests
{
    [Fact]
    public void CoinChanger_One_Cent()
    {
        var coinChanger = new CoinChanger();
        string result = coinChanger.change(1);
        Assert.Equal("1", result);
    }

    [Fact]
    public void CoinChanger_Two_Cents()
    {
        var coinChanger = new CoinChanger();
        string result = coinChanger.change(2);
        Assert.Equal("1, 1", result);
    }

    [Fact]
    public void CoinChanger_Three_Cents()
    {
        var coinChanger = new CoinChanger();
        string result = coinChanger.change(3);
        Assert.Equal("1, 1, 1", result);
    }

    [Fact]
    public void CoinChanger_Four_Cents()
    {
        var coinChanger = new CoinChanger();
        string result = coinChanger.change(4);
        Assert.Equal("1, 1, 1, 1", result);
    }

    [Fact]
    public void CoinChanger_Five_Cents()
    {
        var coinChanger = new CoinChanger();
        string result = coinChanger.change(5);
        Assert.Equal("5", result);
    }

    [Fact]
    public void CoinChanger_Six_Cents()
    {
        var coinChanger = new CoinChanger();
        string result = coinChanger.change(6);
        Assert.Equal("5, 1", result);
    }

    [Fact]
    public void CoinChanger_Seven_Cents()
    {
        var coinChanger = new CoinChanger();
        string result = coinChanger.change(7);
        Assert.Equal("5, 1, 1", result);
    }

    [Fact]
    public void CoinChanger_Eight_Cents()
    {
        var coinChanger = new CoinChanger();
        string result = coinChanger.change(8);
        Assert.Equal("5, 1, 1, 1", result);
    }

}