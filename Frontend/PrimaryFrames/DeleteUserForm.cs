using UserCreator.Backend.UserManagement;

namespace UserCreator.Frontend.PrimaryFrames
{
    public partial class DeleteUserForm : Form
    {
        public DeleteUserForm()
        {
            InitializeComponent();
        }

        private async void DeleteUserForm_Load(object sender, EventArgs e)
        {
            ActiveControl = DeleteButton;

            WinUsersManagement localUserAccounts = new();
            await Task.Run(localUserAccounts.GetLocalWindowsUsers);
            foreach (string userAccount in localUserAccounts.LocalUsers)
            {
                DeleteUserComboBox.Items.Add(userAccount);
            }
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
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

            DialogResult messageBoxResult = MessageBox.Show($"Are you sure you want to delete this account? : {DeleteUserComboBox.Text.Trim()}", "Delete Account Prompt", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            switch (messageBoxResult)
            {
                case DialogResult.Yes:
                    await Task.Run(deleteUserManagement.DeleteUser);
                    break;
                case DialogResult.No:
                    break;
                case DialogResult.Cancel:
                    break;
            }

            DeleteUserComboBox.Text = string.Empty;
        }

        private async void DeleteUserComboBox_DropDown(object sender, EventArgs e)
        {
            DeleteUserComboBox.Items.Clear();

            WinUsersManagement localUserAccounts = new();
            await Task.Run(localUserAccounts.GetLocalWindowsUsers);

            foreach (string userAccount in localUserAccounts.LocalUsers)
            {
                DeleteUserComboBox.Items.Add(userAccount);
            }
        }
    }
}