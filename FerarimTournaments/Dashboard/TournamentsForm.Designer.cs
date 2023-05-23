namespace FerarimTournaments.Dashboard
{
    partial class TournamentsForm
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
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.newTournamentBtn = new FerarimTournaments.LoginButton();
            this.SuspendLayout();
            // 
            // flowPanel
            // 
            this.flowPanel.Location = new System.Drawing.Point(12, 111);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(1116, 610);
            this.flowPanel.TabIndex = 0;
            // 
            // newTournamentBtn
            // 
            this.newTournamentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(203)))), ((int)(((byte)(145)))));
            this.newTournamentBtn.FlatAppearance.BorderSize = 0;
            this.newTournamentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newTournamentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newTournamentBtn.ForeColor = System.Drawing.Color.White;
            this.newTournamentBtn.Location = new System.Drawing.Point(847, 31);
            this.newTournamentBtn.Name = "newTournamentBtn";
            this.newTournamentBtn.Size = new System.Drawing.Size(248, 55);
            this.newTournamentBtn.TabIndex = 1;
            this.newTournamentBtn.Text = "New Tournament";
            this.newTournamentBtn.UseVisualStyleBackColor = false;
            this.newTournamentBtn.Click += new System.EventHandler(this.newTournamentBtn_Click);
            // 
            // TournamentsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(1140, 733);
            this.Controls.Add(this.newTournamentBtn);
            this.Controls.Add(this.flowPanel);
            this.Name = "TournamentsForm";
            this.Text = "TournamentsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowPanel;
        private LoginButton newTournamentBtn;
    }
}