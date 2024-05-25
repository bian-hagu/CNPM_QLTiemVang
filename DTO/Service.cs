using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemVang.DTO
{
    public class Service
    {
        public Service(int id = 0, string name = "", float price = 0, float prepayRate = 0)
        {
            this.ID = id;
            this.Name = name;
            this.Price = price;
            this.PrepayRate=prepayRate;

        }

        public Service(DataRow row)
        {
            this.ID = Convert.ToInt32(row["MaDichVu"]);
            this.Name = row["LoaiDichVu"].ToString();
            this.Price = Convert.ToInt32(row["DonGia"]);
            this.PrepayRate = Convert.ToInt32(row["TyLeTraTruoc"]);
        }

        private int iD;
        public int ID { get { return iD; } set { iD = value; } }

        private string name;
        public string Name { get { return name; } set { name = value; } }

        private float price;
        public float Price { get { return price; } set { price = value; } }

        private float prepayRate;
        public float PrepayRate { get {  return prepayRate; } set {  prepayRate = value; } }
    }
}
