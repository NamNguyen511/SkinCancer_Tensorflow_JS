using QuanLyQuanNet.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanNet.DAO
{
    public class AccountPlayerDAO
    {
        private static AccountPlayerDAO instance;

        public static AccountPlayerDAO Instance 
        {
            get { if (instance == null) { instance = new AccountPlayerDAO(); } return instance; }
            private set { instance = value; }
        }

        private AccountPlayerDAO() { }
      
        public bool LoginPlayer(string username, string password, int idClient)
        {

            string query = "AddACCPlayerToClient @username , @password , @idClient  ";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password,idClient });

            return result.Rows.Count > 0;
        }
        public DataTable GetListAccountPlayer()
        {
            return DataProvider.Instance.ExecuteQuery("select * from dbo.AccountPlayer");
        }
        public AccountUser GetAccountPlayerByUsername(string username)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from dbo.AccountPlayer where username = '" + username + "'");
            foreach(DataRow item in data.Rows)
            {
                return new AccountUser(item);
            }
            return null;
        }

        public bool InsertAccount(string name, float money, string note, string pass)
        {
            string query = string.Format("insert dbo.AccountPlayer (username , password, money, note) values (N'{0}', N'{1}', {2}, N'{3}')", name, pass, money, note);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateAccount(float money, int id)
        {
            string query = string.Format("update dbo.AccountPlayer set money = money + {0} where id = {1}", money, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteAccount(int id)
        {
            string query = string.Format("delete dbo.AccountPlayer where id = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool ResetPass(int id)
        {
            string query = string.Format("Update dbo.AccountPlayer set password = 1 where id = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
