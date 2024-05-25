using QLTiemVang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemVang.DAO
{
    public class SaleSlipInfoDAO
    {
        private static SaleSlipInfoDAO instance;

        public static SaleSlipInfoDAO Instance
        {
            get { if (instance == null) instance = new SaleSlipInfoDAO(); return instance; }
            private set { instance = value; }
        }

        private SaleSlipInfoDAO() { }

        public List<SaleSlipInfo> GetListSaleSlipInfo(string id)
        {
            List<SaleSlipInfo> listSaleSlipInfo = new List<SaleSlipInfo>();

            string query = "SELECT * FROM SANPHAM_BAN WHERE MaPhieuBanHang = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                SaleSlipInfo info = new SaleSlipInfo(item);
                listSaleSlipInfo.Add(info);
            }

            return listSaleSlipInfo;
        }

        public void InsertSaleSlipInfo(SaleSlipInfo saleSlipInfo)
        {   
            string query = "EXEC USP_InsertSaleSlipInfo @SLIP_ID , @PRODUCT_ID , @QUAN , @PRICE , @TOTAL ";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] {saleSlipInfo.SlipID, saleSlipInfo.ProductID, saleSlipInfo.Quanlity, saleSlipInfo.Price, saleSlipInfo.Total});
        }


    }
}
