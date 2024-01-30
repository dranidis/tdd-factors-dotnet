namespace PrimeFactors;

public class Prime
{
    public static List<int> GetPrimeFactors(int number)
    {
        List<int> primeFactors = new();
        if (number > 1)
        {
            while (number % 2 == 0)
            {
                primeFactors.Add(2);
                number /= 2;
            }

            while (number % 3 == 0)
            {
                primeFactors.Add(3);
                number /= 3;
            }

            if (number > 1)
            {
                primeFactors.Add(number);
            }
        }
        return primeFactors;
    }
}