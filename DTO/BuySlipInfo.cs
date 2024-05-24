using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemVang.DTO
{
    public class BuySlipInfo
    {
        public BuySlipInfo(int slipID, int productID, int quan, float price, float total)
        {
            this.SlipID = slipID;
            this.ProductID = productID;
            this.Quanlity = quan;
            this.Price = price;
            this.Total = total;
        }

        public BuySlipInfo(DataRow row)
        {
            this.SlipID = Convert.ToInt32(row["MaPhieuMuaHang"]);
            this.ProductID = Convert.ToInt32(row["MaSanPham"]);
            this.Quanlity = Convert.ToInt32(row["SoLuong"]);
            this.Price = Convert.ToInt32(row["DonGia"]);
            this.Total = this.Price * this.Quanlity;
        }

        private int slipID;
        public int SlipID { get { return slipID; } set { slipID = value; } }

        private int productID;
        public int ProductID { get { return productID; } set { productID = value; } }

        private int quanlity;
        public int Quanlity { get { return quanlity; } set { quanlity = value; } }

        private float price;
        public float Price { get { return price; } set { price = value; } }

        private float total;
        public float Total { get { return total; } set { total = value; } }
    }
}
