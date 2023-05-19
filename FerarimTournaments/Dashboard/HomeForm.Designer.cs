using System;

namespace FerarimTournaments.Dashboard
{
    partial class HomeForm
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
            this.components = new System.ComponentModel.Container();
            this.SideBarPanel = new System.Windows.Forms.Panel();
            this.logoutBtn = new FerarimTournaments.LoginButton();
            this.homePageLogoBtn = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TournamentsFormBtn = new FontAwesome.Sharp.IconButton();
            this.TeamFormBtn = new FontAwesome.Sharp.IconButton();
            this.AccountInfoFormBtn = new FontAwesome.Sharp.IconButton();
            this.childFormPanel = new System.Windows.Forms.Panel();
            this.upcomingTournamentsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.teamLogoPicture = new System.Windows.Forms.PictureBox();
            this.yourTeamLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SideBarPanel.SuspendLayout();
            this.homePageLogoBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.childFormPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamLogoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // SideBarPanel
            // 
            this.SideBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.SideBarPanel.Controls.Add(this.logoutBtn);
            this.SideBarPanel.Controls.Add(this.homePageLogoBtn);
            this.SideBarPanel.Controls.Add(this.TournamentsFormBtn);
            this.SideBarPanel.Controls.Add(this.TeamFormBtn);
            this.SideBarPanel.Controls.Add(this.AccountInfoFormBtn);
            this.SideBarPanel.Location = new System.Drawing.Point(0, 0);
            this.SideBarPanel.Name = "SideBarPanel";
            this.SideBarPanel.Size = new System.Drawing.Size(242, 736);
            this.SideBarPanel.TabIndex = 0;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(161)))), ((int)(((byte)(166)))));
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.Location = new System.Drawing.Point(42, 671);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(150, 40);
            this.logoutBtn.TabIndex = 4;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // homePageLogoBtn
            // 
            this.homePageLogoBtn.Controls.Add(this.pictureBox1);
            this.homePageLogoBtn.Location = new System.Drawing.Point(0, 0);
            this.homePageLogoBtn.Name = "homePageLogoBtn";
            this.homePageLogoBtn.Size = new System.Drawing.Size(242, 144);
            this.homePageLogoBtn.TabIndex = 0;
            this.homePageLogoBtn.Click += new System.EventHandler(this.homePageLogoBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FerarimTournaments.Properties.Resources.logo;
            this.pictureBox1.InitialImage = global::FerarimTournaments.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(48, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.homePageLogoBtn_Click);
            // 
            // TournamentsFormBtn
            // 
            this.TournamentsFormBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.TournamentsFormBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TournamentsFormBtn.FlatAppearance.BorderSize = 0;
            this.TournamentsFormBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TournamentsFormBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TournamentsFormBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(161)))), ((int)(((byte)(166)))));
            this.TournamentsFormBtn.IconChar = FontAwesome.Sharp.IconChar.Stopwatch;
            this.TournamentsFormBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(161)))), ((int)(((byte)(166)))));
            this.TournamentsFormBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.TournamentsFormBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TournamentsFormBtn.Location = new System.Drawing.Point(6, 322);
            this.TournamentsFormBtn.Name = "TournamentsFormBtn";
            this.TournamentsFormBtn.Size = new System.Drawing.Size(236, 75);
            this.TournamentsFormBtn.TabIndex = 3;
            this.TournamentsFormBtn.Text = "Tournaments";
            this.TournamentsFormBtn.UseVisualStyleBackColor = false;
            this.TournamentsFormBtn.Click += new System.EventHandler(this.TournamentsFormBtn_Click);
            // 
            // TeamFormBtn
            // 
            this.TeamFormBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.TeamFormBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TeamFormBtn.FlatAppearance.BorderSize = 0;
            this.TeamFormBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TeamFormBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TeamFormBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(161)))), ((int)(((byte)(166)))));
            this.TeamFormBtn.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.TeamFormBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(161)))), ((int)(((byte)(166)))));
            this.TeamFormBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.TeamFormBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TeamFormBtn.Location = new System.Drawing.Point(3, 231);
            this.TeamFormBtn.Name = "TeamFormBtn";
            this.TeamFormBtn.Size = new System.Drawing.Size(236, 75);
            this.TeamFormBtn.TabIndex = 2;
            this.TeamFormBtn.Text = "Team";
            this.TeamFormBtn.UseVisualStyleBackColor = false;
            this.TeamFormBtn.Click += new System.EventHandler(this.TeamFormBtn_Click);
            // 
            // AccountInfoFormBtn
            // 
            this.AccountInfoFormBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.AccountInfoFormBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AccountInfoFormBtn.FlatAppearance.BorderSize = 0;
            this.AccountInfoFormBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountInfoFormBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AccountInfoFormBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(161)))), ((int)(((byte)(166)))));
            this.AccountInfoFormBtn.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.AccountInfoFormBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(161)))), ((int)(((byte)(166)))));
            this.AccountInfoFormBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AccountInfoFormBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AccountInfoFormBtn.Location = new System.Drawing.Point(3, 150);
            this.AccountInfoFormBtn.Name = "AccountInfoFormBtn";
            this.AccountInfoFormBtn.Size = new System.Drawing.Size(236, 75);
            this.AccountInfoFormBtn.TabIndex = 1;
            this.AccountInfoFormBtn.Text = "Account Information";
            this.AccountInfoFormBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AccountInfoFormBtn.UseVisualStyleBackColor = false;
            this.AccountInfoFormBtn.Click += new System.EventHandler(this.AccountInfoFormBtn_Click);
            // 
            // childFormPanel
            // 
            this.childFormPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(84)))));
            this.childFormPanel.Controls.Add(this.upcomingTournamentsFlowPanel);
            this.childFormPanel.Controls.Add(this.panel2);
            this.childFormPanel.Controls.Add(this.panel1);
            this.childFormPanel.Controls.Add(this.timeLabel);
            this.childFormPanel.Location = new System.Drawing.Point(242, 0);
            this.childFormPanel.Name = "childFormPanel";
            this.childFormPanel.Size = new System.Drawing.Size(1138, 733);
            this.childFormPanel.TabIndex = 1;
            // 
            // upcomingTournamentsFlowPanel
            // 
            this.upcomingTournamentsFlowPanel.AutoScroll = true;
            this.upcomingTournamentsFlowPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(43)))), ((int)(((byte)(74)))));
            this.upcomingTournamentsFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.upcomingTournamentsFlowPanel.Location = new System.Drawing.Point(537, 150);
            this.upcomingTournamentsFlowPanel.Name = "upcomingTournamentsFlowPanel";
            this.upcomingTournamentsFlowPanel.Size = new System.Drawing.Size(562, 446);
            this.upcomingTournamentsFlowPanel.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(43)))), ((int)(((byte)(74)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(537, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(562, 48);
            this.panel2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Mono", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(243)))), ((int)(((byte)(145)))));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(353, 37);
            this.label4.TabIndex = 5;
            this.label4.Text = "Upcoming Tournaments:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(43)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.teamLogoPicture);
            this.panel1.Controls.Add(this.yourTeamLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(13, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 156);
            this.panel1.TabIndex = 2;
            // 
            // teamLogoPicture
            // 
            this.teamLogoPicture.Location = new System.Drawing.Point(11, 40);
            this.teamLogoPicture.Name = "teamLogoPicture";
            this.teamLogoPicture.Size = new System.Drawing.Size(80, 80);
            this.teamLogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.teamLogoPicture.TabIndex = 7;
            this.teamLogoPicture.TabStop = false;
            // 
            // yourTeamLabel
            // 
            this.yourTeamLabel.AutoSize = true;
            this.yourTeamLabel.Font = new System.Drawing.Font("Cascadia Mono", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourTeamLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(243)))), ((int)(((byte)(145)))));
            this.yourTeamLabel.Location = new System.Drawing.Point(97, 63);
            this.yourTeamLabel.Name = "yourTeamLabel";
            this.yourTeamLabel.Size = new System.Drawing.Size(305, 37);
            this.yourTeamLabel.TabIndex = 6;
            this.yourTeamLabel.Text = "You\'re not in team";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(243)))), ((int)(((byte)(145)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Your Team:";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Cascadia Mono", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(243)))), ((int)(((byte)(145)))));
            this.timeLabel.Location = new System.Drawing.Point(6, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(129, 37);
            this.timeLabel.TabIndex = 4;
            this.timeLabel.Text = "Ferarim";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(1382, 733);
            this.Controls.Add(this.childFormPanel);
            this.Controls.Add(this.SideBarPanel);
            this.MaximizeBox = false;
            this.Name = "HomeForm";
            this.Text = "HomePage";
            this.SideBarPanel.ResumeLayout(false);
            this.homePageLogoBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.childFormPanel.ResumeLayout(false);
            this.childFormPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamLogoPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SideBarPanel;
        private FontAwesome.Sharp.IconButton AccountInfoFormBtn;
        private System.Windows.Forms.Panel childFormPanel;
        private FontAwesome.Sharp.IconButton TeamFormBtn;
        private FontAwesome.Sharp.IconButton TournamentsFormBtn;
        private System.Windows.Forms.Panel homePageLogoBtn;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox teamLogoPicture;
        private System.Windows.Forms.Label yourTeamLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel upcomingTournamentsFlowPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private LoginButton logoutBtn;
    }
}