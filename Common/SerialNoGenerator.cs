namespace CompanySystem.Common
{
    public class SerialNoGenerator
    {
        private static Random random = new Random();
        public static string RandomString()
        {
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, 6)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
