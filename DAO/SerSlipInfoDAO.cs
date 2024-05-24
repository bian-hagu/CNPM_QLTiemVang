using QLTiemVang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemVang.DAO
{
    public class SerSlipInfoDAO
    {
        private static SerSlipInfoDAO instance;

        public static SerSlipInfoDAO Instance
        {
            get { if (instance == null) instance = new SerSlipInfoDAO(); return instance; }
            private set { instance = value; }
        }

        private SerSlipInfoDAO() { }

        public List<ServiceSlipInfo> GetListSerSlipInfo(string id)
        {
            List<ServiceSlipInfo> listSerSlipInfo = new List<ServiceSlipInfo>();

            string query = "SELECT * FROM DV_PDV WHERE MaPhieuDichVu = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ServiceSlipInfo info = new ServiceSlipInfo(item);
                listSerSlipInfo.Add(info);
            }

            return listSerSlipInfo;
        }

        public void InsertSerSlipInfo(ServiceSlipInfo serviceSlipInfo)
        {
            string query = "EXEC USP_InsertSerSlipInfo @SLIPID , @SERID , @QUANLITY , @PRICE , @ORTHERPRICE , @TOTAL , @PREPAY , @REMAIN , @DATE , @STATUS ";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { serviceSlipInfo.SlipID, serviceSlipInfo.SerID, serviceSlipInfo.Quanlity, serviceSlipInfo.Price, serviceSlipInfo.OtherPrice,
                                                                         serviceSlipInfo.Total, serviceSlipInfo.Prepay, serviceSlipInfo.Remain, serviceSlipInfo.DeliverDay, serviceSlipInfo.Status });
        }

    }
}
