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

            UpdatePassTextbox.Enabled = false;
            UpdateDescTextbox.Enabled = false;
            UpdateDateTimePicker.Enabled = false;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

        }

        private void UpdatePassCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePassTextbox.Enabled = UpdatePassCheckbox.Checked;
        }

        private void UpdateDescCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDescTextbox.Enabled = UpdateDescCheckbox.Checked;
        }

        private void UpdateAcctExpCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDateTimePicker.Enabled = UpdateAcctExpCheckbox.Checked;
        }
    }
}