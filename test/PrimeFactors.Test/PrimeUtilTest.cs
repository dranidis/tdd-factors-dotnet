namespace PrimeFactors.Test;

[TestClass]
public class PrimeUtilTest
{
    [TestMethod]
    [DataRow(1, new int[] { })]
    [DataRow(2, new int[] { 2 })]
    [DataRow(3, new int[] { 3 })]
    public void GetPrimeFactors_Returns_ListWithPrimeFactorsOfTheProvidedNumber(int number, int[] intArrayExpected)
    {
        // Arrange
        var expected = intArrayExpected.ToList();
        // Act
        var actual = Prime.GetPrimeFactors(number);
        // Assert
        Console.WriteLine("Actual: [" + string.Join(", ", actual) + "]");
        CollectionAssert.AreEqual(expected, actual);
    }

}