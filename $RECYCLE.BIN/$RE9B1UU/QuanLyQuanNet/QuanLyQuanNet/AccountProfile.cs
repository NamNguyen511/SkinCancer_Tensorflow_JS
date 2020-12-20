using QuanLyQuanNet.DAO;
using QuanLyQuanNet.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanNet
{
    public partial class AccountProfile : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }
        public AccountProfile(Account acc)
        {
            InitializeComponent();

            LoginAccount = acc;
        }

        void ChangeAccount(Account acc)
        {
            txtUserName.Text = LoginAccount.UserName;
            txtDisplayName.Text = LoginAccount.DisplayName;
        }

        void UpdateAccountInfo()
        {
            string displayName = txtDisplayName.Text;
            string password = txtPassword.Text;
            string newpassword = txtNewPassword.Text;
            string reenterpassword = txtRetypeNewPass.Text;
            string username = txtUserName.Text;

            if (!newpassword.Equals(reenterpassword))
            {
                MessageBox.Show("Retype new password is wrong!");
            }
            else
            {
                if (AccountDAO.Instance.UpdateAccount(username, displayName, password, newpassword))
                {
                    MessageBox.Show("Update complete");
                    if (updateAccount != null)
                        updateAccount(this,new AccountEvent( AccountDAO.Instance.GetAccountByUsername(username)));
                }
                else
                {
                    MessageBox.Show("Please enter right password!");
                }
            }
        }

        private event EventHandler<AccountEvent> updateAccount;
        public event EventHandler<AccountEvent> UpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            UpdateAccountInfo();
        }
    }

    public class AccountEvent:EventArgs
    {
        private Account acc;

        public Account Acc { get => acc; set => acc = value; }

        public AccountEvent(Account acc)
        {
            this.Acc = acc;
        }
    }
}
