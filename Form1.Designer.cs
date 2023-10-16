namespace UserCreator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CreateUserButton = new Button();
            UpdateUserButton = new Button();
            DeleteUserButton = new Button();
            SuspendLayout();
            // 
            // CreateUserButton
            // 
            CreateUserButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CreateUserButton.Location = new Point(147, 198);
            CreateUserButton.Name = "CreateUserButton";
            CreateUserButton.Size = new Size(134, 49);
            CreateUserButton.TabIndex = 0;
            CreateUserButton.Text = "Create User";
            CreateUserButton.UseVisualStyleBackColor = true;
            // 
            // UpdateUserButton
            // 
            UpdateUserButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            UpdateUserButton.Location = new Point(331, 198);
            UpdateUserButton.Name = "UpdateUserButton";
            UpdateUserButton.Size = new Size(134, 49);
            UpdateUserButton.TabIndex = 1;
            UpdateUserButton.Text = "Update User";
            UpdateUserButton.UseVisualStyleBackColor = true;
            // 
            // DeleteUserButton
            // 
            DeleteUserButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteUserButton.Location = new Point(513, 198);
            DeleteUserButton.Name = "DeleteUserButton";
            DeleteUserButton.Size = new Size(134, 49);
            DeleteUserButton.TabIndex = 2;
            DeleteUserButton.Text = "Delete User";
            DeleteUserButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DeleteUserButton);
            Controls.Add(UpdateUserButton);
            Controls.Add(CreateUserButton);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Creator Console";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button CreateUserButton;
        private Button UpdateUserButton;
        private Button DeleteUserButton;
    }
}