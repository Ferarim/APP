namespace FerarimTournaments.Controls
{
    partial class TournamentControl
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
            this.dateLabel = new System.Windows.Forms.Label();
            this.team1VSteam2Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Cascadia Mono", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(243)))), ((int)(((byte)(145)))));
            this.dateLabel.Location = new System.Drawing.Point(27, 25);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(145, 37);
            this.dateLabel.TabIndex = 5;
            this.dateLabel.Text = "datetime";
            this.dateLabel.Click += new System.EventHandler(this.TournamentControl_Click);
            // 
            // team1VSteam2Label
            // 
            this.team1VSteam2Label.AutoSize = true;
            this.team1VSteam2Label.Font = new System.Drawing.Font("Cascadia Mono", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team1VSteam2Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(243)))), ((int)(((byte)(145)))));
            this.team1VSteam2Label.Location = new System.Drawing.Point(399, 25);
            this.team1VSteam2Label.Name = "team1VSteam2Label";
            this.team1VSteam2Label.Size = new System.Drawing.Size(241, 37);
            this.team1VSteam2Label.TabIndex = 6;
            this.team1VSteam2Label.Text = "team1 vs team2";
            this.team1VSteam2Label.Click += new System.EventHandler(this.TournamentControl_Click);
            // 
            // TournamentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.team1VSteam2Label);
            this.Controls.Add(this.dateLabel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "TournamentControl";
            this.Size = new System.Drawing.Size(1050, 85);
            this.Click += new System.EventHandler(this.TournamentControl_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label team1VSteam2Label;
    }
}
