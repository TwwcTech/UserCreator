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
            DescriptionTextbox = new TextBox();
            OptionsControlPanel = new GroupBox();
            OptionsControlPanel.SuspendLayout();
            SuspendLayout();
            // 
            // NewUsernameTextbox
            // 
            NewUsernameTextbox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NewUsernameTextbox.Location = new Point(207, 51);
            NewUsernameTextbox.Name = "NewUsernameTextbox";
            NewUsernameTextbox.PlaceholderText = "Enter New User Name";
            NewUsernameTextbox.Size = new Size(376, 27);
            NewUsernameTextbox.TabIndex = 0;
            // 
            // NewPasswordTextbox
            // 
            NewPasswordTextbox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NewPasswordTextbox.Location = new Point(207, 115);
            NewPasswordTextbox.Name = "NewPasswordTextbox";
            NewPasswordTextbox.PasswordChar = '*';
            NewPasswordTextbox.PlaceholderText = "Enter New Password";
            NewPasswordTextbox.Size = new Size(376, 27);
            NewPasswordTextbox.TabIndex = 1;
            // 
            // AdminCheckbox
            // 
            AdminCheckbox.AutoSize = true;
            AdminCheckbox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AdminCheckbox.Location = new Point(511, 28);
            AdminCheckbox.Name = "AdminCheckbox";
            AdminCheckbox.Size = new Size(139, 25);
            AdminCheckbox.TabIndex = 2;
            AdminCheckbox.Text = "Enable Admin";
            AdminCheckbox.UseVisualStyleBackColor = true;
            // 
            // CreateButton
            // 
            CreateButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CreateButton.Location = new Point(298, 685);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(196, 43);
            CreateButton.TabIndex = 3;
            CreateButton.Text = "Create User";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateButton_Click;
            // 
            // DescriptionTextbox
            // 
            DescriptionTextbox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DescriptionTextbox.Location = new Point(16, 26);
            DescriptionTextbox.Multiline = true;
            DescriptionTextbox.Name = "DescriptionTextbox";
            DescriptionTextbox.PlaceholderText = "Description (Optional)";
            DescriptionTextbox.Size = new Size(376, 380);
            DescriptionTextbox.TabIndex = 4;
            // 
            // OptionsControlPanel
            // 
            OptionsControlPanel.Controls.Add(DescriptionTextbox);
            OptionsControlPanel.Controls.Add(AdminCheckbox);
            OptionsControlPanel.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            OptionsControlPanel.Location = new Point(12, 200);
            OptionsControlPanel.Name = "OptionsControlPanel";
            OptionsControlPanel.Size = new Size(776, 425);
            OptionsControlPanel.TabIndex = 5;
            OptionsControlPanel.TabStop = false;
            OptionsControlPanel.Text = "OPTIONAL";
            // 
            // CreateUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 768);
            Controls.Add(OptionsControlPanel);
            Controls.Add(CreateButton);
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
            OptionsControlPanel.ResumeLayout(false);
            OptionsControlPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NewUsernameTextbox;
        private TextBox NewPasswordTextbox;
        private CheckBox AdminCheckbox;
        private Button CreateButton;
        private TextBox DescriptionTextbox;
        private GroupBox OptionsControlPanel;
    }
}