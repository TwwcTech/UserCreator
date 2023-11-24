using UserCreator.Frontend.PrimaryFrames;

namespace UserCreator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ActiveControl = CreateUserButton;
            AcceptButton = CreateUserButton;
        }

        private void CreateUserButton_Click(object sender, EventArgs e)
        {
            Hide();
            Form createUserForm = new CreateUserForm();
            createUserForm.ShowDialog();
            if (!createUserForm.Visible)
            {
                Show();
            }
        }

        private void UpdateUserButton_Click(object sender, EventArgs e)
        {
            Hide();
            Form updateUserForm = new UpdateUserForm();
            updateUserForm.ShowDialog();
            if (!updateUserForm.Visible)
            {
                Show();
            }
        }

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            Hide();
            Form deleteUserForm = new DeleteUserForm();
            deleteUserForm.ShowDialog();
            if (!deleteUserForm.Visible)
            {
                Show();
            }
        }
    }
}