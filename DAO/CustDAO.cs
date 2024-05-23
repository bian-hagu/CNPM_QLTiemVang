using QLTiemVang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemVang.DAO
{
    public class CustDAO
    {
        private static CustDAO instance;

        public static CustDAO Instance
        {
            get { if (instance == null) instance = new CustDAO(); return instance; }
            private set { instance = value; }
        }

        private CustDAO() { }

        public DataTable Search(string text = " ")
        {
            string query = "USP_SearchCust N'%"+text+"%';";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

        public Cust GetCust(string id)
        {
            string query = "USP_GetCust " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            Cust cust = new Cust(data.Rows[0]);
            return cust;
        }

        public int CountCust()
        {
            string query = "select count(MaKhachHang) from KHACHHANG";

            object data = DataProvider.Instance.ExecuteScalar(query);
            int count = (int)data;

            return count;
        }

        public void InsertCust(Cust cust)
        {
            string query = "EXEC USP_InsertCust " + cust.ID.ToString() + ", N'" + cust.Name + "' , '" + cust.PhoneNum + "'";
            DataProvider.Instance.ExecuteNonQuery(query);
        }




    }

}