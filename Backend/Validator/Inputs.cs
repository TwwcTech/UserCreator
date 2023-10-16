namespace UserCreator.Backend.Validator
{
    internal class Inputs
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
    }
}
