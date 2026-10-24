using CSharp.Numbers;

namespace CSharp;

public static class Problem010
{
    /// <Summary>
    /// Finds the sum of primes below 2 million.
    /// </Summary>

    public static long SummationOfPrimes(long limit)
    {
        List<long> primes = Primes.GetSieveOfEratosthenes(limit);

        long sum = 0;
        foreach (long prime in primes)
            sum += prime;

        return sum;
    }

    public static string Execute() => $"The sum of all primes below 2 million is: {SummationOfPrimes(2_000_000)}";
}