namespace FerarimTournaments.Controls
{
    partial class AccountControl
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.nameAndSurnameLabel = new System.Windows.Forms.Label();
            this.roleLabel = new System.Windows.Forms.Label();
            this.removeAccountFromTeamBtn = new FerarimTournaments.LoginButton();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Cascadia Mono", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(243)))), ((int)(((byte)(145)))));
            this.usernameLabel.Location = new System.Drawing.Point(3, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(145, 37);
            this.usernameLabel.TabIndex = 5;
            this.usernameLabel.Text = "Username";
            // 
            // nameAndSurnameLabel
            // 
            this.nameAndSurnameLabel.AutoSize = true;
            this.nameAndSurnameLabel.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameAndSurnameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(243)))), ((int)(((byte)(145)))));
            this.nameAndSurnameLabel.Location = new System.Drawing.Point(3, 37);
            this.nameAndSurnameLabel.Name = "nameAndSurnameLabel";
            this.nameAndSurnameLabel.Size = new System.Drawing.Size(156, 27);
            this.nameAndSurnameLabel.TabIndex = 6;
            this.nameAndSurnameLabel.Text = "Name Surname";
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.roleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(243)))), ((int)(((byte)(145)))));
            this.roleLabel.Location = new System.Drawing.Point(5, 92);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(108, 27);
            this.roleLabel.TabIndex = 7;
            this.roleLabel.Text = "ROLE_AAA";
            // 
            // removeAccountFromTeamBtn
            // 
            this.removeAccountFromTeamBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(203)))), ((int)(((byte)(145)))));
            this.removeAccountFromTeamBtn.FlatAppearance.BorderSize = 0;
            this.removeAccountFromTeamBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeAccountFromTeamBtn.ForeColor = System.Drawing.Color.White;
            this.removeAccountFromTeamBtn.Location = new System.Drawing.Point(238, 63);
            this.removeAccountFromTeamBtn.Name = "removeAccountFromTeamBtn";
            this.removeAccountFromTeamBtn.Size = new System.Drawing.Size(104, 40);
            this.removeAccountFromTeamBtn.TabIndex = 8;
            this.removeAccountFromTeamBtn.Text = "Remove";
            this.removeAccountFromTeamBtn.UseVisualStyleBackColor = false;
            // 
            // AccountControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.removeAccountFromTeamBtn);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.nameAndSurnameLabel);
            this.Controls.Add(this.usernameLabel);
            this.Name = "AccountControl";
            this.Size = new System.Drawing.Size(434, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label nameAndSurnameLabel;
        private System.Windows.Forms.Label roleLabel;
        private LoginButton removeAccountFromTeamBtn;
    }
}
