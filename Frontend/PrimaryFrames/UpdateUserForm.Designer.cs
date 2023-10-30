namespace UserCreator.Frontend.PrimaryFrames
{
    partial class UpdateUserForm
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
            UpdateButton = new Button();
            UsersCombobox = new ComboBox();
            UpdatePassCheckbox = new CheckBox();
            UpdatePassTextbox = new TextBox();
            UpdateDescCheckbox = new CheckBox();
            UpdateDescTextbox = new TextBox();
            UpdateAcctExpCheckbox = new CheckBox();
            UpdateDateTimePicker = new DateTimePicker();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // UpdateButton
            // 
            UpdateButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            UpdateButton.Location = new Point(308, 576);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(196, 43);
            UpdateButton.TabIndex = 0;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // UsersCombobox
            // 
            UsersCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            UsersCombobox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UsersCombobox.FormattingEnabled = true;
            UsersCombobox.Location = new Point(71, 39);
            UsersCombobox.Name = "UsersCombobox";
            UsersCombobox.Size = new Size(650, 29);
            UsersCombobox.TabIndex = 1;
            // 
            // UpdatePassCheckbox
            // 
            UpdatePassCheckbox.AutoSize = true;
            UpdatePassCheckbox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UpdatePassCheckbox.Location = new Point(59, 38);
            UpdatePassCheckbox.Name = "UpdatePassCheckbox";
            UpdatePassCheckbox.Size = new Size(166, 25);
            UpdatePassCheckbox.TabIndex = 2;
            UpdatePassCheckbox.Text = "Update Password";
            UpdatePassCheckbox.UseVisualStyleBackColor = true;
            UpdatePassCheckbox.CheckedChanged += UpdatePassCheckbox_CheckedChanged;
            // 
            // UpdatePassTextbox
            // 
            UpdatePassTextbox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UpdatePassTextbox.Location = new Point(277, 38);
            UpdatePassTextbox.Name = "UpdatePassTextbox";
            UpdatePassTextbox.PasswordChar = '^';
            UpdatePassTextbox.PlaceholderText = "New Password";
            UpdatePassTextbox.Size = new Size(432, 27);
            UpdatePassTextbox.TabIndex = 3;
            // 
            // UpdateDescCheckbox
            // 
            UpdateDescCheckbox.AutoSize = true;
            UpdateDescCheckbox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateDescCheckbox.Location = new Point(59, 80);
            UpdateDescCheckbox.Name = "UpdateDescCheckbox";
            UpdateDescCheckbox.Size = new Size(181, 25);
            UpdateDescCheckbox.TabIndex = 4;
            UpdateDescCheckbox.Text = "Update Description";
            UpdateDescCheckbox.UseVisualStyleBackColor = true;
            UpdateDescCheckbox.CheckedChanged += UpdateDescCheckbox_CheckedChanged;
            // 
            // UpdateDescTextbox
            // 
            UpdateDescTextbox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateDescTextbox.Location = new Point(277, 83);
            UpdateDescTextbox.Multiline = true;
            UpdateDescTextbox.Name = "UpdateDescTextbox";
            UpdateDescTextbox.PlaceholderText = "Description";
            UpdateDescTextbox.Size = new Size(432, 237);
            UpdateDescTextbox.TabIndex = 5;
            // 
            // UpdateAcctExpCheckbox
            // 
            UpdateAcctExpCheckbox.AutoSize = true;
            UpdateAcctExpCheckbox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateAcctExpCheckbox.Location = new Point(59, 352);
            UpdateAcctExpCheckbox.Name = "UpdateAcctExpCheckbox";
            UpdateAcctExpCheckbox.Size = new Size(289, 25);
            UpdateAcctExpCheckbox.TabIndex = 6;
            UpdateAcctExpCheckbox.Text = "Update Account Expiration Date";
            UpdateAcctExpCheckbox.UseVisualStyleBackColor = true;
            UpdateAcctExpCheckbox.CheckedChanged += UpdateAcctExpCheckbox_CheckedChanged;
            // 
            // UpdateDateTimePicker
            // 
            UpdateDateTimePicker.CalendarFont = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateDateTimePicker.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            UpdateDateTimePicker.Location = new Point(394, 348);
            UpdateDateTimePicker.Name = "UpdateDateTimePicker";
            UpdateDateTimePicker.Size = new Size(315, 27);
            UpdateDateTimePicker.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(UpdatePassTextbox);
            groupBox1.Controls.Add(UpdateDateTimePicker);
            groupBox1.Controls.Add(UpdateAcctExpCheckbox);
            groupBox1.Controls.Add(UpdatePassCheckbox);
            groupBox1.Controls.Add(UpdateDescTextbox);
            groupBox1.Controls.Add(UpdateDescCheckbox);
            groupBox1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 137);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 407);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Properties";
            // 
            // UpdateUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 648);
            Controls.Add(groupBox1);
            Controls.Add(UsersCombobox);
            Controls.Add(UpdateButton);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UpdateUserForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update Local User";
            Load += UpdateUserForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button UpdateButton;
        private ComboBox UsersCombobox;
        private CheckBox UpdatePassCheckbox;
        private TextBox UpdatePassTextbox;
        private CheckBox UpdateDescCheckbox;
        private TextBox UpdateDescTextbox;
        private CheckBox UpdateAcctExpCheckbox;
        private DateTimePicker UpdateDateTimePicker;
        private GroupBox groupBox1;
    }
}