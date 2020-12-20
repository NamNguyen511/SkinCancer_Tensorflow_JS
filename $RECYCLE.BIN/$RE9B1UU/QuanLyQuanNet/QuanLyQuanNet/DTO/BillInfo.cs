using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanNet.DTO
{
    public class BillInfo
    {
        public BillInfo(int id, int billID, int foodID, int count)
        {
            this.ID = id;
            this.IdBill = billID;
            this.IdFood = foodID;
            this.Count = count;
        }

        public BillInfo(DataRow row)
        {
            this.ID = (int)row["id"];
            this.IdBill = (int)row["id_Bill"];
            this.IdFood = (int)row["id_Food"];
            this.Count = (int)row["Count"];
        }

        private int count;
        private int idFood;
        private int idBill;
        private int iD;

        public int ID { get => iD; set => iD = value; }
        public int IdBill { get => idBill; set => idBill = value; }
        public int IdFood { get => idFood; set => idFood = value; }
        public int Count { get => count; set => count = value; }
    }
}
