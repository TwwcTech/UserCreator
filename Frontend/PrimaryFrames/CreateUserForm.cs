using UserCreator.Backend.UserManagement;
using UserCreator.Backend.Validator;

namespace UserCreator.Frontend.PrimaryFrames
{
    public partial class CreateUserForm : Form
    {
        public CreateUserForm()
        {
            InitializeComponent();
        }

        private void CreateUserForm_Load(object sender, EventArgs e)
        {
            ActiveControl = CreateButton;
            DayMonthPicker.Enabled = false;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            bool areTextboxesEmpty = InputValidator.AreTextboxesEmpty(new TextBox[] { NewUsernameTextbox, NewPasswordTextbox });
            if (areTextboxesEmpty)
            {
                MessageBox.Show("Entries must not be empty", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (InputValidator.IsPasswordSecure(NewPasswordTextbox.Text.Trim()))
                {
                    WinUsersManagement newLocalUser = new()
                    {
                        Username = NewUsernameTextbox.Text.Trim(),
                        Password = NewPasswordTextbox.Text.Trim(),
                        EnableAdmin = AdminCheckbox.Checked,
                        Description = DescriptionTextbox.Text.Trim(),
                        AccountExpirationLength = AccountExpirationCheckbox.Checked ? DayMonthPicker.Value : default
                    };
                    newLocalUser.CreateUser();
                }
                else
                {
                    MessageBox.Show("Password must contain a number, a symbol, and must be at least 8 characters in length", "Password Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AccountExpirationCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            DayMonthPicker.Enabled = AccountExpirationCheckbox.Checked;
        }
    }
}