using System.Text.RegularExpressions;

namespace UserCreator.Backend.Validator
{
    internal static class InputValidator
    {
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
            return (emptyTextboxes == 0) ? false : true;
        }

        public static bool IsPasswordSecure(string password)
        {
            Regex letterMatch = new(@"(?=.*[a-z])(?=.*[A-Z])");
            Regex numberMatch = new("/d");
            Regex symbolMatch = new(@"[-!@#$%^&*()?_,.]");

            return (password.Length >= 8 && letterMatch.IsMatch(password) && numberMatch.IsMatch(password) && symbolMatch.IsMatch(password));
        }
    }
}