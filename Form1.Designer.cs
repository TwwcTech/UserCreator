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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            CreateUserButton = new Button();
            UpdateUserButton = new Button();
            DeleteUserButton = new Button();
            ConsoleButtonsPanel = new Panel();
            localUserConsoleTooltip = new ToolTip(components);
            ConsoleButtonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // CreateUserButton
            // 
            CreateUserButton.Dock = DockStyle.Left;
            CreateUserButton.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            CreateUserButton.Image = Resource1.add_user;
            CreateUserButton.Location = new Point(0, 0);
            CreateUserButton.Name = "CreateUserButton";
            CreateUserButton.Size = new Size(275, 267);
            CreateUserButton.TabIndex = 0;
            CreateUserButton.TextAlign = ContentAlignment.BottomCenter;
            CreateUserButton.UseVisualStyleBackColor = true;
            CreateUserButton.Click += CreateUserButton_Click;
            // 
            // UpdateUserButton
            // 
            UpdateUserButton.Dock = DockStyle.Left;
            UpdateUserButton.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            UpdateUserButton.Image = Resource1.edit;
            UpdateUserButton.Location = new Point(275, 0);
            UpdateUserButton.Name = "UpdateUserButton";
            UpdateUserButton.Size = new Size(275, 267);
            UpdateUserButton.TabIndex = 1;
            UpdateUserButton.TextAlign = ContentAlignment.BottomCenter;
            UpdateUserButton.UseVisualStyleBackColor = true;
            UpdateUserButton.Click += UpdateUserButton_Click;
            // 
            // DeleteUserButton
            // 
            DeleteUserButton.Dock = DockStyle.Right;
            DeleteUserButton.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteUserButton.Image = Resource1.remove_user;
            DeleteUserButton.Location = new Point(550, 0);
            DeleteUserButton.Name = "DeleteUserButton";
            DeleteUserButton.Size = new Size(275, 267);
            DeleteUserButton.TabIndex = 2;
            DeleteUserButton.TextAlign = ContentAlignment.BottomCenter;
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
            ConsoleButtonsPanel.Size = new Size(825, 267);
            ConsoleButtonsPanel.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 267);
            Controls.Add(ConsoleButtonsPanel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Local User Console";
            Load += MainForm_Load;
            ConsoleButtonsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button CreateUserButton;
        private Button UpdateUserButton;
        private Button DeleteUserButton;
        private Panel ConsoleButtonsPanel;
        private ToolTip localUserConsoleTooltip;
    }
}