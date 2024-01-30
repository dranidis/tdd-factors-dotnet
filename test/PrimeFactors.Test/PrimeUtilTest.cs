namespace PrimeFactors.Test;

[TestClass]
public class PrimeUtilTest
{
    [TestMethod]
    public void GetPrimeFactors_Returns_EmptyList_When_ThereAreNoPrimeFactors_()
    {
        // Arrange
        var expected = new List<int>();
        // Act
        var actual = Prime.GetPrimeFactors(1);
        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetPrimeFactors_Returns_2_When_NumberIs_2()
    {
        // Arrange
        var expected = new List<int> { 2 };
        // Act
        var actual = Prime.GetPrimeFactors(2);
        // Assert
        Console.WriteLine("Actual list: [" + string.Join(", ", actual) + "]");
        CollectionAssert.AreEqual(expected, actual);
    }
}