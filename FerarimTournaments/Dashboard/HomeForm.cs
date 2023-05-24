using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using FerarimTournaments.Objects;
using FerarimTournaments.Login;

namespace FerarimTournaments.Dashboard
{
    public partial class HomeForm : Form
    {
        private IconButton currentBtn;
        private Form currentChildForm;
        private Account currentAccount;

        public static string CURRENT_ACCOUNT_ROLE;
        public HomeForm(Account account)
        {
            InitializeComponent();

            this.currentAccount = account;
            CURRENT_ACCOUNT_ROLE = account.Role;

            this.timer1.Start();
            
        }

        public void InitItems()
        {
            //this.yourTeamLabel.Text = get team name from API;
            //this.teamLogoPicture.Image = get image fro API;
            InitUpcomingTournaments();
        }

        public void InitUpcomingTournaments()
        {
            //get tournamens from api, just two or three
            //depends on account_ID, team_id
        }
        private struct RGBColors
        {
            public static Color activeButton = Color.FromArgb(11, 20, 73);
            public static Color inactiveButton = Color.FromArgb(11, 20, 33);
        }
        #region Open Forms
        public void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childFormPanel.Controls.Add(childForm);
            childFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion
        #region Activate Deactivate Buttons
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                //disable previous button
                DisableButton();

                //activate current button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = RGBColors.activeButton;
                //currentBtn.ForeColor = color;
                //currentBtn.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                //disable current button
                currentBtn.BackColor = RGBColors.inactiveButton;
                //currentBtn.ForeColor = System.Drawing.Color.OrangeRed;
                //currentBtn.IconColor = System.Drawing.Color.OrangeRed;
            }
        }

        #endregion
        private void AccountInfoFormBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.activeButton);
            OpenChildForm(new AccountInfoForm(currentAccount, this));
        }

        private void TeamFormBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.activeButton);
            OpenChildForm(new TeamForm(currentAccount, this));
        }

        private void TournamentsFormBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.activeButton);
            OpenChildForm(new TournamentsForm(currentAccount, this));
        }

        private void homePageLogoBtn_Click(object sender, EventArgs e)
        {
            DisableButton();
            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.timeLabel.Text = System.DateTime.Now.ToString();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm form = new LoginForm();
            form.Show();
        }


        public void yourTeamPanelClick(object sender, EventArgs e)
        {
            ActivateButton(this.TeamFormBtn, RGBColors.activeButton);
            OpenChildForm(new TeamForm(currentAccount, this));
        }

        private void HomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
