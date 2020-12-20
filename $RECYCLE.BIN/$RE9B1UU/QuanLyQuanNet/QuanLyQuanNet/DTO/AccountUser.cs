using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanNet.DTO
{
    public class AccountUser
    {

        public AccountUser (int id,string username, string pass, float money, string note)
        {
            this.ID = id;
            this.UserName = username;
            this.PassWord = pass;
            this.Money = money;
            this.Note = note;
        }

        public AccountUser (DataRow row)
        {
            this.ID = (int)row["id"];
            this.UserName = row["username"].ToString();
            this.PassWord = row["password"].ToString();
            var money = row["money"];
            if(money.ToString() != "")
                this.Money = (float)Convert.ToDouble(money.ToString());
            this.Note = row["note"].ToString();
        }

        private string userName;
        private string passWord;
        private float money;
        private string note;
        private int iD;

        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public float Money { get => money; set => money = value; }
        public string Note { get => note; set => note = value; }
        public int ID { get => iD; set => iD = value; }
    }
}
