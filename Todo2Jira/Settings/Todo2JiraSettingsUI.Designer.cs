namespace Todo2Jira.Settings
{
    partial class Todo2JiraSettingsUI
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtJiraBaseUrl = new System.Windows.Forms.TextBox();
            this.txtProjectKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtJiraUsername = new System.Windows.Forms.TextBox();
            this.txtJiraPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jira base url";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Project KEY";
            // 
            // txtJiraBaseUrl
            // 
            this.txtJiraBaseUrl.Location = new System.Drawing.Point(92, 9);
            this.txtJiraBaseUrl.Name = "txtJiraBaseUrl";
            this.txtJiraBaseUrl.Size = new System.Drawing.Size(320, 20);
            this.txtJiraBaseUrl.TabIndex = 2;
            this.txtJiraBaseUrl.Text = "https://jira.example.com";
            // 
            // txtProjectKey
            // 
            this.txtProjectKey.Location = new System.Drawing.Point(92, 35);
            this.txtProjectKey.Name = "txtProjectKey";
            this.txtProjectKey.Size = new System.Drawing.Size(320, 20);
            this.txtProjectKey.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Jira username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Jira password";
            // 
            // txtJiraUsername
            // 
            this.txtJiraUsername.Location = new System.Drawing.Point(92, 61);
            this.txtJiraUsername.Name = "txtJiraUsername";
            this.txtJiraUsername.Size = new System.Drawing.Size(320, 20);
            this.txtJiraUsername.TabIndex = 6;
            // 
            // txtJiraPassword
            // 
            this.txtJiraPassword.Location = new System.Drawing.Point(92, 87);
            this.txtJiraPassword.Name = "txtJiraPassword";
            this.txtJiraPassword.Size = new System.Drawing.Size(320, 20);
            this.txtJiraPassword.TabIndex = 7;
            this.txtJiraPassword.UseSystemPasswordChar = true;
            // 
            // Todo2JiraSettingsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtJiraPassword);
            this.Controls.Add(this.txtJiraBaseUrl);
            this.Controls.Add(this.txtProjectKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtJiraUsername);
            this.Controls.Add(this.label4);
            this.Name = "Todo2JiraSettingsUI";
            this.Size = new System.Drawing.Size(474, 197);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtJiraBaseUrl;
        public System.Windows.Forms.TextBox txtProjectKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtJiraUsername;
        public System.Windows.Forms.TextBox txtJiraPassword;
    }
}
