namespace Eclipse_Cofee_shop
{
    partial class FormForgotPassword
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
            this.textBoxForgotUsername = new System.Windows.Forms.TextBox();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.buttonResetPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxForgotUsername
            // 
            this.textBoxForgotUsername.Location = new System.Drawing.Point(342, 153);
            this.textBoxForgotUsername.Multiline = true;
            this.textBoxForgotUsername.Name = "textBoxForgotUsername";
            this.textBoxForgotUsername.Size = new System.Drawing.Size(186, 38);
            this.textBoxForgotUsername.TabIndex = 0;
            this.textBoxForgotUsername.Text = "Username";
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Location = new System.Drawing.Point(342, 233);
            this.textBoxNewPassword.Multiline = true;
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.Size = new System.Drawing.Size(186, 38);
            this.textBoxNewPassword.TabIndex = 1;
            this.textBoxNewPassword.Text = "New Password";
            // 
            // buttonResetPassword
            // 
            this.buttonResetPassword.Location = new System.Drawing.Point(366, 346);
            this.buttonResetPassword.Name = "buttonResetPassword";
            this.buttonResetPassword.Size = new System.Drawing.Size(122, 67);
            this.buttonResetPassword.TabIndex = 2;
            this.buttonResetPassword.Text = "Reset Password";
            this.buttonResetPassword.UseVisualStyleBackColor = true;
            // 
            // FormForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 559);
            this.Controls.Add(this.buttonResetPassword);
            this.Controls.Add(this.textBoxNewPassword);
            this.Controls.Add(this.textBoxForgotUsername);
            this.Name = "FormForgotPassword";
            this.Text = "FormForgotPassword";
            this.Load += new System.EventHandler(this.FormForgotPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxForgotUsername;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.Button buttonResetPassword;
    }
}