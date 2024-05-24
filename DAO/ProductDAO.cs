using QLTiemVang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemVang.DAO
{
    class ProductDAO
    {
        private static ProductDAO instance;

        public static ProductDAO Instance
        {
            get { if (instance == null) instance = new ProductDAO(); return instance; }
            private set { instance = value; }
        }

        private ProductDAO() { }

        public List<Product> GetListProduct()
        {
            List<Product> list = new List<Product>();

            string query = "EXEC USP_GetProduct";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Product product = new Product(item);
                list.Add(product);
            }
            return list;
        }

        public Product GetProduct(string id)
        {
            string query = "EXEC USP_GetProductByID " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            Product product = new Product(data.Rows[0]);
            return product;
        }


    }
}
