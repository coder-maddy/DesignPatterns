namespace Observer.Extensions
{
    internal static class RandomExtensions
    {
        public static double NextDouble(this Random random, int min, int max)
        {
            var fraction = random.Next(min, max);
            return random.NextDouble() * fraction;
        }
    }
}
