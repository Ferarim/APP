namespace FerarimTournaments.Dashboard
{
    partial class TeamForm
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
            this.teamNameBox = new System.Windows.Forms.TextBox();
            this.joinLabel = new System.Windows.Forms.Label();
            this.notInTeamLabel = new System.Windows.Forms.Label();
            this.teamPanel = new System.Windows.Forms.Panel();
            this.teamSettingsBtn = new FerarimTournaments.LoginButton();
            this.teammatesBtn = new FerarimTournaments.LoginButton();
            this.teamOwnerLabel = new System.Windows.Forms.Label();
            this.TeamNameLabel = new System.Windows.Forms.Label();
            this.joinButton = new FerarimTournaments.LoginButton();
            this.teamPassBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.teamPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // teamNameBox
            // 
            this.teamNameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.teamNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamNameBox.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teamNameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(161)))), ((int)(((byte)(166)))));
            this.teamNameBox.Location = new System.Drawing.Point(255, 47);
            this.teamNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.teamNameBox.Multiline = true;
            this.teamNameBox.Name = "teamNameBox";
            this.teamNameBox.Size = new System.Drawing.Size(270, 30);
            this.teamNameBox.TabIndex = 1;
            // 
            // joinLabel
            // 
            this.joinLabel.AutoSize = true;
            this.joinLabel.Font = new System.Drawing.Font("Cascadia Mono", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joinLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(243)))), ((int)(((byte)(145)))));
            this.joinLabel.Location = new System.Drawing.Point(37, 43);
            this.joinLabel.Name = "joinLabel";
            this.joinLabel.Size = new System.Drawing.Size(161, 37);
            this.joinLabel.TabIndex = 5;
            this.joinLabel.Text = "Join team";
            // 
            // notInTeamLabel
            // 
            this.notInTeamLabel.AutoSize = true;
            this.notInTeamLabel.Font = new System.Drawing.Font("Cascadia Mono", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.notInTeamLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(243)))), ((int)(((byte)(145)))));
            this.notInTeamLabel.Location = new System.Drawing.Point(287, 361);
            this.notInTeamLabel.Name = "notInTeamLabel";
            this.notInTeamLabel.Size = new System.Drawing.Size(505, 52);
            this.notInTeamLabel.TabIndex = 6;
            this.notInTeamLabel.Text = "You are not in a team";
            // 
            // teamPanel
            // 
            this.teamPanel.Controls.Add(this.teamSettingsBtn);
            this.teamPanel.Controls.Add(this.teammatesBtn);
            this.teamPanel.Controls.Add(this.teamOwnerLabel);
            this.teamPanel.Controls.Add(this.TeamNameLabel);
            this.teamPanel.Location = new System.Drawing.Point(0, 117);
            this.teamPanel.Name = "teamPanel";
            this.teamPanel.Size = new System.Drawing.Size(1136, 605);
            this.teamPanel.TabIndex = 8;
            // 
            // teamSettingsBtn
            // 
            this.teamSettingsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(203)))), ((int)(((byte)(145)))));
            this.teamSettingsBtn.FlatAppearance.BorderSize = 0;
            this.teamSettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teamSettingsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teamSettingsBtn.ForeColor = System.Drawing.Color.White;
            this.teamSettingsBtn.Location = new System.Drawing.Point(935, 154);
            this.teamSettingsBtn.Name = "teamSettingsBtn";
            this.teamSettingsBtn.Size = new System.Drawing.Size(150, 40);
            this.teamSettingsBtn.TabIndex = 11;
            this.teamSettingsBtn.Text = "TeamSettings";
            this.teamSettingsBtn.UseVisualStyleBackColor = false;
            this.teamSettingsBtn.Click += new System.EventHandler(this.teamSettings_Click);
            // 
            // teammatesBtn
            // 
            this.teammatesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(203)))), ((int)(((byte)(145)))));
            this.teammatesBtn.FlatAppearance.BorderSize = 0;
            this.teammatesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teammatesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teammatesBtn.ForeColor = System.Drawing.Color.White;
            this.teammatesBtn.Location = new System.Drawing.Point(935, 80);
            this.teammatesBtn.Name = "teammatesBtn";
            this.teammatesBtn.Size = new System.Drawing.Size(150, 40);
            this.teammatesBtn.TabIndex = 10;
            this.teammatesBtn.Text = "Teammates";
            this.teammatesBtn.UseVisualStyleBackColor = false;
            this.teammatesBtn.Click += new System.EventHandler(this.teammates_Click);
            // 
            // teamOwnerLabel
            // 
            this.teamOwnerLabel.AutoSize = true;
            this.teamOwnerLabel.Font = new System.Drawing.Font("Cascadia Mono", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teamOwnerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(243)))), ((int)(((byte)(145)))));
            this.teamOwnerLabel.Location = new System.Drawing.Point(483, 155);
            this.teamOwnerLabel.Name = "teamOwnerLabel";
            this.teamOwnerLabel.Size = new System.Drawing.Size(220, 49);
            this.teamOwnerLabel.TabIndex = 7;
            this.teamOwnerLabel.Text = "TeamOwner";
            // 
            // TeamNameLabel
            // 
            this.TeamNameLabel.AutoSize = true;
            this.TeamNameLabel.Font = new System.Drawing.Font("Cascadia Mono", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TeamNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(243)))), ((int)(((byte)(145)))));
            this.TeamNameLabel.Location = new System.Drawing.Point(403, 57);
            this.TeamNameLabel.Name = "TeamNameLabel";
            this.TeamNameLabel.Size = new System.Drawing.Size(421, 106);
            this.TeamNameLabel.TabIndex = 6;
            this.TeamNameLabel.Text = "TeamName";
            // 
            // joinButton
            // 
            this.joinButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(203)))), ((int)(((byte)(145)))));
            this.joinButton.FlatAppearance.BorderSize = 0;
            this.joinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.joinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.joinButton.ForeColor = System.Drawing.Color.White;
            this.joinButton.Location = new System.Drawing.Point(935, 47);
            this.joinButton.Name = "joinButton";
            this.joinButton.Size = new System.Drawing.Size(150, 40);
            this.joinButton.TabIndex = 9;
            this.joinButton.Text = "join";
            this.joinButton.UseVisualStyleBackColor = false;
            this.joinButton.Click += new System.EventHandler(this.joinButton_Click);
            // 
            // teamPassBox
            // 
            this.teamPassBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.teamPassBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamPassBox.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teamPassBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(161)))), ((int)(((byte)(166)))));
            this.teamPassBox.Location = new System.Drawing.Point(589, 47);
            this.teamPassBox.Margin = new System.Windows.Forms.Padding(4);
            this.teamPassBox.Multiline = true;
            this.teamPassBox.Name = "teamPassBox";
            this.teamPassBox.Size = new System.Drawing.Size(270, 30);
            this.teamPassBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(243)))), ((int)(((byte)(145)))));
            this.label1.Location = new System.Drawing.Point(310, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "Team Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(243)))), ((int)(((byte)(145)))));
            this.label2.Location = new System.Drawing.Point(610, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 37);
            this.label2.TabIndex = 12;
            this.label2.Text = "Team Password";
            // 
            // TeamForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(1140, 734);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.teamPassBox);
            this.Controls.Add(this.joinButton);
            this.Controls.Add(this.teamPanel);
            this.Controls.Add(this.notInTeamLabel);
            this.Controls.Add(this.joinLabel);
            this.Controls.Add(this.teamNameBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TeamForm";
            this.Text = "TeamForm";
            this.teamPanel.ResumeLayout(false);
            this.teamPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox teamNameBox;
        private System.Windows.Forms.Label joinLabel;
        private System.Windows.Forms.Label notInTeamLabel;
        private System.Windows.Forms.Panel teamPanel;
        private System.Windows.Forms.Label TeamNameLabel;
        private System.Windows.Forms.Label teamOwnerLabel;
        private LoginButton joinButton;
        private LoginButton teammatesBtn;
        private LoginButton teamSettingsBtn;
        private System.Windows.Forms.TextBox teamPassBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}