using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemVang.DTO
{
    public class ServiceSlipInfo
    {
        public ServiceSlipInfo(
            int slipID = 0,
            int serID = 0,
            int quan = 0,
            float price = 0,
            float other = 0,
            float total = 0,
            float prepay = 0,
            float remain = 0,
            string deliver = "",
            string status = "")
        {
            this.SlipID = slipID;
            this.SerID = serID;
            this.Quanlity = quan;
            this.Price = price;
            this.OtherPrice = other;
            this.Total = total;
            this.Prepay = prepay;
            this.Remain = remain;
            this.DeliverDay = deliver;
            this.Status = status;
        }

        public ServiceSlipInfo(DataRow row)
        {
            this.SlipID = Convert.ToInt32(row["MaPhieuDichVu"]);
            this.SerID = Convert.ToInt32(row["MaDichVu"]);
            this.Quanlity = Convert.ToInt32(row["SoLuong"]);
            this.Price = Convert.ToInt32(row["DonGiaTinh"]);
            this.OtherPrice = Convert.ToInt32(row["ChiPhiRieng"]);
            this.Total = Convert.ToInt32(row["ThanhTien"]);
            this.Prepay = Convert.ToInt32(row["TraTruoc"]);
            this.Remain = Convert.ToInt32(row["ConLai"]);
            this.DeliverDay = row["NgayGiao"].ToString();
            this.Status = row["TinhTrang"].ToString();
        }

        private int slipID;
        public int SlipID { get { return slipID; } set { slipID = value; } }

        private int serID;
        public int SerID { get { return serID; } set { serID = value; } }

        private int quanlity;
        public int Quanlity { get { return quanlity; } set { quanlity = value; } }

        private float price;
        public float Price { get { return price; } set { price = value; } }

        private float otherPrice;
        public float OtherPrice { get { return otherPrice; } set { otherPrice = value; } }

        private float total;
        public float Total { get { return total; } set { total = value; } }

        private float prepay;
        public float Prepay { get { return prepay; } set { prepay = value; } }

        private float remain;
        public float Remain { get { return remain;  } set { remain = value; } }

        private string deliverDay;
        public string DeliverDay { get { return deliverDay; } set { deliverDay = value; } }

        private string status;
        public string Status { get { return status; } set { status = value; } }
    }
}
