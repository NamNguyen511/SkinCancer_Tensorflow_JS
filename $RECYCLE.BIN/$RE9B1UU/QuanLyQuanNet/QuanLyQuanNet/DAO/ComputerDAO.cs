using QuanLyQuanNet.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanNet.DAO
{
    public class ComputerDAO
    {
        private static ComputerDAO instance;

        public static ComputerDAO Instance 
        {
            get { if (instance == null) instance = new ComputerDAO(); return ComputerDAO.instance; }
            private set { ComputerDAO.instance = value; }
        }

        public static int ComputerWidth = 90;
        public static int ComputerHeight = 90;

        private ComputerDAO() { }

        public List<Computer> LoadComputerList()
        {
            List<Computer> computerList = new List<Computer>();

            DataTable data = DataProvider.Instance.ExecuteQuery("QLQN_CLientList");

            foreach (DataRow item in data.Rows)
            {
                Computer computer = new Computer(item);
                computerList.Add(computer);
            }

            return computerList;
        }

        public void SwapClient(int id1, int id2)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SwapClient @idClient1 , @idClient2", new object[] { id1, id2 });

        }

        public bool InsertComputer(string name, int id)
        {
            string query = string.Format("insert dbo.Client (name , id_type, status) values (N'{0}', {1}, N'Trong')", name, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateComputer(string name, int idcategory, int id)
        {
            string query = string.Format("update dbo.Client set name = N'{0}', id_type = {1}, status = N'Trong' where id = {2}", name, idcategory, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteComputer(int id)
        {
            BillDAO.Instance.DeleteBillByClientID(id);
            string query = string.Format("delete dbo.Client where id = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public void AddAccountToClient (string username, int idClient)
        {
            DataProvider.Instance.ExecuteNonQuery("AddPlayerToClient @username , @idClient", new object[] { username, idClient });
        }

       

    }
}
