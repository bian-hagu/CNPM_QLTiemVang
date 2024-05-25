using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemVang.DTO
{
    public class Report
    {
        public Report(int id = 0, string month = "")
        {
            this.ID = id;
            this.Month = month;
        }
        public Report(DataRow row)
        {
            this.ID = Convert.ToInt32(row["MaBCTK"]);
            this.Month = row["Thang"].ToString();
        }

        private int iD;
        public int ID { get { return iD; } set { iD = value; } }

        private string month;
        public string Month { get { return month; } set { month = value; } }
    }
}
