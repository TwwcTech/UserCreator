using UserCreator.Backend.UserManagement;

namespace UserCreator.Frontend.PrimaryFrames
{
    public partial class DeleteUserForm : Form
    {
        public DeleteUserForm()
        {
            InitializeComponent();
        }

        private void DeleteUserForm_Load(object sender, EventArgs e)
        {
            ActiveControl = DeleteButton;
            WinUsersManagement localUserAccounts = new();
            localUserAccounts.GetLocalWindowsUsers();

            foreach (string userAccount in localUserAccounts.LocalUsers)
            {
                DeleteUserComboBox.Items.Add(userAccount);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DeleteUserComboBox.Text))
            {
                MessageBox.Show("Must select a user to update", "User Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            WinUsersManagement deleteUserManagement = new()
            {
                Username = DeleteUserComboBox.Text.Trim()
            };
            deleteUserManagement.DeleteUser();
        }
    }
}