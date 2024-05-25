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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace QLTiemVang.GUI
{
    public partial class fSaleSlip : Form
    {
        private CultureInfo culture = new CultureInfo("vi-VN");

        private SaleSlip saleSlip = new SaleSlip();
        private Cust cust = new Cust();

        private BuySlip buySlip = new BuySlip();
        private Supplier supplier = new Supplier();

        private ServiceSlip serviceSlip = new ServiceSlip();
        private Cust cust2 = new Cust();

        private int offset1 = 1;
        private int offset2 = 1;
        private int offset3 = 1;


        public fSaleSlip()
        {
            InitializeComponent();

            LoadProduct1();
            ShowSaleSlip();

            LoadProduct2();
            ShowBuySlip();

            LoadService();
            ShowSerSlip();

            ShowListView5();

        }
        //-------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------

        private Product GetProduct(string id)
        {
            Product product = ProductDAO.Instance.GetProduct(id);
            return product;
        }

        private Service GetService(string id)
        {
            Service service = ServiceDAO.Instance.GetService(id);
            return service;
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
        private void LoadService()
        {
            List<Service> listServices = ServiceDAO.Instance.GetListService();
            cb_Ser.DataSource = listServices;
            cb_Ser.DisplayMember = "Name";
        }

        private void ShowSerSlip()
        {
            serviceSlip.ID = ServiceSlipDAO.Instance.CountSerSlip() + offset3;
            serviceSlip.Date = DateTime.Now.ToString("dd-MM-yyyy");
            tb_ID_3.Text = serviceSlip.ID.ToString();
            tb_Date_3.Text = serviceSlip.Date;
            tb_Custname_3.Text = cust2.Name;
            tb_Phone_3.Text = cust2.PhoneNum;
            ShowListView3();
            offset3 = 0;
        }

        private void ShowListView3()
        {
            lv_SerSlip.Items.Clear();
            List<ServiceSlipInfo> listSerSlipInfo = SerSlipInfoDAO.Instance.GetListSerSlipInfo(serviceSlip.ID.ToString());
            float totalPrice = 0;
            float totalPrepay = 0;
            float totalRemain = 0;
            int serial = 1;

            foreach (ServiceSlipInfo item in listSerSlipInfo)
            {
                ListViewItem lvItem = new ListViewItem();
                Service service = GetService(item.SerID.ToString());
                lvItem.Text = serial.ToString();
                lvItem.SubItems.Add(service.Name);
                lvItem.SubItems.Add(item.Price.ToString());
                lvItem.SubItems.Add((item.Price + item.OtherPrice).ToString());
                lvItem.SubItems.Add(item.Quanlity.ToString());

                lvItem.SubItems.Add(item.Total.ToString());
                lvItem.SubItems.Add(item.Prepay.ToString());
                lvItem.SubItems.Add(item.Remain.ToString());
                lvItem.SubItems.Add(item.DeliverDay);
                lvItem.SubItems.Add(item.Status);

                totalPrice += item.Total;
                totalPrepay += item.Prepay;
                totalRemain += item.Remain;

                lv_SerSlip.Items.Add(lvItem);
                serial++;
            }

            tb_Total_3.Text = totalPrice.ToString("c", culture);
            tb_SumPrepay.Text = totalPrepay.ToString("c", culture);
            tb_SumRemain.Text = totalRemain.ToString("c", culture);
        }

        private void tb_Name_3_MouseClick(object sender, MouseEventArgs e)
        {
            fCust cust_Add = new fCust();
            cust_Add.ShowDialog();
            if (cust_Add.returnCust !=  new Cust())
            {
                cust2 = cust_Add.returnCust;
                tb_Custname_3.Text = (cust2.Name);
                tb_Phone_3.Text = (cust2.PhoneNum);
                serviceSlip.CustID = cust2.ID;
            }
        }

        private void b_Add_Click3(object sender, EventArgs e)
        {
            int iDSerSlip = ServiceSlipDAO.Instance.GetSerSlipID(serviceSlip.ID);
            int iDService = (cb_Ser.SelectedItem as Service).ID;
            Service service = ServiceDAO.Instance.GetService(iDService.ToString());

            int quanlity = (int)nm_Ser.Value;
            float price = service.Price;
            float other = Convert.ToInt32(tb_OtherCosts.Text);
            float total = quanlity * (price + other);
            float prepay = Convert.ToInt32(tb_Repay.Text);
            float remain = total - prepay;
            string date = dtp_Date3.Value.ToString("dd-MM-yyyy");
            string status = cb_Status_3.Text;

            ServiceSlipInfo serviceSlipInfo = new ServiceSlipInfo(serviceSlip.ID, iDService, quanlity, price, other, total, prepay, remain, date, status);

            if ((prepay)/total > 0.5)
            {

                serviceSlip.Total += serviceSlipInfo.Total;
                serviceSlip.TotalPrepay += serviceSlipInfo.Prepay;
                serviceSlip.TotalRemain += serviceSlipInfo.Remain;

                if (serviceSlipInfo.Status == "Chưa giao")
                    serviceSlip.Status = "Chưa hoàn thành";
                if (serviceSlip.Status == "")
                    serviceSlip.Status = "Hoàn thành";

                ServiceSlip slip = new ServiceSlip(serviceSlip.ID, serviceSlip.CustID, serviceSlip.Date, serviceSlip.Total, serviceSlip.TotalPrepay, serviceSlip.TotalRemain, serviceSlip.Status);
                ServiceSlipDAO.Instance.InsertSerSlip(slip);
                SerSlipInfoDAO.Instance.InsertSerSlipInfo(serviceSlipInfo);
            }
            else
            {
                MessageBox.Show("Phải trả trước trên 50% số tiền");
            }
            ShowSerSlip();
        }

        private void b_Completed_Click3(object sender, EventArgs e)
        {
            serviceSlip = new ServiceSlip();
            serviceSlip.ID = ServiceSlipDAO.Instance.CountSerSlip() + 1;

            cust2.Name = "";
            cust2.PhoneNum = "";

            nm_Ser.Value = 0;
            cb_Ser.SelectedIndex = 0;
            cb_Status_3.SelectedIndex = 0;
            tb_Repay.Text = "0";
            tb_OtherCosts.Text = "0";

            tb_Total_3.Text = "0";
            tb_SumPrepay.Text = "0";
            tb_SumRemain.Text = "0";
            tb_SumRemain.Refresh();

            ShowSerSlip();
            lv_SerSlip.Items.Clear();
            lv_SerSlip.Refresh();
        }

        private void cb_Ser_SelectedIndexChanged(object sender, EventArgs e)
        {
            Service ser = cb_Ser.SelectedItem as Service;
            tb_Price.Text = (ser.Price * Convert.ToInt32(nm_Ser.Value)).ToString("c", culture);
        }

        #endregion
        //-------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------
        #region TagSerSlip
        private void ShowListView4(DataTable data)
        {
            lv_ListSerSlip.Items.Clear();
            int serial = 1;

            foreach (DataRow row in data.Rows)
            {
                ListViewItem item = new ListViewItem(serial.ToString());
                for (int i = 0; i < data.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                lv_ListSerSlip.Items.Add(item);
                serial++;
            }
        }

        private void tb_Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataTable data = ServiceSlipDAO.Instance.Search(tb_Search.Text);
            ShowListView4(data);
            lv_ListSerSlip.Refresh();
        }
        #endregion
        #region TagReport
        private string month;
        private Report report = new Report();
        private List<ReportInfo> listRP = new List<ReportInfo>();
        private void ShowListView5()
        {
            lv_Report.Items.Clear();
            month = tb_Month.Text;
            if (month != null)
            {
                if (month.Length == 1)
                {
                    month = "0"+month;
                }
                else if (month.Length ==  2)
                {
                    report.ID = Convert.ToInt32(month);
                    report.Month = month;

                    List<Product> products = ProductDAO.Instance.GetListProduct();
                    DataTable listTotalBuy = ReportDAO.Instance.GetTotalBuyByMonth(month);
                    DataTable listTotalSale = ReportDAO.Instance.GetTotalSaleByMonth(month);
                    DataTable listPreMonth = ReportDAO.Instance.GetPreMonth(month);

                    int serial = 1;

                    foreach (Product product in products)
                    {
                        // Find corresponding rows in DataTables
                        DataRow preMonthRow = listPreMonth.AsEnumerable().FirstOrDefault(row => row["MaSanPham"].ToString() == product.ID.ToString());
                        DataRow buyRow = listTotalBuy.AsEnumerable().FirstOrDefault(row => row["MaSanPham"].ToString() == product.ID.ToString());
                        DataRow saleRow = listTotalSale.AsEnumerable().FirstOrDefault(row => row["MaSanPham"].ToString() == product.ID.ToString());

                        // Extract values
                        int preMonthQuantity = preMonthRow != null ? Convert.ToInt32(preMonthRow["TotalStartingInventory"]) : 0;
                        int buyQuantity = buyRow != null ? Convert.ToInt32(buyRow["TotalQuantityPurchased"]) : 0;
                        int saleQuantity = saleRow != null ? Convert.ToInt32(saleRow["TotalQuantitySold"]) : 0;

                        // Calculate current month quantity
                        int currentMonthQuantity = preMonthQuantity + (buyQuantity - saleQuantity);

                        // Create ListViewItem
                        ListViewItem lvItem = new ListViewItem(serial.ToString());
                        lvItem.SubItems.Add(product.Name);
                        lvItem.SubItems.Add(preMonthQuantity.ToString());
                        lvItem.SubItems.Add(buyQuantity.ToString());
                        lvItem.SubItems.Add(saleQuantity.ToString());
                        lvItem.SubItems.Add(currentMonthQuantity.ToString());
                        lvItem.SubItems.Add(product.Unit);

                        // Assume item.Total is calculated based on some logic

                        // Add to ListView
                        lv_Report.Items.Add(lvItem);

                        // Update total price
                        serial++;

                        ReportInfo RP = new ReportInfo(report.ID, product.ID, preMonthQuantity, buyQuantity, saleQuantity, currentMonthQuantity);
                        listRP.Add(RP);
                    }
                }
                //lv_Report.Refresh();
            }
        }
        #endregion

        private void b_OK_Click(object sender, EventArgs e)
        {
            ShowListView5();
            lv_Report.Refresh();
        }

        private void tb_Export_Click(object sender, EventArgs e)
        {
            ReportDAO.Instance.InsertReport(report);

            foreach (ReportInfo item in listRP)
            {
                ReportInfoDAO.Instance.InsertReportInfo(item);
            }
        }
    }

}
