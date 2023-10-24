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
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { NewUsernameTextbox, NewPasswordTextbox };
            bool areTextboxesEmpty = InputValidator.AreTextboxesEmpty(textBoxes);

            if (areTextboxesEmpty)
            {
                MessageBox.Show("Entries must not be empty", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (InputValidator.IsPasswordSecure(NewPasswordTextbox.Text.Trim()))
                {
                    WinUsersManagement newLocalUser = new();

                    newLocalUser.Username = NewUsernameTextbox.Text.Trim();
                    newLocalUser.Password = NewPasswordTextbox.Text.Trim();
                    newLocalUser.EnableAdmin = AdminCheckbox.Checked;
                    newLocalUser.Description = DescriptionTextbox.Text.Trim();
                    newLocalUser.CreateNewUser();
                }
                else
                {
                    MessageBox.Show("Password must contain a number, a symbol, and must be at least 8 characters in length", "Password Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void MadBadPassCheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AccountExpirationCheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}