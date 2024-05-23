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
    public partial class fCust_add : Form
    {
        public Cust returnCust;
        private Cust selectedCust = new Cust();

        private int addButon = 0;
        public fCust_add()
        {
            InitializeComponent();
        }

        private void tb_Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            dgv_Cust.DataSource = CustDAO.Instance.Search(tb_Search.Text);
            if (addButon == 0)
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.HeaderText = "Select";
                btn.Name = "b_Select";
                btn.Text = "Select";
                btn.UseColumnTextForButtonValue = true;
                dgv_Cust.Columns.Add(btn);
                addButon = 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void dgv_Cust_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void tb_Search_MouseClick(object sender, MouseEventArgs e)
        {
            tb_Search.Text = "";
            dgv_Cust.DataSource = CustDAO.Instance.Search(tb_Search.Text);
            if (addButon == 0)
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.HeaderText = "Select";
                btn.Name = "b_Select";
                btn.Text = "Select";
                btn.UseColumnTextForButtonValue = true;
                dgv_Cust.Columns.Add(btn);
                addButon = 1;
            }
        }

        public void dgv_Cust_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                DataGridViewRow selectedRow = dgv_Cust.Rows[e.RowIndex];
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                string name = selectedRow.Cells[1].Value.ToString();
                string phone = selectedRow.Cells[2].Value.ToString();
                
                selectedCust = new Cust(id, name, phone);
                tb_id.Text = id.ToString();
                tb_name.Text = name;
                tb_phone.Text = phone;

            }
        }

        private void b_ChoseCust_Click(object sender, EventArgs e)
        {
            returnCust = selectedCust;
            Close();
        }
    }


}
