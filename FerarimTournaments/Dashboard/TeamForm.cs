using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FerarimTournaments.Objects;

namespace FerarimTournaments.Dashboard
{
    public partial class TeamForm : Form
    {
        private Account accountInstance;  
        public TeamForm(Account account)
        {
            InitializeComponent();
            this.accountInstance = account;
            TeamCheck();
            AdminCheck();
        }

        public void AdminCheck()
        {
            if (accountInstance.Role=="ROLE_USER")
            {
                teamSettings.Visible = false;
            }
        }

        public void TeamCheck()
        {
            if (true)
            {
                teamPanel.Visible = false;
            }
        }

        private void TeamForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
