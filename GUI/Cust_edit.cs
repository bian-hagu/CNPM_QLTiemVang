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
    public partial class fCust_edit : Form
    {
        public Cust outputcust = new Cust();
        public Cust inputcust = new Cust();

        public fCust_edit(Cust inputcust = null)
        {
            this.outputcust = inputcust;
            InitializeComponent();
            LoadForm();
        }

        private void LoadForm()
        {
            tb_ID.Text = this.outputcust.ID.ToString();
            tb_Name.Text = this.outputcust.Name;
            tb_Phone.Text = this.outputcust.PhoneNum;
        }

        private void b_OK_Click(object sender, EventArgs e)
        {
            Cust cust = new Cust(Convert.ToInt32(tb_ID.Text), tb_Name.Text, tb_Phone.Text);
            CustDAO.Instance.InsertCust(cust);
            Close();
        }

        private void b_Cencel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
