using QuanLyQuanNet.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanNet.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance 
        {
            get { if (instance == null) instance = new MenuDAO(); return MenuDAO.instance; }
            private set { MenuDAO.instance = value; }
        }

        private MenuDAO() { }

        public List<Menu> GetListMenuByComputer(int id)
        {
            List<Menu> listMenu = new List<Menu>();

            string query = "select f.name, Bi.Count, f.price ,f.price * Bi.Count as Totalprice from dbo.Bill b, dbo.BillInfo Bi, dbo.Food f, dbo.ClientCategory Cl, dbo.Client c where b.id = Bi.id_Bill and Bi.id_Food = f.id and b.status = 0 and b.id_Client = c.id and c.id_type = Cl.id and b.id_Client = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }
    }
}
