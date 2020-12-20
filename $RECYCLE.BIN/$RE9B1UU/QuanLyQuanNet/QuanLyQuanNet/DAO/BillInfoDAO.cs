using QuanLyQuanNet.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanNet.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance 
        {
            get { if (instance == null) instance = new BillInfoDAO(); return BillInfoDAO.instance; }
            private set { BillInfoDAO.instance = value; }
        }

        private BillInfoDAO() { }

        public List<BillInfo> GetListBillInfo(int id)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();


            DataTable data = DataProvider.Instance.ExecuteQuery("select * from dbo.BillInfo where id_Bill = " + id);
            foreach (DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                listBillInfo.Add(info);
            }

            return listBillInfo;
        }

        public void InsertBillInfo(int idBill)
        {
            DataProvider.Instance.ExecuteNonQuery("exec InsertBillInfo @idBill ", new object[] { idBill });
        }

        public void InsertFoodBillInfo(int idBill, int idFood, int Count)
        {
            DataProvider.Instance.ExecuteNonQuery("exec InsertFoodBillInfo @idBill , @idFood , @Count ", new object[] { idBill, idFood, Count });
        }

        public void DeleteBillInfoByFoodID(int id)
        {
            DataProvider.Instance.ExecuteQuery("delete dbo.BillInfo where id_Food = " + id);
        }
    }
}
