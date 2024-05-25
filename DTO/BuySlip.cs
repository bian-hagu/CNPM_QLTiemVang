using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemVang.DTO
{
    public class BuySlip
    {
        public BuySlip(int id, int supplier, string date, string address, string phone)
        {
            this.ID = id;
            this.SupplierID = supplier;
            this.date = date;
            this.Address = address;
            this.Phone = phone;
        }
        public BuySlip()
        {
            this.ID = 0;
            this.SupplierID = 0;
            this.date = "";
        }

        public BuySlip(DataRow row)
        {
            this.ID = Convert.ToInt32(row["MaPhieuMuaHang"]);
            this.SupplierID = Convert.ToInt32(row["MaNhaCungCap"]);
            this.Date = row["NgayLap"].ToString(); 
        }

        private int iD;
        public int ID { get { return iD; } set { iD = value; } }

        private int supplierID;
        public int SupplierID { get { return supplierID; } set { supplierID = value; } }

        private string date;
        public string Date { get { return date; } set { date = value; } }

        private string address;
        public string Address { get { return address; } set { address = value; } }

        private string phone;
        public string Phone { get { return phone; } set { phone = value; } }

    }
}
