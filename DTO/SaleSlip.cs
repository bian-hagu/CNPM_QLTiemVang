using QLTiemVang.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemVang.DTO
{
    public class SaleSlip
    {
        public SaleSlip(int id, int cust, string date)
        {
            this.ID = id;
            this.custID = cust;
            this.date = date;
        }
        public SaleSlip()
        {
            this.ID = 0;
            this.custID = 0;
            this.date = "";
        }

        public SaleSlip(DataRow row)
        {
            this.ID = Convert.ToInt32(row["MaPhieuBanHang"]);
            this.CustID = Convert.ToInt32(row["MaKhachhang"]);
            this.Date = row["NgayLap"].ToString();
        }

        private int iD;
        public int ID { get {  return iD; } set {  iD = value; } }

        private int custID;
        public int CustID { get {  return custID; } set {  custID = value; } }

        private string date;
        public string Date { get { return date; } set { date = value; } }

    }

}
