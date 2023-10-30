using System.Text.RegularExpressions;

namespace UserCreator.Backend.Validator
{
    internal static partial class InputValidator
    {
        private static readonly Regex _securityCriteria = PasswordRegex();

        public static bool AreTextboxesEmpty(TextBox[] textboxes)
        {
            int emptyTextboxes = textboxes.Length;
            for (int textboxIndex = 0; textboxIndex < emptyTextboxes; textboxIndex++)
            {
                if (!string.IsNullOrWhiteSpace(textboxes[textboxIndex].Text))
                {
                    emptyTextboxes--;
                }
            }
            if (emptyTextboxes == 0)
            {
                return false;
            }
            return true;
        }

        public static bool IsPasswordSecure(string password)
        {
            return password.Length >= 8 && _securityCriteria.IsMatch(password);
        }

        [GeneratedRegex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@#$%^&+=!])(?!.*\s).*$")]
        private static partial Regex PasswordRegex();
    }
}