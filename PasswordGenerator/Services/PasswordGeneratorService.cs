using System.Text;

namespace PasswordGenerator.Services
{
    internal class PasswordGeneratorService
    {
        private readonly string _upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private readonly string _lowerCase = "abcdefghijklmnopqrstuvwxyz";
        private readonly string _number = "0123456789";
        private readonly string _specialChars = "!@#$%&?:~";

        public string GeneratePassword(int length, bool upperCase, bool lowerCase, bool number, bool specialChars)
        {
            StringBuilder password = new StringBuilder();
            Random random = new Random();
            string charsSort = "";

            if (upperCase) charsSort += _upperCase;

            if (lowerCase) charsSort += _lowerCase; 

            if (number) charsSort += _number; 

            if (specialChars) charsSort += _specialChars;

            if (charsSort.Length == 0) charsSort += _lowerCase;

            for (int i = 0; i < length; i++)
            {
                password.Append(charsSort[random.Next(charsSort.Length)]);
            }

            return password.ToString();

        }
    }
}
