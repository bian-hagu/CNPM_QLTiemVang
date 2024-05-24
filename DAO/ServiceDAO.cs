using QLTiemVang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemVang.DAO
{
    class ServiceDAO
    {
        private static ServiceDAO instance;

        public static ServiceDAO Instance
        {
            get { if (instance == null) instance = new ServiceDAO(); return instance; }
            private set { instance = value; }
        }

        private ServiceDAO() { }

        public List<Service> GetListService()
        {
            List<Service> list = new List<Service>();

            string query = "EXEC USP_GetService";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Service service = new Service(item);
                list.Add(service);
            }
            return list;
        }

        public Service GetService(string id)
        {
            string query = "EXEC USP_GetServiceByID " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            Service service = new Service(data.Rows[0]);
            return service;
        }


    }
}

