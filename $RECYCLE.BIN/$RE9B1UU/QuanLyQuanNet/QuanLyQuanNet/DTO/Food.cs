using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanNet.DTO
{
    public class Food
    {
        public Food(int id, string name, int CategoryID, float price)
        {
            this.ID = id;
            this.Name = name;
            this.CategoryID1 = CategoryID;
            this.price = price;
        }

        public Food(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.CategoryID1 = (int)row["id_category"];
            this.price = (float)Convert.ToDouble(row["price"].ToString());
        }

        private float price;
        private int CategoryID;
        private string name;
        private int iD;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public int CategoryID1 { get => CategoryID; set => CategoryID = value; }
        public float Price { get => price; set => price = value; }
    }
}
