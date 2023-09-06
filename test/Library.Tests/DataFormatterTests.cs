using TestDateFormat;

[TestFixture]
public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void FormaCorrecta()
    {
        string date = "06/09/2023";
        string expected = "2023-09-06";
        string output = DateFormatter.ChangeFormat(date);
        Assert.AreEqual(expected, output);
    }

    [Test]
    public void MalFormato()
    {
        string date = "6/2023";
        string expected = "2023-09-06";
        string output = DateFormatter.ChangeFormat(date);
        Assert.AreNotEqual(expected, output);
    }

    [Test]
    public void StringVacio()
    {
        string date = "";
        string expected = "error";
        string output = DateFormatter.ChangeFormat(date);
        Assert.AreEqual(expected, output);
    }
}