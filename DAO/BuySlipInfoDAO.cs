using QLTiemVang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemVang.DAO
{
    public class BuySlipInfoDAO
    {
        private static BuySlipInfoDAO instance;

        public static BuySlipInfoDAO Instance
        {
            get { if (instance == null) instance = new BuySlipInfoDAO(); return instance; }
            private set { instance = value; }
        }

        private BuySlipInfoDAO() { }

        public List<BuySlipInfo> GetListBuySlipInfo(string id)
        {
            List<BuySlipInfo> listBuySlipInfo = new List<BuySlipInfo>();

            string query = "SELECT * FROM SANPHAM_MUA WHERE MaPhieuMuaHang = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                BuySlipInfo info = new BuySlipInfo(item);
                listBuySlipInfo.Add(info);
            }

            return listBuySlipInfo;
        }

        public void InsertBuySlipInfo(BuySlipInfo BuySlipInfo)
        {
            string query = "EXEC USP_InsertBuySlipInfo @SLIP_ID , @PRODUCT_ID , @QUAN , @PRICE , @TOTAL ";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { BuySlipInfo.SlipID, BuySlipInfo.ProductID, BuySlipInfo.Quanlity, BuySlipInfo.Price, BuySlipInfo.Total });
        }



    }
}
