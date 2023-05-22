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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // teamCodeBox
            // 
            this.teamCodeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.teamCodeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamCodeBox.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teamCodeBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(161)))), ((int)(((byte)(166)))));
            this.teamCodeBox.Location = new System.Drawing.Point(255, 47);
            this.teamCodeBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.teamCodeBox.Name = "teamCodeBox";
            this.teamCodeBox.Size = new System.Drawing.Size(633, 35);
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(161)))), ((int)(((byte)(166)))));
            this.button1.Location = new System.Drawing.Point(948, 47);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TeamForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(1140, 734);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.notInTeamLabel);
            this.Controls.Add(this.joinLabel);
            this.Controls.Add(this.teamCodeBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TeamForm";
            this.Text = "TeamForm";
            this.Load += new System.EventHandler(this.TeamForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox teamCodeBox;
        private System.Windows.Forms.Label joinLabel;
        private System.Windows.Forms.Label notInTeamLabel;
        private System.Windows.Forms.Button button1;
    }
}