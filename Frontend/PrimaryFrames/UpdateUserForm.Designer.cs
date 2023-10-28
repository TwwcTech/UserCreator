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
            SuspendLayout();
            // 
            // UpdateButton
            // 
            UpdateButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            UpdateButton.Location = new Point(308, 502);
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
            UsersCombobox.Location = new Point(170, 106);
            UsersCombobox.Name = "UsersCombobox";
            UsersCombobox.Size = new Size(443, 29);
            UsersCombobox.TabIndex = 1;
            // 
            // UpdateUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 588);
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
            ResumeLayout(false);
        }

        #endregion

        private Button UpdateButton;
        private ComboBox UsersCombobox;
    }
}