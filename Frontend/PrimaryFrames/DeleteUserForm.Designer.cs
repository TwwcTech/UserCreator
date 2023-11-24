namespace UserCreator.Frontend.PrimaryFrames
{
    partial class DeleteUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteUserForm));
            DeleteButton = new Button();
            DeleteUserComboBox = new ComboBox();
            SuspendLayout();
            // 
            // DeleteButton
            // 
            DeleteButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteButton.Location = new Point(216, 235);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(196, 43);
            DeleteButton.TabIndex = 0;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // DeleteUserComboBox
            // 
            DeleteUserComboBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteUserComboBox.FormattingEnabled = true;
            DeleteUserComboBox.Location = new Point(74, 37);
            DeleteUserComboBox.Name = "DeleteUserComboBox";
            DeleteUserComboBox.Size = new Size(503, 29);
            DeleteUserComboBox.TabIndex = 1;
            DeleteUserComboBox.DropDown += DeleteUserComboBox_DropDown;
            // 
            // DeleteUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 304);
            Controls.Add(DeleteUserComboBox);
            Controls.Add(DeleteButton);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DeleteUserForm";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Delete Local User";
            Load += DeleteUserForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button DeleteButton;
        private ComboBox DeleteUserComboBox;
    }
}