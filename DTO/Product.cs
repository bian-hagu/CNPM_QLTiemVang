using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemVang.DTO
{
    public class Product
    {

        public Product(int id,  string name, string type, string unit, float saleprice, float buyprice, decimal profits)
        {
            this.ID = id;
            this.Name = name;
            this.Type = type;
            this.Unit = unit;
            this.SalePrice = saleprice;
            this.BuyPrice = buyprice;
            this.profits = profits;
        }

        public Product(DataRow row)
        {
            this.ID = Convert.ToInt32(row["MaSanPham"]);
            this.Name = row["TenSanPham"].ToString();
            this.Type = row["LoaiSanPham"].ToString();
            this.Unit = row["DonViTinh"].ToString();
            this.SalePrice = Convert.ToInt32(row["DonGiaBan"]);
            this.BuyPrice = Convert.ToInt32(row["DonGiaMua"]);
            this.Profits = Convert.ToDecimal(row["PTLN"]);
        }

        private int iD;
        public int ID { get { return iD; } set { iD=value; } }

        private string name;
        public string Name { get { return name; } set { name=value; } }

        private string type;
        public string Type { get { return type; } set { type=value; } }

        private string unit;
        public string Unit { get { return unit; } set  { unit=value; } }

        private float salePrice;
        public float SalePrice { get { return salePrice; } set { salePrice=value; } }

        private float buyPrice;
        public float BuyPrice { get { return buyPrice; } set {  buyPrice=value; } }

        private decimal profits;
        public decimal Profits { get {  return profits; } set {  profits=value; } }
    }
}
