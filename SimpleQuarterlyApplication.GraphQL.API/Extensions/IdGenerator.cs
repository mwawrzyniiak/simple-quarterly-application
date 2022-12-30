namespace SimpleQuarterlyApplication.GraphQL.API.Extensions
{
    public static class IdGenerator
    {
        private static Random random = new Random();
        public static string GenerateId() => random.Next(10000, 99999).ToString();
    }
}
