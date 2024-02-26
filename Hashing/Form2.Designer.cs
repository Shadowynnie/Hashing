namespace Hashing
{
    partial class Form2
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
            this.userList = new System.Windows.Forms.ListBox();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.SaveXmlBtn = new System.Windows.Forms.Button();
            this.NewPassConfirmBtn = new System.Windows.Forms.Button();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.StatusPanel = new System.Windows.Forms.Panel();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.StatusPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // userList
            // 
            this.userList.FormattingEnabled = true;
            this.userList.ItemHeight = 16;
            this.userList.Location = new System.Drawing.Point(12, 82);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(766, 356);
            this.userList.TabIndex = 0;
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Location = new System.Drawing.Point(369, 25);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(196, 40);
            this.changePasswordButton.TabIndex = 1;
            this.changePasswordButton.Text = "Change password";
            this.changePasswordButton.UseVisualStyleBackColor = true;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // SaveXmlBtn
            // 
            this.SaveXmlBtn.Location = new System.Drawing.Point(582, 25);
            this.SaveXmlBtn.Name = "SaveXmlBtn";
            this.SaveXmlBtn.Size = new System.Drawing.Size(196, 40);
            this.SaveXmlBtn.TabIndex = 2;
            this.SaveXmlBtn.Text = "Save XML";
            this.SaveXmlBtn.UseVisualStyleBackColor = true;
            this.SaveXmlBtn.Click += new System.EventHandler(this.SaveXmlBtn_Click);
            // 
            // NewPassConfirmBtn
            // 
            this.NewPassConfirmBtn.Enabled = false;
            this.NewPassConfirmBtn.Location = new System.Drawing.Point(703, 451);
            this.NewPassConfirmBtn.Name = "NewPassConfirmBtn";
            this.NewPassConfirmBtn.Size = new System.Drawing.Size(75, 23);
            this.NewPassConfirmBtn.TabIndex = 3;
            this.NewPassConfirmBtn.Text = "Confirm";
            this.NewPassConfirmBtn.UseVisualStyleBackColor = true;
            this.NewPassConfirmBtn.Click += new System.EventHandler(this.NewPassConfirmBtn_Click);
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Enabled = false;
            this.newPasswordTextBox.Location = new System.Drawing.Point(520, 452);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.Size = new System.Drawing.Size(162, 22);
            this.newPasswordTextBox.TabIndex = 4;
            // 
            // StatusPanel
            // 
            this.StatusPanel.BackColor = System.Drawing.SystemColors.Info;
            this.StatusPanel.Controls.Add(this.StatusLabel);
            this.StatusPanel.Location = new System.Drawing.Point(12, 444);
            this.StatusPanel.Name = "StatusPanel";
            this.StatusPanel.Size = new System.Drawing.Size(355, 40);
            this.StatusPanel.TabIndex = 5;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(15, 14);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(47, 16);
            this.StatusLabel.TabIndex = 0;
            this.StatusLabel.Text = "Status:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.StatusPanel);
            this.Controls.Add(this.newPasswordTextBox);
            this.Controls.Add(this.NewPassConfirmBtn);
            this.Controls.Add(this.SaveXmlBtn);
            this.Controls.Add(this.changePasswordButton);
            this.Controls.Add(this.userList);
            this.Name = "Form2";
            this.Text = "Accounts";
            this.StatusPanel.ResumeLayout(false);
            this.StatusPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox userList;
        private System.Windows.Forms.Button changePasswordButton;
        private System.Windows.Forms.Button SaveXmlBtn;
        private System.Windows.Forms.Button NewPassConfirmBtn;
        private System.Windows.Forms.TextBox newPasswordTextBox;
        private System.Windows.Forms.Panel StatusPanel;
        private System.Windows.Forms.Label StatusLabel;
    }
}