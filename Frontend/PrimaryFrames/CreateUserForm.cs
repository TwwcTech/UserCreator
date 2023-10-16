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
                WinUsersManagement.CreateNewUser(NewUsernameTextbox.Text.Trim(), NewPasswordTextbox.Text.Trim(), AdminCheckbox.Checked);
            }
        }
    }
}
