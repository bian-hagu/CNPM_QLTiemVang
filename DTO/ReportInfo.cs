using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemVang.DTO
{
    public class ReportInfo
    {
        public ReportInfo(int id, int productid, int pre, int input, int output, int left)
        {
            this.ID = id;
            this.ProductID = productid;
            this.PreLeft = pre;
            this.Input = input;
            this.Output = output;
            this.Left = left;
        }
        public ReportInfo(DataRow row)
        {
            this.ID = Convert.ToInt32(row["MaBCTK"]);
            this.ProductID = Convert.ToInt32(row["MaKhachHang"]);
            this.PreLeft = Convert.ToInt32(row["TonDau"]);
            this.Input = Convert.ToInt32(row["SoLuongMuaVao"]);
            this.Output = Convert.ToInt32(row["SoLuongBanRa"]);
            this.Left = Convert.ToInt32(row["TonCuoi"]);
        }


        private int iD;
        public int ID { get { return iD; } set { iD = value; } }

        private int productID;
        public int ProductID { get {  return productID; } set { productID = value; } }

        private int preLeft;
        public int PreLeft { get {  return preLeft; } set {  preLeft = value; } }

        private int input;
        public int Input { get { return input; } set { input = value; } }

        private int output;
        public int Output { get { return output; } set { output = value; } }

        private int left;
        public int Left { get { return left; } set { left = value; } }


    }
}
