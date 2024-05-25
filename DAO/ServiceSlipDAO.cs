using QLTiemVang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemVang.DAO
{
    internal class ServiceSlipDAO
    {
        private static ServiceSlipDAO instance;

        public static ServiceSlipDAO Instance
        {
            get { if (instance == null) instance = new ServiceSlipDAO(); return instance; }
            private set { instance = value; }
        }

        private ServiceSlipDAO() { }

        public DataTable Search(string text = " ")
        {
            string query = "EXEC USP_SearchServiceSlip N'%"+text+"%';";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

        public List<SaleSlip> GetListSaleSlipInfo(string id)
        {
            List<SaleSlip> listSaleSlip = new List<SaleSlip>();

            string query = "SELECT * FROM SANPHAM_BAN WHERE MaPhieuBanHang = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                SaleSlip info = new SaleSlip(item);
                listSaleSlip.Add(info);
            }

            return listSaleSlip;
        }







        public int CountSerSlip()
        {
            string query = "SELECT COUNT(*) FROM PHIEUDICHVU";

            object data = DataProvider.Instance.ExecuteScalar(query);
            int count = (int)data;

            return count;
        }

        public void InsertSerSlip(ServiceSlip serviceSlip)
        {
            string query = "EXEC USP_InsertSerSlip @SLIPID , @CUSTID , @DATE , @TOTAL , @PREPAY , @REMAIN , @STATUS ";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { serviceSlip.ID, serviceSlip.CustID, serviceSlip.Date, serviceSlip.Total, serviceSlip.TotalPrepay, serviceSlip.TotalRemain, serviceSlip.Status });
        }

        public int GetSerSlipID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM PHIEUDICHVU WHERE MaPhieuDichVu =" + id);

            if (data.Rows.Count > 0)
            {
                ServiceSlip serviceSlip = new ServiceSlip(data.Rows[0]);
                return serviceSlip.ID;
            }

            return -1;
        }
    }
}
