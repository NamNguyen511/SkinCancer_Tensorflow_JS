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
    public partial class Admin : Form
    {
        BindingSource foodlist = new BindingSource();
        BindingSource clientlist = new BindingSource();
        BindingSource accountlist = new BindingSource();

        public Account loginAccount;
        public Admin()
        {
            InitializeComponent();
            Load();
        }

        #region methods

        void Load()
        {
            dgvFood.DataSource = foodlist;
            dgvComputer.DataSource = clientlist;
            dgvAccount.DataSource = accountlist;
            LoadListBillPlay();
            LoadListBillFood();
            LoadListFood();
            LoadListClient();
            AddFoodBinding();
            AddClientBinding();
            AddAccountBinding();
            LoadCategorytoCombobox();
            LoadTypeClient();
            LoadAccount();
        }

        void LoadAccount()
        {
            accountlist.DataSource = AccountDAO.Instance.GetListAccount();
        }
        
        void AddAccountBinding ()
        {
            txtUsernameAccount.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "username", true, DataSourceUpdateMode.Never));
            txtDisplayNameAccount.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "displayname", true, DataSourceUpdateMode.Never));
            nmrType.DataBindings.Add(new Binding("Value", dgvAccount.DataSource, "type", true, DataSourceUpdateMode.Never));
        }
        void LoadListBillPlay()
        {
            dgvBillPlay.DataSource = BillDAO.Instance.GetBillPlay();
        }

        void LoadListBillFood()
        {
            dgvBillFood.DataSource = BillDAO.Instance.GetBillFood();
        }

        void LoadListFood()
        {
            foodlist.DataSource = FoodDAO.Instance.GetListFood();
        }

        void LoadListClient()
        {
            clientlist.DataSource = ComputerDAO.Instance.LoadComputerList();
        }

        void AddClientBinding()
        {
            txtIdComputer.DataBindings.Add(new Binding("Text", dgvComputer.DataSource, "id", true, DataSourceUpdateMode.Never));
            txtNameComputer.DataBindings.Add(new Binding("Text", dgvComputer.DataSource, "name", true, DataSourceUpdateMode.Never));
            txtstatus.DataBindings.Add(new Binding("Text", dgvComputer.DataSource, "status", true, DataSourceUpdateMode.Never));
        }
        void AddFoodBinding()
        {
            txtFoodName.DataBindings.Add(new Binding("Text", dgvFood.DataSource,"name",true,DataSourceUpdateMode.Never));
            txtIdFood.DataBindings.Add(new Binding("Text", dgvFood.DataSource, "id", true, DataSourceUpdateMode.Never));
            nmrFoodPrice.DataBindings.Add(new Binding("Value", dgvFood.DataSource, "price", true, DataSourceUpdateMode.Never));
        }

        void LoadCategorytoCombobox()
        {
            List<FoodCategory> listcategory = FoodCategoryDAO.Instance.GetListCategory();
            cbFoodCategory.DataSource = listcategory;
            cbFoodCategory.DisplayMember = "Name1";
        }

        void LoadTypeClient()
        {
            List<ClientCategory> listtype = ClientCategoryDAO.Instance.GetListClientCategories();
            cbTypeClient.DataSource = listtype;
            cbTypeClient.DisplayMember = "Type";
        }

        List<Food> SearchFoodByName(string name)
        {
            List<Food> listfood = FoodDAO.Instance.SearchFoodByName(name);
            return listfood;
        }

        void AddAccount (string username, string displayname, int type)
        {
            if(AccountDAO.Instance.InsertAccount(username, type, displayname))
            {
                MessageBox.Show("Add account complete");
            }
            else
            {
                MessageBox.Show("Error");
            }
            LoadAccount();
        }

        void ModifyAccount(string displayname, int type, string name)
        {
            if (AccountDAO.Instance.UpdateAccount(type, displayname, name))
            {
                MessageBox.Show("Modify account complete");
            }
            else
            {
                MessageBox.Show("Error");
            }
            LoadAccount();
        }

        void DeleteAccount(string name)
        {
            if(loginAccount.UserName.Equals(name))
            {
                MessageBox.Show("Please do not delete yourself");
                return;
            }
            if (AccountDAO.Instance.DeleteAccount(name))
            {
                MessageBox.Show("Delete account complete");
            }
            else
            {
                MessageBox.Show("Error");
            }
            LoadAccount();
        }

        void ResetPass(string name)
        {
            if (AccountDAO.Instance.ResetPassword(name))
            {
                MessageBox.Show("Reset password complete");
            }
            else
            {
                MessageBox.Show("Error");
            }
            LoadAccount();
        }
        #endregion

        #region events
        private void checkbillplaybtn_Click(object sender, EventArgs e)
        {
            LoadListBillPlay();
        }

        private void checkbillfoodbtn_Click(object sender, EventArgs e)
        {
            LoadListBillFood();
        }

        private void btnViewFood_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }

        private void txtIdFood_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvFood.SelectedCells.Count > 0)
                {
                    int id = (int)dgvFood.SelectedCells[0].OwningRow.Cells["CategoryID1"].Value;

                    FoodCategory category = FoodCategoryDAO.Instance.GetCategoryById(id);

                    cbFoodCategory.SelectedItem = category;

                    int index = -1;
                    int i = 0;
                    foreach (FoodCategory item in cbFoodCategory.Items)
                    {
                        if (item.ID == category.ID)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }
                    cbFoodCategory.SelectedIndex = index;
                }
            }
            catch { }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            string name = txtFoodName.Text;
            int categoryID = (cbFoodCategory.SelectedItem as FoodCategory).ID;
            float price = (float)nmrFoodPrice.Value;

            if (FoodDAO.Instance.InsertFood(name, categoryID, price))
            {
                MessageBox.Show("Add food complete");
                LoadListFood();
            }

            else
            {
                MessageBox.Show("Error!!");
            }
        }

        private void btnModifyFood_Click(object sender, EventArgs e)
        {
            string name = txtFoodName.Text;
            int categoryID = (cbFoodCategory.SelectedItem as FoodCategory).ID;
            float price = (float)nmrFoodPrice.Value;
            int id = Convert.ToInt32(txtIdFood.Text);

            if (FoodDAO.Instance.UpdateFood(name, categoryID, price, id))
            {
                MessageBox.Show("Modify food complete");
                LoadListFood();
            }

            else
            {
                MessageBox.Show("Error!!");
            }
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIdFood.Text);

            if (FoodDAO.Instance.DeleteFood(id))
            {
                MessageBox.Show("Delete food complete");
                LoadListFood();
            }

            else
            {
                MessageBox.Show("Error!!");
            }
        }

        private void btnViewComputer_Click(object sender, EventArgs e)
        {
            LoadListClient();
        }

        private void txtIdComputer_TextChanged(object sender, EventArgs e)
        {
            if (dgvComputer.SelectedCells.Count > 0)
            {
                int id = (int)dgvComputer.SelectedCells[0].OwningRow.Cells["id_type"].Value;

                ClientCategory category = ClientCategoryDAO.Instance.GetCategoryById(id);

                cbTypeClient.SelectedItem = category;

                int index = -1;
                int i = 0;
                foreach (ClientCategory item in cbTypeClient.Items)
                {
                    if (item.ID == category.ID)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }
                cbTypeClient.SelectedIndex = index;
            }
        }

        private void btnAddComputer_Click(object sender, EventArgs e)
        {
            string name = txtNameComputer.Text;
            int categoryID = (cbTypeClient.SelectedItem as ClientCategory).ID;

            if (ComputerDAO.Instance.InsertComputer(name, categoryID))
            {
                MessageBox.Show("Add Computer complete");
                LoadListFood();
            }

            else
            {
                MessageBox.Show("Error!!");
            }
        }

        private void btnmodifyComputer_Click(object sender, EventArgs e)
        {
            string name = txtNameComputer.Text;
            int categoryID = (cbTypeClient.SelectedItem as ClientCategory).ID;
            int id = Convert.ToInt32(txtIdComputer.Text);

            if (ComputerDAO.Instance.UpdateComputer(name, categoryID, id))
            {
                MessageBox.Show("Modify computer complete");
                LoadListFood();
            }

            else
            {
                MessageBox.Show("Error!!");
            }
        }

        private void btndeleteComputer_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIdComputer.Text);

            if (ComputerDAO.Instance.DeleteComputer(id))
            {
                MessageBox.Show("Delete computer complete");
                LoadListFood();
            }

            else
            {
                MessageBox.Show("Error!!");
            }
        }

        private void btnSearchFood_Click(object sender, EventArgs e)
        {
            foodlist.DataSource = SearchFoodByName(txtSearchFood.Text);
        }

        private void btnViewAccount_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string username = txtUsernameAccount.Text;
            string displayname = txtDisplayNameAccount.Text;
            int type = (int)nmrType.Value;
            AddAccount(username, displayname,type);
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            string username = txtUsernameAccount.Text;
            DeleteAccount(username);
        }

        private void btnModifyAccount_Click(object sender, EventArgs e)
        {
            string username = txtUsernameAccount.Text;
            string displayname = txtDisplayNameAccount.Text;
            int type = (int)nmrType.Value;
            ModifyAccount(displayname, type, username);
        }

        #endregion

        private void btnResetPassAccount_Click(object sender, EventArgs e)
        {
            string username = txtUsernameAccount.Text;
            ResetPass(username);
        }
    }
}
