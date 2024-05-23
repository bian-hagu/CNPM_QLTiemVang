using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemVang.DTO
{
    public class Cust
    {
        public Cust(int id = 0, string name="", string phone="")
        {
            this.ID = id;
            this.Name = name;
            this.PhoneNum = phone;
        }

        public Cust(DataRow row)
        {
            this.ID = Convert.ToInt32(row["MaKhachHang"]);
            this.Name = row["Name"].ToString();
            this.PhoneNum = row["Phone"].ToString();
        }


        private int iD;
        public int ID { get { return iD; } set { iD = value; } }

        private string name;
        public string Name { get { return name; } set { name = value; } }

        private string phoneNum;
        public string PhoneNum { get {  return phoneNum; } set {  phoneNum = value; } }

    }
}
