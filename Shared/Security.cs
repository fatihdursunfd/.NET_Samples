using System.Text;

namespace Shared
{
    public static class Security
    {
        public static string GeneratePassword()
        {
            const string alphanumericCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                                                  "abcdefghijklmnopqrstuvwxyz" +
                                                  "0123456789" +
                                                  "-*?=})([]&%+^#^'!";

            var sb = new StringBuilder();
            var rnd = new Random();

            for (int i = 0; i < 15; i++)
            {
                sb.Append(alphanumericCharacters[rnd.Next(0, alphanumericCharacters.Length)]);
            }

            sb.Append("aA1.");

            return sb.ToString();
        }
    }
}