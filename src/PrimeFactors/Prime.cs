namespace PrimeFactors;

public class Prime
{
    public static List<int> GetPrimeFactors(int number)
    {
        List<int> primeFactors = new();

        for (int i = 2; i <= number; i++)
        {
            while (number % i == 0)
            {
                primeFactors.Add(i);
                number /= i;
            }
        }

        if (number > 1)
        {
            primeFactors.Add(number);
        }

        return primeFactors;
    }
}