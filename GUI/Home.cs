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

        private BuySlip buySlip = new BuySlip();
        private Supplier supplier = new Supplier();

        private int offset1 = 1;
        private int offset2 = 1;


        public fSaleSlip()
        {
            InitializeComponent();
            LoadProduct1();
            LoadProduct2();
            ShowSaleSlip();
            ShowBuySlip();
        }
        //-------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------

        private Product GetProduct(string id)
        {
            Product product = ProductDAO.Instance.GetProduct(id);
            return product;
        }
        //-------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------
        #region TagSale
        private void LoadProduct1()
        {
            List<Product> listProduct = ProductDAO.Instance.GetListProduct();
            cbProduct.DataSource = listProduct;
            cbProduct.DisplayMember = "Name";
        }

        private void ShowSaleSlip()
        {
            saleSlip.ID = SaleSlipDAO.Instance.CountSaleSlip() + offset1;
            saleSlip.Date =  DateTime.Now.ToString("dd-MM-yyyy");
            tb_ID.Text = saleSlip.ID.ToString();
            tb_Date.Text = saleSlip.Date;
            tb_Customer.Text = cust.Name;
            ShowListView();
            offset1 = 0;
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

        private void tb_Customer_MouseClick(object sender, MouseEventArgs e)
        {
            fCust cust_Add = new fCust();
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
            float total = quanlity * price;

            SaleSlipInfo saleSlipInfo = new SaleSlipInfo(saleSlip.ID, iDProduct, quanlity, price, total);

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
            nm_ProductCount.Value = 0;
            cbProduct.SelectedIndex = 0;
            ShowBuySlip();
            lvSaleSlip.Items.Clear();
            lvSaleSlip.Refresh();
            tb_TotalSlipPrice.Text = "0";
        }
        #endregion
        //-------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------
        #region TagBuy
        private void LoadProduct2()
        {
            List<Product> listProduct = ProductDAO.Instance.GetListProduct();
            cb_Product_2.DataSource = listProduct;
            cb_Product_2.DisplayMember = "Name";
        }

        private void ShowBuySlip()
        {
            buySlip.ID = BuySlipDAO.Instance.CountBuySlip() + offset2;
            buySlip.Date =  DateTime.Now.ToString("dd-MM-yyyy");
            tb_ID_2.Text = buySlip.ID.ToString();
            tb_date_2.Text = buySlip.Date;
            tb_Name_2.Text = supplier.Name;
            tb_Address_2.Text = supplier.Address;
            tb_Phone_2.Text = supplier.PhoneNum;
            ShowListView2();
            offset2 = 0;
        }

        private void ShowListView2()
        {
            lv_BuySlip.Items.Clear();
            List<BuySlipInfo> listBuySlipInfo = BuySlipInfoDAO.Instance.GetListBuySlipInfo(buySlip.ID.ToString());
            float totalPrice = 0;
            int serial = 1;
            foreach (BuySlipInfo item in listBuySlipInfo)
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
                lv_BuySlip.Items.Add(lvItem);
                serial++;
            }

            tb_Total_2.Text = totalPrice.ToString("c", culture);
        }

        private void tb_Name_2_MouseClick(object sender, MouseEventArgs e)
        {
            fSupplier fsupplier = new fSupplier();
            fsupplier.ShowDialog();
            if (fsupplier.returnSupplier !=  new Supplier())
            {
                supplier = fsupplier.returnSupplier;
                tb_Name_2.Text = supplier.Name;
                tb_Address_2.Text = supplier.Address;
                tb_Phone_2.Text = supplier.PhoneNum;
                buySlip.SupplierID = supplier.ID;
            }
        }

        private void b_Add_Click2(object sender, EventArgs e)
        {
            int iDBuySlip = BuySlipDAO.Instance.GetBuySlipID(buySlip.ID);
            int iDProduct = (cb_Product_2.SelectedItem as Product).ID;
            Product product = ProductDAO.Instance.GetProduct(iDProduct.ToString());

            int quanlity = (int)nm_Product_2.Value;
            float price = product.BuyPrice;
            float total = quanlity * price;

            BuySlipInfo buySlipInfo = new BuySlipInfo(buySlip.ID, iDProduct, quanlity, price, total);

            if (iDBuySlip == -1)
            {
                BuySlipDAO.Instance.InsertBuySlip(buySlip);
            }
            BuySlipInfoDAO.Instance.InsertBuySlipInfo(buySlipInfo);
            ShowBuySlip();
        }

        private void b_Completed_Click2(object sender, EventArgs e)
        {
            buySlip.ID = BuySlipDAO.Instance.CountBuySlip() + 1;
            buySlip.SupplierID = 0;
            buySlip.Date = DateTime.Now.ToString("dd-MM-yyyy");
            supplier.Name = "";
            supplier.Address = "";
            supplier.PhoneNum = "";
            tb_ID_2.Text = buySlip.ID.ToString();
            tb_Name_2.Clear();
            tb_date_2.Text = buySlip.Date.ToString();
            nm_Product_2.Value = 0;
            cb_Product_2.SelectedIndex = 0;

            ShowBuySlip();
            lv_BuySlip.Items.Clear();
            lv_BuySlip.Refresh();
            tb_Total_2.Text = "0";
        }
        #endregion
        //-------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------
        #region TagSer

        #endregion
        //-------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------
        #region 

        #endregion





        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
