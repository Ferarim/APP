using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FerarimTournaments.Dashboard;
using FerarimTournaments.Objects;

namespace FerarimTournaments.Tools
{
    public partial class ChangeAccountInfoForm : Form
    {
        private Account currentAccount;
        private HomeForm homeForm;
        public ChangeAccountInfoForm(Account account, HomeForm homeForm)
        {
            InitializeComponent();
            this.currentAccount = account;
            InitTextBoxes();
            this.homeForm = homeForm;
        }
        /// <summary>
        /// Autofills textboxes with current data
        /// </summary>
        public void InitTextBoxes()
        {
            this.changeNameTextBox.Text = currentAccount.FirstName;
            this.changeSurnameTextBox.Text = currentAccount.LastName;
        }

        private void applyChangesBtn_Click(object sender, EventArgs e)
        {
            //apply chnages to db
            string firstName = this.changeNameTextBox.Text;
            string lastName = this.changeSurnameTextBox.Text;

            //do the math bruh

            if (true)
            {
                MessageBox.Show("Changes applied");
                this.homeForm.OpenChildForm(new AccountInfoForm(this.currentAccount, homeForm));
            }
        }
    }
}
