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

            WinUsersManagement localUserManagement = new WinUsersManagement();
            localUserManagement.GetLocalWindowsUsers();

            foreach (string user in localUserManagement.LocalUsers)
            {
                UsersCombobox.Items.Add(user);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

        }
    }
}