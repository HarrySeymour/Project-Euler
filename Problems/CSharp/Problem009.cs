namespace CSharp;

public static class Problem009
{
    ///<Summary>
    /// 
    /// </Summary>

    public static List<(int a, int b, int c)> GetPythagoreanTriplets()
    {
        var triplets = new List<(int a, int b, int c)>();
        const int perimeter = 1000;

        for (int a = 1; a < perimeter / 3; a++)
        {
            int numerator = (perimeter * perimeter) - (2 * perimeter * a);
            int denominator = (2 * perimeter) - (2 * a);

            if (numerator % denominator == 0)
            {
                int b = numerator / denominator;
                int c = perimeter - a - b;

                if (a < b)
                {
                    triplets.Add((a, b, c));
                }
            }
        }

        return triplets;
    }

    public static string Execute()
    {
        var triplets = GetPythagoreanTriplets();
        var (a, b, c) = triplets[0];

        return $"The triplet is ({a}, {b}, {c}) and the product abc = {a * b * c}";
    }
}