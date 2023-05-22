namespace FerarimTournaments.Login
{
    partial class LoginForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.password = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.username = new System.Windows.Forms.TextBox();
            this.loginButton2 = new FerarimTournaments.LoginButton();
            this.loginButton = new FerarimTournaments.LoginButton();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panel2.Controls.Add(this.password);
            this.panel2.Location = new System.Drawing.Point(133, 246);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.panel2.Size = new System.Drawing.Size(467, 49);
            this.panel2.TabIndex = 1;
            // 
            // password
            // 
            this.password.AcceptsReturn = true;
            this.password.AcceptsTab = true;
            this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.SystemColors.Window;
            this.password.Location = new System.Drawing.Point(13, 12);
            this.password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(441, 23);
            this.password.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panel1.Controls.Add(this.username);
            this.panel1.Location = new System.Drawing.Point(133, 62);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.panel1.Size = new System.Drawing.Size(467, 49);
            this.panel1.TabIndex = 0;
            // 
            // username
            // 
            this.username.AcceptsReturn = true;
            this.username.AcceptsTab = true;
            this.username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username.Dock = System.Windows.Forms.DockStyle.Fill;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.SystemColors.Window;
            this.username.Location = new System.Drawing.Point(13, 12);
            this.username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(441, 23);
            this.username.TabIndex = 0;
            // 
            // loginButton2
            // 
            this.loginButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(203)))), ((int)(((byte)(145)))));
            this.loginButton2.FlatAppearance.BorderSize = 0;
            this.loginButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton2.ForeColor = System.Drawing.Color.White;
            this.loginButton2.Location = new System.Drawing.Point(133, 400);
            this.loginButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginButton2.Name = "loginButton2";
            this.loginButton2.Size = new System.Drawing.Size(200, 49);
            this.loginButton2.TabIndex = 3;
            this.loginButton2.Text = "Register";
            this.loginButton2.UseVisualStyleBackColor = false;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(203)))), ((int)(((byte)(145)))));
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(400, 400);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(200, 49);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(172)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(1045, 506);
            this.Controls.Add(this.loginButton2);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginForm_Paint);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private LoginButton loginButton;
        private LoginButton loginButton2;
    }
}
