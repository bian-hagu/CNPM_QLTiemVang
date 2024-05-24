using QLTiemVang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemVang.DAO
{
    public class SupplierDAO
    {
        private static SupplierDAO instance;
        public static SupplierDAO Instance
        {
            get { if (instance == null) instance = new SupplierDAO(); return instance; }
            private set { instance = value; }
        }

        private SupplierDAO() { }

        public DataTable Search(string text = " ")
        {
            string query = "USP_SearchSupplier N'%"+text+"%';";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

        //public Supplier GetSupplier(string id)
        //{
        //    string query = "USP_GetSupplier " + id;
        //    DataTable data = DataProvider.Instance.ExecuteQuery(query);
        //    Supplier Supplier = new Supplier(data.Rows[0]);
        //    return Supplier;
        //}

        public int CountSupplier()
        {
            string query = "select count(MaNhaCungCap) from NHACUNGCAP";

            object data = DataProvider.Instance.ExecuteScalar(query);
            int count = (int)data;

            return count;
        }

        public void InsertSupplier(Supplier Supplier)
        {
            string query = "EXEC USP_InsertSupplier " + Supplier.ID.ToString() + ", N'" + Supplier.Name + "' , N'" + Supplier.Address + "' , '" + Supplier.PhoneNum + "'";
            DataProvider.Instance.ExecuteNonQuery(query);
        }

    }
}
