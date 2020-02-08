namespace Despro
{
    partial class login
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
            this.desproTitle = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.forgetPassword = new System.Windows.Forms.Label();
            this.SignInBtn = new System.Windows.Forms.Button();
            this.WrongLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // desproTitle
            // 
            this.desproTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.desproTitle.AutoSize = true;
            this.desproTitle.Location = new System.Drawing.Point(96, 33);
            this.desproTitle.Name = "desproTitle";
            this.desproTitle.Size = new System.Drawing.Size(113, 13);
            this.desproTitle.TabIndex = 0;
            this.desproTitle.Text = "INSERT TITLE HERE";
            // 
            // logo
            // 
            this.logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.logo.AutoSize = true;
            this.logo.Location = new System.Drawing.Point(96, 84);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(113, 13);
            this.logo.TabIndex = 1;
            this.logo.Text = "INSERT LOGO HERE";
            // 
            // usernameBox
            // 
            this.usernameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.usernameBox.Location = new System.Drawing.Point(46, 259);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(246, 20);
            this.usernameBox.TabIndex = 2;
            this.usernameBox.Click += new System.EventHandler(this.usernameBox_Click);
            this.usernameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UsernameBox_KeyDown);
            // 
            // passwordBox
            // 
            this.passwordBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.passwordBox.Location = new System.Drawing.Point(46, 341);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(246, 20);
            this.passwordBox.TabIndex = 3;
            this.passwordBox.Click += new System.EventHandler(this.passwordBox_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password:";
            // 
            // forgetPassword
            // 
            this.forgetPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.forgetPassword.AutoSize = true;
            this.forgetPassword.Location = new System.Drawing.Point(45, 364);
            this.forgetPassword.Name = "forgetPassword";
            this.forgetPassword.Size = new System.Drawing.Size(86, 13);
            this.forgetPassword.TabIndex = 6;
            this.forgetPassword.Text = "Forget Password";
            // 
            // SignInBtn
            // 
            this.SignInBtn.Location = new System.Drawing.Point(119, 393);
            this.SignInBtn.Name = "SignInBtn";
            this.SignInBtn.Size = new System.Drawing.Size(75, 23);
            this.SignInBtn.TabIndex = 7;
            this.SignInBtn.Text = "LOGIN";
            this.SignInBtn.UseVisualStyleBackColor = true;
            this.SignInBtn.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // WrongLabel
            // 
            this.WrongLabel.AutoSize = true;
            this.WrongLabel.ForeColor = System.Drawing.Color.Red;
            this.WrongLabel.Location = new System.Drawing.Point(115, 428);
            this.WrongLabel.Name = "WrongLabel";
            this.WrongLabel.Size = new System.Drawing.Size(94, 13);
            this.WrongLabel.TabIndex = 8;
            this.WrongLabel.Text = "Wrong Credentials";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 450);
            this.Controls.Add(this.WrongLabel);
            this.Controls.Add(this.SignInBtn);
            this.Controls.Add(this.forgetPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.desproTitle);
            this.Name = "login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label desproTitle;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label forgetPassword;
        private System.Windows.Forms.Button SignInBtn;
        private System.Windows.Forms.Label WrongLabel;
    }
}

