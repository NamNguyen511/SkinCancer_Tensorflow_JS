using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanNet.DTO
{
    public class ClientCategory
    {
        public ClientCategory(int id, string type, float price)
        {
            this.ID = id;
            this.Type = type;
            this.Price = price;
        }

        public ClientCategory (DataRow row)
        {
            this.ID = (int)row["id"];
            this.Type = row["type_client"].ToString();
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
        }

        private float price;
        private string type;
        private int iD;

        public int ID { get => iD; set => iD = value; }
        public string Type { get => type; set => type = value; }
        public float Price { get => price; set => price = value; }
    }
}
