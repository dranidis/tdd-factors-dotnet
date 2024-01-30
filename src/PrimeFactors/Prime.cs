namespace PrimeFactors;

public class Prime
{
    public static List<int> GetPrimeFactors(int number)
    {
        List<int> primeFactors = new();
        if (number > 1)
        {
            primeFactors.Add(number);
        }
        return primeFactors;
    }
}