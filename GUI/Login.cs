using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTiemVang;
using QLTiemVang.DAO;

namespace QLTiemVang.GUI
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void b_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void b_Login_Click(object sender, EventArgs e)
        {
            string username = tb_Username.Text;
            string password = tb_Password.Text;

            if (Login(username, password))
            {
                this.Hide();
                //fHome f = new fHome();
                //fSaleSlip f = new fSaleSlip();
                fCust_add f = new fCust_add();
                f.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai mã nhân viên hoặc mật khẩu!");
            }
        }

        bool Login(string username, string password)
        {
            //return AccountDAO.Instance.Login(username, password);
            return true;
        }


        private void fLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
