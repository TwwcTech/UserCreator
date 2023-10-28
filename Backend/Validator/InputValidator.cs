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
            return (emptyTextboxes == 0) ? true : false;
        }

        public static bool IsPasswordSecure(string password)
        {
            //Regex lowerMatch = new("[a-z]");
            //Regex upperMatch = new("[A-Z]");
            //Regex numberMatch = new("/d");
            //Regex symbolMatch = new("[-!@#$%^&*()?_,.]");
            Regex securityCriteria = new(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@#$%^&+=!])(?!.*\s).*$");

            if (password.Length >= 8 && securityCriteria.IsMatch(password))
            {
                return true;
            }
            return false;
        }
    }
}