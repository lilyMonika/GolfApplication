namespace GolfApp
{
    partial class frmRegister
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnSaveUser = new System.Windows.Forms.Button();
            this.btnBackToLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassConfirmation = new System.Windows.Forms.TextBox();
            this.lblPassCharacter = new System.Windows.Forms.Label();
            this.txtPassNotMatched = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(117, 25);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(117, 51);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.Location = new System.Drawing.Point(104, 225);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.Size = new System.Drawing.Size(75, 23);
            this.btnSaveUser.TabIndex = 4;
            this.btnSaveUser.Text = "Save User";
            this.btnSaveUser.UseVisualStyleBackColor = true;
            this.btnSaveUser.Click += new System.EventHandler(this.btnSaveUser_Click);
            // 
            // btnBackToLogin
            // 
            this.btnBackToLogin.Location = new System.Drawing.Point(89, 254);
            this.btnBackToLogin.Name = "btnBackToLogin";
            this.btnBackToLogin.Size = new System.Drawing.Size(108, 33);
            this.btnBackToLogin.TabIndex = 6;
            this.btnBackToLogin.Text = "Back to Login";
            this.btnBackToLogin.UseVisualStyleBackColor = true;
            this.btnBackToLogin.Click += new System.EventHandler(this.btnBackToLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Confirm Password";
            // 
            // txtPassConfirmation
            // 
            this.txtPassConfirmation.Location = new System.Drawing.Point(117, 77);
            this.txtPassConfirmation.Name = "txtPassConfirmation";
            this.txtPassConfirmation.PasswordChar = '*';
            this.txtPassConfirmation.Size = new System.Drawing.Size(100, 20);
            this.txtPassConfirmation.TabIndex = 8;
            this.txtPassConfirmation.TextChanged += new System.EventHandler(this.txtPassConfirmation_TextChanged);
            // 
            // lblPassCharacter
            // 
            this.lblPassCharacter.AutoSize = true;
            this.lblPassCharacter.ForeColor = System.Drawing.Color.Red;
            this.lblPassCharacter.Location = new System.Drawing.Point(26, 100);
            this.lblPassCharacter.Name = "lblPassCharacter";
            this.lblPassCharacter.Size = new System.Drawing.Size(171, 13);
            this.lblPassCharacter.TabIndex = 9;
            this.lblPassCharacter.Text = "*Must contain at least 6 characters";
            this.lblPassCharacter.Visible = false;
            // 
            // txtPassNotMatched
            // 
            this.txtPassNotMatched.AutoSize = true;
            this.txtPassNotMatched.ForeColor = System.Drawing.Color.Red;
            this.txtPassNotMatched.Location = new System.Drawing.Point(73, 113);
            this.txtPassNotMatched.Name = "txtPassNotMatched";
            this.txtPassNotMatched.Size = new System.Drawing.Size(124, 13);
            this.txtPassNotMatched.TabIndex = 10;
            this.txtPassNotMatched.Text = "*Passwords Must Match!";
            this.txtPassNotMatched.Visible = false;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 299);
            this.Controls.Add(this.txtPassNotMatched);
            this.Controls.Add(this.lblPassCharacter);
            this.Controls.Add(this.txtPassConfirmation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBackToLogin);
            this.Controls.Add(this.btnSaveUser);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRegister";
            this.Text = "r3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSaveUser;
        private System.Windows.Forms.Button btnBackToLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassConfirmation;
        private System.Windows.Forms.Label lblPassCharacter;
        private System.Windows.Forms.Label txtPassNotMatched;
    }
}