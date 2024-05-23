using QLTiemVang.DTO;
using QLTiemVang.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace QLTiemVang.GUI
{
    public partial class fSaleSlip : Form
    {
        private CultureInfo culture = new CultureInfo("vi-VN");
        private SaleSlip saleSlip = new SaleSlip();
        private Cust cust = new Cust();
        public fSaleSlip()
        {
            InitializeComponent();
            LoadProduct();
            ShowSaleSlip();
        }

        private void LoadProduct()
        {
            List<Product> listProduct = ProductDAO.Instance.GetListProduct();
            cbProduct.DataSource = listProduct;
            cbProduct.DisplayMember = "Name";
        }

        private void ShowSaleSlip()
        {
            saleSlip.ID = SaleSlipDAO.Instance.CountSaleSlip() + 1;
            saleSlip.Date =  DateTime.Now.ToString("dd-MM-yyyy");
            tb_ID.Text = saleSlip.ID.ToString();
            tb_Date.Text = saleSlip.Date;
            tb_Customer.Text = cust.Name;
            ShowListView();
        }

        private void ShowListView()
        {
            lvSaleSlip.Items.Clear();
            List<SaleSlipInfo> listSaleSlipInfo = SaleSlipInfoDAO.Instance.GetListSaleSlipInfo(saleSlip.ID.ToString());
            float totalPrice = 0;
            int serial = 1;
            foreach (SaleSlipInfo item in listSaleSlipInfo)
            {
                ListViewItem lvItem = new ListViewItem();
                Product product = GetProduct(item.ProductID.ToString());
                lvItem.Text = serial.ToString();
                lvItem.SubItems.Add(product.Name);
                lvItem.SubItems.Add(product.Type);
                lvItem.SubItems.Add(item.Quanlity.ToString());
                lvItem.SubItems.Add(product.Unit);
                lvItem.SubItems.Add(item.Price.ToString());
                lvItem.SubItems.Add(item.Total.ToString());
                totalPrice += item.Total;
                lvSaleSlip.Items.Add(lvItem);
                serial++;
            }

            tb_TotalSlipPrice.Text = totalPrice.ToString("c", culture);
        }

        private Product GetProduct(string id)
        {
            Product product = ProductDAO.Instance.GetProduct(id);
            return product;
        }

        private void tb_Customer_MouseClick(object sender, MouseEventArgs e)
        {
            fCust_add cust_Add = new fCust_add();
            cust_Add.ShowDialog();
            if (cust_Add.returnCust !=  new Cust())
            {
                cust = cust_Add.returnCust;
                tb_Customer.Text = (cust.Name);
                saleSlip.CustID = cust.ID;
            }
        }

        private void b_Add_Click(object sender, EventArgs e)
        {
            int iDSaleSlip = SaleSlipDAO.Instance.GetSaleSlipID(saleSlip.ID);

            int iDProduct = (cbProduct.SelectedItem as Product).ID;
            Product product = ProductDAO.Instance.GetProduct(iDProduct.ToString());

            int quanlity = (int)nm_ProductCount.Value;
            float price = product.SalePrice;
            float total = quanlity* price;

            SaleSlipInfo saleSlipInfo = new SaleSlipInfo(iDSaleSlip, iDProduct, quanlity, price, total);

            if (iDSaleSlip == -1)
            {
                SaleSlipDAO.Instance.InsertSaleSlip(saleSlip);
            }
            SaleSlipInfoDAO.Instance.InsertSaleSlipInfo(saleSlipInfo);
            ShowSaleSlip();
        }

        private void b_Completed_Click(object sender, EventArgs e)
        {
            saleSlip.ID = SaleSlipDAO.Instance.CountSaleSlip() + 1;
            saleSlip.CustID = 0;
            saleSlip.Date = DateTime.Now.ToString("dd-MM-yyyy");
            tb_ID.Text = saleSlip.ID.ToString();
            tb_Customer.Clear();
            tb_Date.Text = saleSlip.Date.ToString();
            lvSaleSlip.Clear();
            cbProduct.SelectedIndex = 0;
            nm_ProductCount.Value = 0;
        }








    }

}
