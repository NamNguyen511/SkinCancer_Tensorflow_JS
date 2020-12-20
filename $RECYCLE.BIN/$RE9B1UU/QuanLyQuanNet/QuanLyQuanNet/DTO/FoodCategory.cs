using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanNet.DTO
{
    public class FoodCategory
    {
        public FoodCategory(int id, string Name)
        {
            this.ID = id;
            this.Name1 = Name;
        }

        public FoodCategory(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name1 = row["name"].ToString();
        }

        private string Name;
        private int iD;

        public int ID { get => iD; set => iD = value; }
        public string Name1 { get => Name; set => Name = value; }
    }
}
