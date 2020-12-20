using QuanLyQuanNet.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanNet.DAO
{
    public class FoodCategoryDAO
    {
        private static FoodCategoryDAO instance;

        public static FoodCategoryDAO Instance 
        {
            get { if (instance == null) instance = new FoodCategoryDAO(); return FoodCategoryDAO.instance; }
            private set { FoodCategoryDAO.instance = value; }
        }

        private FoodCategoryDAO() { }

        public List<FoodCategory> GetListCategory()
        {
            List<FoodCategory> list = new List<FoodCategory>();

            string query = "Select * from FoodCategory ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                FoodCategory category = new FoodCategory(item);
                list.Add(category);
            }

            return list;
        }

        public FoodCategory GetCategoryById(int id)
        {
            FoodCategory category = null;

            string query = "Select * from FoodCategory where id = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                category = new FoodCategory(item);
                return category;
            }

            return category;
        }
    }
}
