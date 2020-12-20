using QuanLyQuanNet.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanNet.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance 
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }

        private BillDAO() { }

        public int GetUncheckBillIDbyComputerID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from dbo.Bill where id_Client = " + id + " and status = 0");

            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.Id;

            }

            return -1;
        }

        public int InsertFoodintoBillbyComputerID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select id,id_client,status,discount,time_left from dbo.Bill where id_Client = " + id + " and status = 0");
            BillForAddFood bill = new BillForAddFood(data.Rows[0]);
            return bill.Id;
        }

        public float TotalPrice(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from dbo.Bill where id = " + id);
            Bill bill = new Bill(data.Rows[0]);
            return bill.TotalPrice;
        }

        public void CheckOut(int id, int discount)
        {
            string query = "Update dbo.Bill Set status = 1," + "discount = " + discount + " where id =  " + id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        
        public int TakeIdBillbyComputerID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select id from dbo.Bill where id_Client = " + id + " and status = 0");
            Bill bill = new Bill(data.Rows[0]);
            return bill.Id;
        }

        public void InsertBill(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("exec InsertBill @idTable", new object[] { id });
        }

        public int GetMaxIDBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("select MAX(id) from dbo.Bill ");
            }
            catch
            {
                return 1;
            }
        }

        public DateTime? GetTimePLay(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select *,DATEDIFF(HOUR,time_start,time_left) as timePlay from dbo.Bill where id = " + id);
            Bill bill = new Bill(data.Rows[0]);
            return bill.TimePLay;
        }

        public float GetTotalPrice(int idClient, int idBill)
        {
            return (float)DataProvider.Instance.ExecuteNonQuery("exec CalTotalPrice @idClient , @idBill ", new object[] { idClient, idBill });
        }

        public DataTable GetBillPlay()
        {
            return DataProvider.Instance.ExecuteQuery("execute GetListBillPlay");
        }

        public DataTable GetBillFood()
        {
            return DataProvider.Instance.ExecuteQuery("execute GetListBillFood");
        }

        public void DeleteBillByClientID(int id)
        {
            DataProvider.Instance.ExecuteQuery("delete dbo.Bill where id_Client = " + id);
        }
    }
}
