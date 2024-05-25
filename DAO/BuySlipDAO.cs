using QLTiemVang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace QLTiemVang.DAO
{
    public class BuySlipDAO
    {
        private static BuySlipDAO instance;

        public static BuySlipDAO Instance
        {
            get { if (instance == null) instance = new BuySlipDAO(); return instance; }
            private set { instance = value; }
        }

        private BuySlipDAO() { }

        public int CountBuySlip()
        {
            string query = "SELECT COUNT(*) FROM PHIEUMUAHANG";

            object data = DataProvider.Instance.ExecuteScalar(query);
            int count = (int)data;

            return count;
        }

        public void InsertBuySlip(BuySlip buySlip)
        {
            string query = "EXEC USP_InsertBuySlip @SLIPID , @SUPID  , @DATE ";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { buySlip.ID, buySlip.SupplierID , buySlip.Date});
        }

        public int GetBuySlipID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM PHIEUMUAHANG WHERE MaPhieuMuaHang =" + id);
            
            if (data.Rows.Count > 0)
            {
                BuySlip buySlip = new BuySlip(data.Rows[0]);
                return buySlip.ID;
            }

            return -1;
        }


    }
}
