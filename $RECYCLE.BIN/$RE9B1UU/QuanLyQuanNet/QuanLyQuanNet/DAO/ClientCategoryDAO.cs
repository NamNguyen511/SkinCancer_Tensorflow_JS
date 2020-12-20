using QuanLyQuanNet.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanNet.DAO
{
    public class ClientCategoryDAO
    {
        private static ClientCategoryDAO instance;

        public static ClientCategoryDAO Instance 
        {
            get { if (instance == null) instance = new ClientCategoryDAO(); return ClientCategoryDAO.instance; }
            private set { ClientCategoryDAO.instance = value; }
        }

        private ClientCategoryDAO() { }

        public List<ClientCategory> GetListClientCategories()
        {
            List<ClientCategory> list = new List<ClientCategory>();

            string query = "Select * from ClientCategory ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ClientCategory category = new ClientCategory(item);
                list.Add(category);
            }

            return list;
        }

        public ClientCategory GetCategoryById(int id)
        {
            ClientCategory category = null;

            string query = "Select * from ClientCategory where id = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                category = new ClientCategory(item);
                return category;
            }

            return category;
        }
    }
}
