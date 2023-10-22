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

            if (emptyTextboxes == 0)
            {
                return false;
            }
            return true;
        }

        public static bool IsPasswordSecure(string password)
        {
            Regex upperMatch = new(@"[A-Z]"); // update to include lowercase match
            Regex numberMatch = new("/d");
            Regex symbolMatch = new(@"[-!@#$%^&*()?_,.]");

            if (password.Length >= 8 && upperMatch.IsMatch(password) && numberMatch.IsMatch(password) && symbolMatch.IsMatch(password))
            {
                return true;
            }
            return false;
        }
    }
}
