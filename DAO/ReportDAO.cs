using QLTiemVang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemVang.DAO
{
    class ReportDAO
    {
        private static ReportDAO instance;

        public static ReportDAO Instance
        {
            get { if (instance == null) instance = new ReportDAO(); return instance; }
            private set { instance = value; }
        }

        private ReportDAO() { }

        public List<Report> GetListReport()
        {
            List<Report> list = new List<Report>();

            string query = "";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Report report = new Report(item);
                list.Add(report);
            }
            return list;
        }

        public Report GetReportByID(string id)
        {
            string query = "EXEC USP_GetReportByID " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            Report report = new Report(data.Rows[0]);
            return report;
        }
        public Report GetReportByMonth(string month)
        {
            string query = "EXEC USP_GetReportByMonth " + month;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            Report report = new Report(data.Rows[0]);
            return report;
        }

        public DataTable GetTotalBuyByMonth(string month)
        {
            string query = "EXEC USP_GetTotalBuyByMonth " + month;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        
        public DataTable GetTotalSaleByMonth(string month)
        {
            string query = "EXEC USP_GetTotalSaleByMonth " + month;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public DataTable GetPreMonth(string month)
        {
            string query = "EXEC USP_GetPreviousMonth " + month;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public void InsertReport(Report report)
        {
            string query = "EXEC USP_InsertReport @ID , @MONTH ";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] {report.ID, report.Month});
        }

    }
}
