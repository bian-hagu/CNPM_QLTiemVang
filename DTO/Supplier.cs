using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemVang.DTO
{
    public class Supplier
    {
        public Supplier(int id = 0, string name = "", string address = "", string phone = "")
        {
            this.ID = id;
            this.Name = name;
            this.Address = address;
            this.PhoneNum = phone;
        }

        public Supplier(DataRow row)
        {
            this.ID = Convert.ToInt32(row["MaNhaCungCap"]);
            this.Name = row["TenNhaCungCap"].ToString();
            this.Address = row["DiaChi"].ToString();
            this.PhoneNum = row["SDT"].ToString();
        }


        private int iD;
        public int ID { get { return iD; } set { iD = value; } }

        private string name;
        public string Name { get { return name; } set { name = value; } }

        private string phoneNum;
        public string PhoneNum { get { return phoneNum; } set { phoneNum = value; } }

        private string address;
        public string Address { get { return address; } set { address = value; } }
    }
}
