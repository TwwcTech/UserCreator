﻿namespace UserCreator.Frontend.PrimaryFrames
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
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

        }
    }
}