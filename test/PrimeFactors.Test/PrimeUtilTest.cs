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
}