using UserCreator.Backend.UserManagement;
using UserCreator.Backend.Validator;

namespace UserCreator.Frontend.PrimaryFrames
{
    public partial class UpdateUserForm : Form
    {
        public UpdateUserForm()
        {
            InitializeComponent();
        }

        private async void UpdateUserForm_Load(object sender, EventArgs e)
        {
            ActiveControl = UpdateButton;

            WinUsersManagement localUserAccounts = new();
            await Task.Run(localUserAccounts.GetLocalWindowsUsers);
            foreach (string userAccount in localUserAccounts.LocalUsers)
            {
                UsersCombobox.Items.Add(userAccount);
            }

            UpdatePassTextbox.Enabled = false;
            UpdateDescTextbox.Enabled = false;
            UpdateDateTimePicker.Enabled = false;
            UpdateDateTimePicker.Value = DateTime.Today.AddDays(1);
        }

        private async void UpdateButton_Click(object sender, EventArgs e)
        {
            WinUsersManagement updateAccountManager = new();

            if (string.IsNullOrWhiteSpace(UsersCombobox.Text))
            {
                MessageBox.Show("Must select a user to update", "User Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!UpdatePassCheckbox.Checked && !UpdateDescCheckbox.Checked && !UpdateAcctExpCheckbox.Checked)
            {
                MessageBox.Show("No items were selected to be updated", "Update Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (UpdatePassCheckbox.Checked)
            {
                TextBox[] passwordTextbox = { UpdatePassTextbox };
                if (!InputValidator.AreTextboxesEmpty(passwordTextbox))
                {
                    if (InputValidator.IsPasswordSecure(UpdatePassTextbox.Text.Trim()))
                    {
                        updateAccountManager.Username = UsersCombobox.Text.Trim();
                        updateAccountManager.Password = UpdatePassTextbox.Text;
                        await Task.Run(updateAccountManager.UpdatePassword);
                    }
                    else
                    {
                        MessageBox.Show("Password must contain a number, a symbol, and must be at least 8 characters in length", "Password Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Update Password Entry must not be empty", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (UpdateDescCheckbox.Checked)
            {
                updateAccountManager.Username = UsersCombobox.Text.Trim();
                updateAccountManager.Description = UpdateDescTextbox.Text.Trim();
                await Task.Run(updateAccountManager.UpdateDescription);
            }

            if (UpdateAcctExpCheckbox.Checked)
            {
                updateAccountManager.Username = UsersCombobox.Text.Trim();
                updateAccountManager.AccountExpirationLength = UpdateDateTimePicker.Value;
                await Task.Run(updateAccountManager.UpdateAccountExpireDate);
            }

            UsersCombobox.Text = string.Empty;
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

        private void UpdateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (UpdateDateTimePicker.Value <= DateTime.Today)
            {
                MessageBox.Show("Account expire date must be at least one day ahead of the current date", "Account Expire Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UpdateDateTimePicker.Value = DateTime.Today.AddDays(1);
            }
        }

        private async void UsersCombobox_DropDown(object sender, EventArgs e)
        {
            UsersCombobox.Items.Clear();

            WinUsersManagement localUserAccounts = new();
            await Task.Run(localUserAccounts.GetLocalWindowsUsers);
            foreach (string userAccount in localUserAccounts.LocalUsers)
            {
                UsersCombobox.Items.Add(userAccount);
            }
        }
    }
}