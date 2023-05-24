using FerarimTournaments.Controls;
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
    public partial class TeammatesForm : Form
    {
        private List<Account> members;
        public TeammatesForm(List<Account> members)
        {
            InitializeComponent();
            this.members = members;
            ShowTeammates();
        }

        public void ShowTeammates()
        {
            
            this.flowPanel.Controls.Clear();
            
            List<AccountControl> accountList = new List<AccountControl>();

            foreach (Account account in members)
            {
                accountList.Add(new AccountControl(account));
            }

            var sortedAccountList = accountList.OrderBy(a => a.AccountInstance.FirstName);
            AccountControl[] finalList = sortedAccountList.ToArray();
            foreach (AccountControl a in finalList)
            {
                this.flowPanel.Controls.Add(a);
            }
        }
        
}
}
