namespace PrimeFactors;

public class Prime
{
    public static List<int> GetPrimeFactors(int number)
    {
        List<int> primeFactors = new();
        if (number > 1)
        {
            if (number % 2 == 0)
            {
                primeFactors.Add(2);
                number /= 2;
            }
            if (number > 1)
            {
                primeFactors.Add(number);
            }
        }
        return primeFactors;
    }
}