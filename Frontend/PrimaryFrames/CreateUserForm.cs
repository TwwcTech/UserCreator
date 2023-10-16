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

        }
    }
}
