using QuanLyQuanNet.DAO;
using QuanLyQuanNet.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu = QuanLyQuanNet.DTO.Menu;

namespace QuanLyQuanNet
{
    public partial class ComputerManager : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }
        public ComputerManager(Account acc)
        {
            InitializeComponent();

            this.LoginAccount = acc;

            loadComputer();
            LoadCategory();
            LoadCbClient(cbSwap);

        }
        #region method

        void ChangeAccount(int type)
        {
            adminToolStripMenuItem.Enabled = type == 1;
            accountProfileToolStripMenuItem.Text += " (" + LoginAccount.DisplayName + ")";
        }

        void LoadCategory()
        {
            List<FoodCategory> listcategory = FoodCategoryDAO.Instance.GetListCategory();
            cbCategory.DataSource = listcategory;
            cbCategory.DisplayMember = "Name1";
        }

        void LoadFoodListByCategoryID(int ID)
        {
            List<Food> listfood = FoodDAO.Instance.GetFoodByCategoryID(ID);
            cbFood.DataSource = listfood;
            cbFood.DisplayMember = "Name";
        }

        void loadComputer()
        {
            flpComputer.Controls.Clear();
            List<Computer> computerlist = ComputerDAO.Instance.LoadComputerList();

            foreach (Computer item in computerlist)
            {
                Button btn = new Button() { Width = ComputerDAO.ComputerWidth, Height = ComputerDAO.ComputerHeight };
                if (item.IdPlayer != 0)
                {
                    btn.Text = item.Name + item.IdPlayer + Environment.NewLine + item.Status;
                }
                else
                {
                    btn.Text = item.Name + Environment.NewLine + item.Status;
                }
                btn.Click += btn_Click;
                btn.Tag = item;

                switch (item.Status)
                {
                    case "Trong":
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.BlueViolet;
                        break;
                }

                flpComputer.Controls.Add(btn);
            }
        }

        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            List<QuanLyQuanNet.DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByComputer(id);
            float totalprice = 0;
            foreach (QuanLyQuanNet.DTO.Menu item in listBillInfo)
            {
                ListViewItem lvItem = new ListViewItem(item.FoodName.ToString());
                lvItem.SubItems.Add(item.Count.ToString());
                lvItem.SubItems.Add(item.Price.ToString());
                //lvItem.SubItems.Add(item.PlayTime.ToString());
                lvItem.SubItems.Add(item.TotalPrice.ToString());
                totalprice += item.TotalPrice;
                lsvBill.Items.Add(lvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            //Thread.CurrentThread.CurrentCulture = culture;
            Totalpricetxt.Text = totalprice.ToString("c", culture);

        }

        void LoadCbClient(ComboBox cb)
        {
            cb.DataSource = ComputerDAO.Instance.LoadComputerList();
            cb.DisplayMember = "name";
        }

        #endregion

        #region events

        private void btn_Click(object sender, EventArgs e)
        {
            int ComputerID = ((sender as Button).Tag as Computer).ID;
            lsvBill.Tag = (sender as Button).Tag;
            ShowBill(ComputerID);
        }
        private void ComputerManager_Load(object sender, EventArgs e)
        {

        }

        

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ID = 0;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            FoodCategory selected = cb.SelectedItem as FoodCategory;
            ID = selected.ID;

            LoadFoodListByCategoryID(ID);
        }

        private void addfoodbtn_Click(object sender, EventArgs e)
        {
            Computer computer = lsvBill.Tag as Computer;

            int idBill = BillDAO.Instance.InsertFoodintoBillbyComputerID(computer.ID);
            int foodID = (cbFood.SelectedItem as Food).ID;
            int count = (int)nmrFoodCount.Value;

                BillInfoDAO.Instance.InsertFoodBillInfo(idBill, foodID, count);
            ShowBill(computer.ID);
        }

        private void CheckOutbtn_Click(object sender, EventArgs e)
        {
            Computer computer = lsvBill.Tag as Computer;
            int idBill = BillDAO.Instance.GetUncheckBillIDbyComputerID(computer.ID);
            string query = " update dbo.Bill set time_left = GETDATE() where status = 0 and id_client = " + computer.ID + " and id = " + idBill;
            DataProvider.Instance.ExecuteNonQuery(query);
            DataProvider.Instance.ExecuteNonQuery("exec CalTotalPrice " + computer.ID + "," + idBill);
            int discount = (int)nmrDiscount.Value;
            double totalprice = Convert.ToDouble(BillDAO.Instance.TotalPrice(idBill));
            double totalprice1 = Convert.ToDouble(Totalpricetxt.Text.Split(',')[0].Replace(".",""));
            double finaltotalprice = (totalprice + totalprice1) - ((totalprice + totalprice1)  * discount/100);

            if (idBill != -1)
            {
                if (MessageBox.Show(string.Format("Are you sure check out for table {0} \n Total price is {1} with discount = {2} ", computer.Name, finaltotalprice, discount), "Notification", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill, discount);
                    ShowBill(computer.ID);
                    loadComputer();
                }
            }
        }

        private void adduserbtn_Click(object sender, EventArgs e)
        {
            Computer computer = lsvBill.Tag as Computer;
            if (computer == null)
            {
                MessageBox.Show("Should choose client first");
                return;
            }
            int idBill = BillDAO.Instance.GetUncheckBillIDbyComputerID(computer.ID);
            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(computer.ID);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill());
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill);
            }
            ShowBill(computer.ID);
            loadComputer();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountProfile f = new AccountProfile(loginAccount);
            f.UpdateAccount += f_UpdateAccount;
            f.ShowDialog();
        }

        private void f_UpdateAccount(object sender, AccountEvent e)
        {
           accountProfileToolStripMenuItem.Text = "Information of Account (" + e.Acc.DisplayName + ")";
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin f = new Admin();
            f.loginAccount = LoginAccount;
            f.ShowDialog();
        }

        private void Totalpricetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Swapbtn_Click(object sender, EventArgs e)
        {
            int id1 = (lsvBill.Tag as Computer).ID;
            int id2 = (cbSwap.SelectedItem as Computer).ID;
            if (MessageBox.Show(string.Format("Do you want to swap from {0} to {1}", (lsvBill.Tag as Computer).Name, (cbSwap.SelectedItem as Computer).Name), "Notification", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                ComputerDAO.Instance.SwapClient(id1, id2);
                loadComputer();
            }
        }
        private void accountPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountPlayer f = new AccountPlayer();
            f.ShowDialog();
        }

        private void AddAccountbtn_Click(object sender, EventArgs e)
        {
            string account = Accounttxt.Text;
            Computer computer = lsvBill.Tag as Computer;
            ComputerDAO.Instance.AddAccountToClient(account, computer.ID);
            if (computer == null)
            {
                MessageBox.Show("Should choose client first");
                return;
            }
            int idBill = BillDAO.Instance.GetUncheckBillIDbyComputerID(computer.ID);
            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(computer.ID);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill());
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill);
            }
            ShowBill(computer.ID);
            loadComputer();
        }

        private void CheckOutAccountbtn_Click(object sender, EventArgs e)
        {
            Computer computer = lsvBill.Tag as Computer;
            int idBill = BillDAO.Instance.GetUncheckBillIDbyComputerID(computer.ID);
            string query = " update dbo.Bill set time_left = GETDATE() where status = 0 and id_client = " + computer.ID + " and id = " + idBill;
            DataProvider.Instance.ExecuteNonQuery(query);
            DataProvider.Instance.ExecuteNonQuery("exec ToTalPriceForAccount " + computer.ID + "," + idBill);
            int discount = (int)nmrDiscount.Value;
            double totalprice1 = Convert.ToDouble(Totalpricetxt.Text.Split(',')[0].Replace(".", ""));
            double finaltotalprice = (totalprice1) - (totalprice1 * discount / 100);
            if (idBill != -1)
            {
                if (MessageBox.Show(string.Format("Are you sure check out for table {0} \n Total price is {1} with discount = {2} ", computer.Name, finaltotalprice, discount), "Notification", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill, discount);
                    ShowBill(computer.ID);
                    loadComputer();
                }
            }
        }

        #endregion

        private void cbSwap_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SMSForm s = new SMSForm();
            s.Show();
        }
    }
}