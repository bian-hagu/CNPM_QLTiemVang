using QLTiemVang.DAO;
using QLTiemVang.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTiemVang.GUI
{
    public partial class fSup_edit : Form
    {
        public Supplier outputSupplier = new Supplier();

        public fSup_edit(Supplier inputSup = null)
        {
            this.outputSupplier = inputSup;
            InitializeComponent();
            LoadForm();
        }
        private void LoadForm()
        {
            tb_ID.Text = this.outputSupplier.ID.ToString();
            tb_Name.Text = this.outputSupplier.Name;
            tb_Address.Text = this.outputSupplier.Address;
            tb_Phone.Text = this.outputSupplier.PhoneNum;
        }

        private void b_OK_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier(Convert.ToInt32(tb_ID.Text), tb_Name.Text, tb_Address.Text, tb_Phone.Text);
            SupplierDAO.Instance.InsertSupplier(supplier);
            Close();
        }

        private void b_Cencel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
