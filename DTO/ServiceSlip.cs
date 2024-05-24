using System;
using System.Collections.Generic;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLTiemVang.DTO
{
    public class ServiceSlip
    {
        public ServiceSlip(int id = 0, int custid = 0, string date = "", float total = 0, float prepay = 0, float remain = 0, string status = "")
        {
            this.ID = id;
            this.custID = custid;
            this.Date = date;
            this.Total = total;
            this.TotalPrepay = prepay;
            this.totalRemain = remain;
            this.Status = status;
        }
        public ServiceSlip(DataRow row)
        {
            this.ID = Convert.ToInt32(row["MaPhieuDichVu"]);
            this.custID = Convert.ToInt32(row["MaKhachHang"]);
            this.Date = row["NgayLap"].ToString();
            this.Total = Convert.ToInt32(row["TongTien"]);
            this.TotalPrepay = Convert.ToInt32(row["TongTraTruoc"]);
            this.totalRemain = Convert.ToInt32(row["TongConLai"]);
            this.Status = row["TinhTrangChung"].ToString();
        }

        private int iD;
        public int ID { get {  return iD; } set { iD = value; } }

        private int custID;
        public int CustID { get {  return custID; } set {  custID = value; } }

        private string date;
        public string Date { get { return date; } set { date = value; } }

        private float totalPrepay;
        public float TotalPrepay { get { return totalPrepay; } set { totalPrepay = value; } }

        private float total;
        public float Total { get {  return total; } set { total = value; } }

        private float totalRemain;
        public float TotalRemain { get {  return totalRemain; } set { totalRemain = value; } }

        private string status;
        public string Status { get { return status; } set { status = value; } }
    }
}
