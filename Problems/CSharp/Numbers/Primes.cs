namespace CSharp.Numbers;

public static class Primes
{
    /// <summary>
    /// Gets all the primes below a certain limit.
    /// </summary>
    public static List<long> GetSieveOfEratosthenes(long n)
    {
        if (n <= 1) return new List<long>();

        bool[] isComposite = new bool[n + 1];
        List<long> primeNumbers = new List<long>();

        long limit = (long)Math.Sqrt(n);
        for (long i = 2; i <= limit; i++)
        {
            if (!isComposite[i])
            {
                for (long j = i * i; j <= n; j += i)
                    isComposite[j] = true;
            }
        }

        for (long i = 2; i <= n; i++)
        {
            if (!isComposite[i])
                primeNumbers.Add(i);
        }

        return primeNumbers;
    }

    /// <summary>
    /// Gets the first n prime numbers
    /// </summary>
    public static List<long> GetSieveOfEratosthenesByCount(int count)
    {
        if (count < 1) throw new ArgumentException("Count must be at least 1.");

        if (count < 6)
        {
            var tinyPrimes = new List<long> { 2, 3, 5, 7, 11 };
            return tinyPrimes.GetRange(0, count);
        }

        double k = count;
        double logK = Math.Log(k);
        long upperBound = (long)(k * logK + k * Math.Log(logK)) + 5;

        List<long> allPrimesUpToLimit = GetSieveOfEratosthenes(upperBound);

        return allPrimesUpToLimit.GetRange(0, count);
    }
}