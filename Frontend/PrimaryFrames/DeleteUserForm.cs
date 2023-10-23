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
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }
    }
}