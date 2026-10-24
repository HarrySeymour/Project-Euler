namespace CSharp;

public static class Problem007
{
    ///
    /// Returns the 10,001st Prime Number
    ///

    public static string Execute()
    {
        var primes = Numbers.Primes.GetSieveOfEratosthenesByCount(10001);
        return $"The 10,001st prime number is {primes[^1]}";
    }
}