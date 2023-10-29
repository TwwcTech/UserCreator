using UserCreator.Backend.UserManagement;

namespace UserCreator.Frontend.PrimaryFrames
{
    public partial class UpdateUserForm : Form
    {
        public UpdateUserForm()
        {
            InitializeComponent();
        }

        private void UpdateUserForm_Load(object sender, EventArgs e)
        {
            ActiveControl = UpdateButton;
            WinUsersManagement localUserAccounts = new();
            localUserAccounts.GetLocalWindowsUsers();

            foreach (string userAccount in localUserAccounts.LocalUsers)
            {
                UsersCombobox.Items.Add(userAccount);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

        }
    }
}