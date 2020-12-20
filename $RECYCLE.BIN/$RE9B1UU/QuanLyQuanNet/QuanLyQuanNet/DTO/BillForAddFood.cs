using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanNet.DTO
{
    public class BillForAddFood
    {
        public BillForAddFood(int id, int status,DateTime? timeLeft ,int discount = 0)
        {
            this.id = id;
            this.Status = status;
            this.Discount = discount;
        }

        public BillForAddFood(DataRow row)
        {
            this.id = (int)row["id"];
            this.Status = (int)row["status"];
            this.Discount = (int)row["discount"];
        }

        private int discount;
        private int status;
        private int id;

        public int Id { get => id; set => id = value; }
        public int Status { get => status; set => status = value; }
        public int Discount { get => discount; set => discount = value; }
    }
}
