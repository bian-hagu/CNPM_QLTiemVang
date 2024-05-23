using QLTiemVang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace QLTiemVang.DAO
{
    public class SaleSlipDAO
    {
        private static SaleSlipDAO instance;

        public static SaleSlipDAO Instance
        {
            get { if (instance == null) instance = new SaleSlipDAO(); return instance; }
            private set { instance = value; }
        }

        private SaleSlipDAO() { }

        public int CountSaleSlip()
        {
            string query = "select Count(MaPhieuMuaHang) from PHIEUMUAHANG";

            object data = DataProvider.Instance.ExecuteScalar(query);
            int count = (int)data;

            return count;
        }

        public void InsertSaleSlip(SaleSlip saleSlip)
        {
            string query = "EXEC USP_InsertSaleSlip @ID , @DATE ";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] {saleSlip.CustID , saleSlip.Date});
        }

        public int GetSaleSlipID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM PHIEUBANHANG WHERE MaPhieuBanHang =" + id);

            if (data.Rows.Count > 0)
            {
                SaleSlip saleSlip = new SaleSlip(data.Rows[0]);
                return saleSlip.ID;
            }

            return -1;
        }


    }
}
