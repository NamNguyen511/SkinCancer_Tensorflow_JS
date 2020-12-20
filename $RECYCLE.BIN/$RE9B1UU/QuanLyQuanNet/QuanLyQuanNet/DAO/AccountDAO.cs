using QuanLyQuanNet.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanNet.DAO
{
    class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance 
        {
            get { if (instance == null) { instance = new AccountDAO(); } return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }

        public bool Login1(string username, string password)
        {
            
            string query = "QLQN_Login @username , @password";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password });

            return result.Rows.Count > 0;
        }

        public DataTable GetListAccount()
        {
            return DataProvider.Instance.ExecuteQuery("select username, displayname, type from dbo.Account");
        }

        public bool UpdateAccount(string username, string displayname, string pass, string newpass)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("execute UpdateAccount @username , @displayname , @password , @newpassword ", new object[] { username, displayname, pass, newpass });
            return result > 0;
        }

        public Account GetAccountByUsername(string username)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from dbo.Account where username = '" + username + "'");
            foreach(DataRow item in data.Rows)
                {
                    return new Account(item);
                }
            return null;
        }
      
        public bool InsertAccount(string name, int type, string displayname)
        {
            string query = string.Format("insert dbo.Account (username , displayname, type) values (N'{0}', N'{1}', {2})", name, displayname, type);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateAccount(int type, string displayname, string name)
        {
            string query = string.Format("update dbo.Account set displayname = N'{0}', type = {1} where username = N'{2}'", displayname, type, name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteAccount(string name)
        {

            string query = string.Format("delete dbo.Account where username = N'{0}'", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool ResetPassword (string username)
        {
            string query = string.Format("update dbo.Account set password = N'1' where username = N'{0}'", username);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
