namespace UnitTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    // 1
    [Test]
    public void UnderCritAmount()
    {
        Pin pin = new Pin();
        Assert.That(false, Is.EqualTo(pin.Expend(349)));
    }

    // 2
    [Test]
    public void OverCritAmount()
    {
        Pin pin = new Pin();
        Assert.That(true, Is.EqualTo(pin.Expend(351)));
    }

    // 3
    [Test]
    public void ThreePurchases()
    {
        Pin pin = new Pin();
        for (int i = 0 ; i<2 ; i++)
        {
            pin.Expend(100);
        }
        Assert.That(false, Is.EqualTo(pin.Expend(100)));
    }

    // 4
    [Test]
    public void FourPurchases()
    {
        Pin pin = new Pin();
        for (int i = 0 ; i<3 ; i++)
        {
            pin.Expend(100);
        }
        Assert.That(true, Is.EqualTo(pin.Expend(100)));
    }

    // 5
    [Test]
    public void CritAndFour()
    {
        Pin pin = new Pin();
        for (int i = 0 ; i<3 ; i++) {
            pin.Expend(351);
        }
        Assert.That(true, Is.EqualTo(pin.Expend(351)));
    }

    // 6
    [Test]
    public void CritAndThree()
    {
        Pin pin = new Pin();
        for (int i = 0 ; i<2 ; i++) {
            pin.Expend(351);
        }
        Assert.That(true, Is.EqualTo(pin.Expend(351)));
    }

    // 7
    [Test]
    public void RandomTest()
    {
        int n = 0;
        int amount = 10000000;
        RandomPin pin = new RandomPin();
        for (int i = 0 ; i<amount ; i++)
        {
            if (pin.Expend(1))
            {
                n++;
            }
        }
        Console.WriteLine(n);
        Assert.That(n, Is.GreaterThan(amount*0.15)&Is.LessThan(amount*0.25));
    }
}