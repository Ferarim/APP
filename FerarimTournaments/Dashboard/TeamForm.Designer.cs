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
            this.teamCodeBox = new System.Windows.Forms.TextBox();
            this.joinLabel = new System.Windows.Forms.Label();
            this.notInTeamLabel = new System.Windows.Forms.Label();
            this.teamPanel = new System.Windows.Forms.Panel();
            this.teamSettings = new FerarimTournaments.LoginButton();
            this.teammates = new FerarimTournaments.LoginButton();
            this.teamOwnerLabel = new System.Windows.Forms.Label();
            this.TeamNameLabel = new System.Windows.Forms.Label();
            this.joinButton = new FerarimTournaments.LoginButton();
            this.teamPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // teamCodeBox
            // 
            this.teamCodeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.teamCodeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamCodeBox.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teamCodeBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(161)))), ((int)(((byte)(166)))));
            this.teamCodeBox.Location = new System.Drawing.Point(255, 47);
            this.teamCodeBox.Margin = new System.Windows.Forms.Padding(4);
            this.teamCodeBox.Multiline = true;
            this.teamCodeBox.Name = "teamCodeBox";
            this.teamCodeBox.Size = new System.Drawing.Size(633, 30);
            this.teamCodeBox.TabIndex = 1;
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
            this.notInTeamLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // teamPanel
            // 
            this.teamPanel.Controls.Add(this.teamSettings);
            this.teamPanel.Controls.Add(this.teammates);
            this.teamPanel.Controls.Add(this.teamOwnerLabel);
            this.teamPanel.Controls.Add(this.TeamNameLabel);
            this.teamPanel.Location = new System.Drawing.Point(0, 117);
            this.teamPanel.Name = "teamPanel";
            this.teamPanel.Size = new System.Drawing.Size(1136, 605);
            this.teamPanel.TabIndex = 8;
            this.teamPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // teamSettings
            // 
            this.teamSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(203)))), ((int)(((byte)(145)))));
            this.teamSettings.FlatAppearance.BorderSize = 0;
            this.teamSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teamSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teamSettings.ForeColor = System.Drawing.Color.White;
            this.teamSettings.Location = new System.Drawing.Point(935, 154);
            this.teamSettings.Name = "teamSettings";
            this.teamSettings.Size = new System.Drawing.Size(150, 40);
            this.teamSettings.TabIndex = 11;
            this.teamSettings.Text = "TeamSettings";
            this.teamSettings.UseVisualStyleBackColor = false;
            // 
            // teammates
            // 
            this.teammates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(203)))), ((int)(((byte)(145)))));
            this.teammates.FlatAppearance.BorderSize = 0;
            this.teammates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teammates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teammates.ForeColor = System.Drawing.Color.White;
            this.teammates.Location = new System.Drawing.Point(935, 80);
            this.teammates.Name = "teammates";
            this.teammates.Size = new System.Drawing.Size(150, 40);
            this.teammates.TabIndex = 10;
            this.teammates.Text = "Teammates";
            this.teammates.UseVisualStyleBackColor = false;
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
            this.TeamNameLabel.Click += new System.EventHandler(this.label1_Click_2);
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
            // 
            // TeamForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(1140, 734);
            this.Controls.Add(this.joinButton);
            this.Controls.Add(this.teamPanel);
            this.Controls.Add(this.notInTeamLabel);
            this.Controls.Add(this.joinLabel);
            this.Controls.Add(this.teamCodeBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TeamForm";
            this.Text = "TeamForm";
            this.Load += new System.EventHandler(this.TeamForm_Load);
            this.teamPanel.ResumeLayout(false);
            this.teamPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox teamCodeBox;
        private System.Windows.Forms.Label joinLabel;
        private System.Windows.Forms.Label notInTeamLabel;
        private System.Windows.Forms.Panel teamPanel;
        private System.Windows.Forms.Label TeamNameLabel;
        private System.Windows.Forms.Label teamOwnerLabel;
        private LoginButton joinButton;
        private LoginButton teammates;
        private LoginButton teamSettings;
    }
}