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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateUserForm));
            NewUsernameTextbox = new TextBox();
            NewPasswordTextbox = new TextBox();
            AdminCheckbox = new CheckBox();
            CreateButton = new Button();
            DescriptionTextbox = new TextBox();
            OptionsControlPanel = new GroupBox();
            DayMonthPicker = new DateTimePicker();
            AccountExpirationCheckbox = new CheckBox();
            OptionsControlPanel.SuspendLayout();
            SuspendLayout();
            // 
            // NewUsernameTextbox
            // 
            NewUsernameTextbox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NewUsernameTextbox.Location = new Point(26, 73);
            NewUsernameTextbox.Margin = new Padding(4, 5, 4, 5);
            NewUsernameTextbox.Name = "NewUsernameTextbox";
            NewUsernameTextbox.PlaceholderText = "Enter New User Name";
            NewUsernameTextbox.Size = new Size(845, 37);
            NewUsernameTextbox.TabIndex = 0;
            // 
            // NewPasswordTextbox
            // 
            NewPasswordTextbox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NewPasswordTextbox.Location = new Point(26, 180);
            NewPasswordTextbox.Margin = new Padding(4, 5, 4, 5);
            NewPasswordTextbox.Name = "NewPasswordTextbox";
            NewPasswordTextbox.PasswordChar = '*';
            NewPasswordTextbox.PlaceholderText = "Enter New Password";
            NewPasswordTextbox.Size = new Size(845, 37);
            NewPasswordTextbox.TabIndex = 1;
            // 
            // AdminCheckbox
            // 
            AdminCheckbox.AutoSize = true;
            AdminCheckbox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AdminCheckbox.Location = new Point(337, 280);
            AdminCheckbox.Margin = new Padding(4, 5, 4, 5);
            AdminCheckbox.Name = "AdminCheckbox";
            AdminCheckbox.Size = new Size(206, 34);
            AdminCheckbox.TabIndex = 2;
            AdminCheckbox.Text = "Enable Admin";
            AdminCheckbox.UseVisualStyleBackColor = true;
            // 
            // CreateButton
            // 
            CreateButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CreateButton.Location = new Point(313, 892);
            CreateButton.Margin = new Padding(4, 5, 4, 5);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(280, 72);
            CreateButton.TabIndex = 3;
            CreateButton.Text = "Create User";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateButton_Click;
            // 
            // DescriptionTextbox
            // 
            DescriptionTextbox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DescriptionTextbox.Location = new Point(9, 43);
            DescriptionTextbox.Margin = new Padding(4, 5, 4, 5);
            DescriptionTextbox.Multiline = true;
            DescriptionTextbox.Name = "DescriptionTextbox";
            DescriptionTextbox.PlaceholderText = "Description";
            DescriptionTextbox.Size = new Size(845, 267);
            DescriptionTextbox.TabIndex = 4;
            // 
            // OptionsControlPanel
            // 
            OptionsControlPanel.Controls.Add(DayMonthPicker);
            OptionsControlPanel.Controls.Add(AccountExpirationCheckbox);
            OptionsControlPanel.Controls.Add(DescriptionTextbox);
            OptionsControlPanel.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            OptionsControlPanel.Location = new Point(17, 358);
            OptionsControlPanel.Margin = new Padding(4, 5, 4, 5);
            OptionsControlPanel.Name = "OptionsControlPanel";
            OptionsControlPanel.Padding = new Padding(4, 5, 4, 5);
            OptionsControlPanel.Size = new Size(864, 463);
            OptionsControlPanel.TabIndex = 5;
            OptionsControlPanel.TabStop = false;
            OptionsControlPanel.Text = "OPTIONAL";
            // 
            // DayMonthPicker
            // 
            DayMonthPicker.CalendarFont = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DayMonthPicker.Location = new Point(410, 362);
            DayMonthPicker.Margin = new Padding(4, 5, 4, 5);
            DayMonthPicker.Name = "DayMonthPicker";
            DayMonthPicker.Size = new Size(444, 37);
            DayMonthPicker.TabIndex = 8;
            DayMonthPicker.ValueChanged += DayMonthPicker_ValueChanged;
            // 
            // AccountExpirationCheckbox
            // 
            AccountExpirationCheckbox.AutoSize = true;
            AccountExpirationCheckbox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AccountExpirationCheckbox.Location = new Point(9, 368);
            AccountExpirationCheckbox.Margin = new Padding(4, 5, 4, 5);
            AccountExpirationCheckbox.Name = "AccountExpirationCheckbox";
            AccountExpirationCheckbox.Size = new Size(264, 34);
            AccountExpirationCheckbox.TabIndex = 6;
            AccountExpirationCheckbox.Text = "Account Expiration";
            AccountExpirationCheckbox.UseVisualStyleBackColor = true;
            AccountExpirationCheckbox.CheckedChanged += AccountExpirationCheckbox_CheckedChanged;
            // 
            // CreateUserForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 1023);
            Controls.Add(OptionsControlPanel);
            Controls.Add(AdminCheckbox);
            Controls.Add(CreateButton);
            Controls.Add(NewPasswordTextbox);
            Controls.Add(NewUsernameTextbox);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreateUserForm";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Local User";
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
        private CheckBox AccountExpirationCheckbox;
        private DateTimePicker DayMonthPicker;
    }
}