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
    public partial class AccountPlayer : Form
    {
        BindingSource accountplayer = new BindingSource();
        public AccountPlayer()
        {
            InitializeComponent();
            dgvAccountUser.DataSource = accountplayer;
            LoadAccountPlayer();
            AddAccountPlayerBinding();
        }

        void LoadAccountPlayer()
        {
            accountplayer.DataSource = AccountPlayerDAO.Instance.GetListAccountPlayer();
        }

        void AddAccountPlayerBinding()
        {
            txtUsernameAccountUser.DataBindings.Add(new Binding("Text", dgvAccountUser.DataSource, "username", true, DataSourceUpdateMode.Never));
            nmrMoneyPlayer.DataBindings.Add(new Binding("Value", dgvAccountUser.DataSource, "money", true, DataSourceUpdateMode.Never));
            txtNoteAccountUser.DataBindings.Add(new Binding("Text", dgvAccountUser.DataSource, "note", true, DataSourceUpdateMode.Never));
            txtIDPlayer.DataBindings.Add(new Binding("Text", dgvAccountUser.DataSource, "id", true, DataSourceUpdateMode.Never));
        }

        void AddAccountPlayer(string username, string pass, float money, string note)
        {
            if(AccountPlayerDAO.Instance.InsertAccount(username, money, note, pass))
            {
                MessageBox.Show("Add account complete");
            }
            else
            {
                MessageBox.Show("Error");
            }
            LoadAccountPlayer();
        }

        void ModifyAccountPlayer(float money, int id)
        {
            if (AccountPlayerDAO.Instance.UpdateAccount(money, id))
            {
                MessageBox.Show("Update account complete");
            }
            else
            {
                MessageBox.Show("Error");
            }
            LoadAccountPlayer();
        }

        void DeleteAccountPlayer(int id)
        {
            if (AccountPlayerDAO.Instance.DeleteAccount(id))
            {
                MessageBox.Show("Delete account complete");
            }
            else
            {
                MessageBox.Show("Error");
            }
            LoadAccountPlayer();
        }

        void ResetPassword (int id)
        {
            if (AccountPlayerDAO.Instance.ResetPass(id))
            {
                MessageBox.Show("Reset password complete");
            }
            else
            {
                MessageBox.Show("Error");
            }
            LoadAccountPlayer();
        }
        private void btnViewAccountUser_Click(object sender, EventArgs e)
        {
            LoadAccountPlayer();
        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddAccountUser_Click(object sender, EventArgs e)
        {
            string username = txtUsernameAccountUser.Text;
            string pass = txtPassPlayer.Text;
            float money = (float)nmrMoneyPlayer.Value;
            string note = txtNoteAccountUser.Text;
            AddAccountPlayer(username, pass, money, note);
        }

        private void btnDeleteAccountUser_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIDPlayer.Text);
            DeleteAccountPlayer(id);
        }

        private void btnModifyAccountUser_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIDPlayer.Text);
            float money = (float)nmrMoneyPlayer.Value;
            ModifyAccountPlayer(money, id);
        }

        private void btnResetPass_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIDPlayer.Text);
            ResetPassword(id);
        }
    }
}
