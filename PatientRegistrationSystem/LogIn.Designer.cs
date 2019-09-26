namespace PatientRegistrationSystem
{
    partial class Login
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
            this.label_UserName = new System.Windows.Forms.Label();
            this.label_psw = new System.Windows.Forms.Label();
            this.textBox_LoginName = new System.Windows.Forms.TextBox();
            this.textBox_psw = new System.Windows.Forms.TextBox();
            this.button_Registration = new System.Windows.Forms.Button();
            this.button_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_UserName
            // 
            this.label_UserName.AutoSize = true;
            this.label_UserName.Location = new System.Drawing.Point(113, 66);
            this.label_UserName.Name = "label_UserName";
            this.label_UserName.Size = new System.Drawing.Size(81, 17);
            this.label_UserName.TabIndex = 0;
            this.label_UserName.Text = "User name:";
            // 
            // label_psw
            // 
            this.label_psw.AutoSize = true;
            this.label_psw.Location = new System.Drawing.Point(114, 122);
            this.label_psw.Name = "label_psw";
            this.label_psw.Size = new System.Drawing.Size(73, 17);
            this.label_psw.TabIndex = 1;
            this.label_psw.Text = "Password:";
            // 
            // textBox_LoginName
            // 
            this.textBox_LoginName.Location = new System.Drawing.Point(221, 61);
            this.textBox_LoginName.Name = "textBox_LoginName";
            this.textBox_LoginName.Size = new System.Drawing.Size(130, 22);
            this.textBox_LoginName.TabIndex = 2;
            // 
            // textBox_psw
            // 
            this.textBox_psw.Location = new System.Drawing.Point(221, 122);
            this.textBox_psw.Name = "textBox_psw";
            this.textBox_psw.Size = new System.Drawing.Size(130, 22);
            this.textBox_psw.TabIndex = 3;
            // 
            // button_Registration
            // 
            this.button_Registration.Location = new System.Drawing.Point(93, 193);
            this.button_Registration.Name = "button_Registration";
            this.button_Registration.Size = new System.Drawing.Size(94, 39);
            this.button_Registration.TabIndex = 4;
            this.button_Registration.Text = "Registration";
            this.button_Registration.UseVisualStyleBackColor = true;
            // 
            // button_Login
            // 
            this.button_Login.Location = new System.Drawing.Point(286, 193);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(102, 38);
            this.button_Login.TabIndex = 5;
            this.button_Login.Text = "Log in";
            this.button_Login.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(487, 256);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.button_Registration);
            this.Controls.Add(this.textBox_psw);
            this.Controls.Add(this.textBox_LoginName);
            this.Controls.Add(this.label_psw);
            this.Controls.Add(this.label_UserName);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_UserName;
        private System.Windows.Forms.Label label_psw;
        private System.Windows.Forms.TextBox textBox_LoginName;
        private System.Windows.Forms.TextBox textBox_psw;
        private System.Windows.Forms.Button button_Registration;
        private System.Windows.Forms.Button button_Login;
    }
}

