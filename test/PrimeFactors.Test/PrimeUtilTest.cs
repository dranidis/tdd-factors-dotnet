namespace PrimeFactors.Test;

[TestClass]
public class PrimeUtilTest
{
    [TestMethod]
    [DataRow(1, new int[] { })]
    [DataRow(2, new int[] { 2 })]
    [DataRow(3, new int[] { 3 })]
    [DataRow(4, new int[] { 2, 2 })]
    [DataRow(8, new int[] { 2, 2, 2 })]
    [DataRow(9, new int[] { 3, 3 })]
    [DataRow(2 * 3 * 3 * 5 * 7 * 11 * 13 * 13,
    new int[] { 2, 3, 3, 5, 7, 11, 13, 13 })]
    public void GetPrimeFactors_Returns_ListWithPrimeFactorsOfTheProvidedNumber(int number, int[] intArrayExpected)
    {
        // Arrange
        var expected = intArrayExpected.ToList();
        // Act
        var actual = Prime.GetPrimeFactors(number);
        // Assert
        Console.WriteLine("Input:" + number + " Actual: [" + string.Join(", ", actual) + "]");
        CollectionAssert.AreEqual(expected, actual);
    }

}