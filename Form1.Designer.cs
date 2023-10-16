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
            ConsoleButtonsPanel = new Panel();
            ConsoleButtonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // CreateUserButton
            // 
            CreateUserButton.Dock = DockStyle.Left;
            CreateUserButton.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            CreateUserButton.Location = new Point(0, 0);
            CreateUserButton.Name = "CreateUserButton";
            CreateUserButton.Size = new Size(275, 450);
            CreateUserButton.TabIndex = 0;
            CreateUserButton.Text = "Create User";
            CreateUserButton.UseVisualStyleBackColor = true;
            CreateUserButton.Click += CreateUserButton_Click;
            // 
            // UpdateUserButton
            // 
            UpdateUserButton.Dock = DockStyle.Left;
            UpdateUserButton.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            UpdateUserButton.Location = new Point(275, 0);
            UpdateUserButton.Name = "UpdateUserButton";
            UpdateUserButton.Size = new Size(275, 450);
            UpdateUserButton.TabIndex = 1;
            UpdateUserButton.Text = "Update User";
            UpdateUserButton.UseVisualStyleBackColor = true;
            UpdateUserButton.Click += UpdateUserButton_Click;
            // 
            // DeleteUserButton
            // 
            DeleteUserButton.Dock = DockStyle.Right;
            DeleteUserButton.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteUserButton.Location = new Point(550, 0);
            DeleteUserButton.Name = "DeleteUserButton";
            DeleteUserButton.Size = new Size(275, 450);
            DeleteUserButton.TabIndex = 2;
            DeleteUserButton.Text = "Delete User";
            DeleteUserButton.UseVisualStyleBackColor = true;
            DeleteUserButton.Click += DeleteUserButton_Click;
            // 
            // ConsoleButtonsPanel
            // 
            ConsoleButtonsPanel.Controls.Add(UpdateUserButton);
            ConsoleButtonsPanel.Controls.Add(DeleteUserButton);
            ConsoleButtonsPanel.Controls.Add(CreateUserButton);
            ConsoleButtonsPanel.Dock = DockStyle.Fill;
            ConsoleButtonsPanel.Location = new Point(0, 0);
            ConsoleButtonsPanel.Name = "ConsoleButtonsPanel";
            ConsoleButtonsPanel.Size = new Size(825, 450);
            ConsoleButtonsPanel.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 450);
            Controls.Add(ConsoleButtonsPanel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "MainForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Creator Console";
            Load += MainForm_Load;
            ConsoleButtonsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button CreateUserButton;
        private Button UpdateUserButton;
        private Button DeleteUserButton;
        private Panel ConsoleButtonsPanel;
    }
}