using QLTiemVang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemVang.DAO
{
    internal class ReportInfoDAO
    {
        private static ReportInfoDAO instance;

        public static ReportInfoDAO Instance
        {
            get { if (instance == null) instance = new ReportInfoDAO(); return instance; }
            private set { instance = value; }
        }

        private ReportInfoDAO() { }

        public DataTable GetListReportInfo(string index)
        {
            string query = "EXEC USP_GetReport '%-"+ index +"-%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public void InsertReportInfo(ReportInfo reportInfo)
        {
            string query = "EXEC USP_InsertReportInfo @RPID , @PROID , @PRE , @BUY , @SALE , @CUR ";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { reportInfo.ID, reportInfo.ProductID, reportInfo.PreLeft,
                                                                        reportInfo.Input, reportInfo.Output, reportInfo.Left });
        }
    }
}
