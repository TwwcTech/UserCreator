namespace UserCreator.Frontend.PrimaryFrames
{
    partial class CreateUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NewUsernameTextbox = new TextBox();
            NewPasswordTextbox = new TextBox();
            AdminCheckbox = new CheckBox();
            CreateButton = new Button();
            SuspendLayout();
            // 
            // NewUsernameTextbox
            // 
            NewUsernameTextbox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NewUsernameTextbox.Location = new Point(207, 66);
            NewUsernameTextbox.Name = "NewUsernameTextbox";
            NewUsernameTextbox.PlaceholderText = "Enter New User Name";
            NewUsernameTextbox.Size = new Size(376, 27);
            NewUsernameTextbox.TabIndex = 0;
            // 
            // NewPasswordTextbox
            // 
            NewPasswordTextbox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NewPasswordTextbox.Location = new Point(207, 130);
            NewPasswordTextbox.Name = "NewPasswordTextbox";
            NewPasswordTextbox.PlaceholderText = "Enter New Password";
            NewPasswordTextbox.Size = new Size(376, 27);
            NewPasswordTextbox.TabIndex = 1;
            // 
            // AdminCheckbox
            // 
            AdminCheckbox.AutoSize = true;
            AdminCheckbox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AdminCheckbox.Location = new Point(322, 209);
            AdminCheckbox.Name = "AdminCheckbox";
            AdminCheckbox.Size = new Size(139, 25);
            AdminCheckbox.TabIndex = 2;
            AdminCheckbox.Text = "Enable Admin";
            AdminCheckbox.UseVisualStyleBackColor = true;
            // 
            // CreateButton
            // 
            CreateButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CreateButton.Location = new Point(301, 355);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(196, 43);
            CreateButton.TabIndex = 3;
            CreateButton.Text = "Create";
            CreateButton.UseVisualStyleBackColor = true;
            // 
            // CreateUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CreateButton);
            Controls.Add(AdminCheckbox);
            Controls.Add(NewPasswordTextbox);
            Controls.Add(NewUsernameTextbox);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreateUserForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create User";
            Load += CreateUserForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NewUsernameTextbox;
        private TextBox NewPasswordTextbox;
        private CheckBox AdminCheckbox;
        private Button CreateButton;
    }
}