using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanNet.DTO
{
    public class Bill
    {
        public Bill(int id, TimeSpan timeStart, TimeSpan timeLeft, int status, int discount = 0, float Totalprice = 0 /*DateTime? timePlay*/)
        {
            this.Id = id;
            this.TimeStart = timeStart;
            this.TimeLeft = timeLeft;
            this.Status = status;
            this.Discount = discount;
            //this.TimePLay = timePlay;
            this.TotalPrice = Totalprice;
        }

        public Bill(DataRow row)
        {
            this.Id = (int)row["id"];
            var timeStartTemp = row["time_start"];
            if (timeStartTemp.ToString() != "")
                this.TimeStart = (TimeSpan)timeStartTemp;
            var timeLeftTemp = row["time_left"];
            if (timeLeftTemp.ToString() != "")
                this.TimeLeft = (TimeSpan)timeLeftTemp;

            this.Status = (int)row["status"];
            this.Discount = (int)row["discount"];
            var totalpriceTemp = row["Totalprice"];
            if (totalpriceTemp.ToString() != "")
                this.TotalPrice = (float)Convert.ToDouble(totalpriceTemp.ToString());
            //var timePLayTemp = row["timePlay"];
            //if (timePLayTemp.ToString() != "")
            //    this.TimePLay = (DateTime?)timePLayTemp;
        }

        private float totalPrice;
        private DateTime? timePLay;
        private int discount;
        private int status;
        private TimeSpan timeLeft;
        private TimeSpan timeStart;
        private int id;

        public int Id { get => id; set => id = value; }
        public int Status { get => status; set => status = value; }
        public int Discount { get => discount; set => discount = value; }
        public DateTime? TimePLay { get => timePLay; set => timePLay = value; }
        public TimeSpan TimeLeft { get => timeLeft; set => timeLeft = value; }
        public TimeSpan TimeStart { get => timeStart; set => timeStart = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
    }
}
