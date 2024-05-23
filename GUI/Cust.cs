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
using System.Xml.Linq;

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
            dgv_Cust.Refresh();
        }

        private void tb_Search_MouseClick(object sender, MouseEventArgs e)
        {
            tb_Search.Text = "";
            dgv_Cust.DataSource = CustDAO.Instance.Search(tb_Search.Text);
            if (addButon == 0)
            {
                DataGridViewButtonColumn bt_select = new DataGridViewButtonColumn();
                bt_select.HeaderText = "Select";
                bt_select.Name = "b_Select";
                bt_select.Text = "Select";
                bt_select.UseColumnTextForButtonValue = true;
                dgv_Cust.Columns.Add(bt_select);
                addButon = 1;

                DataGridViewButtonColumn bt_edit = new DataGridViewButtonColumn();
                bt_edit.HeaderText = "Edit";
                bt_edit.Name = "b_Edit";
                bt_edit.Text = "Edit";
                bt_edit.UseColumnTextForButtonValue = true;
                dgv_Cust.Columns.Add(bt_edit);
                addButon = 1;
            }
            dgv_Cust.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_Cust.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_Cust.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_Cust.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_Cust.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public void dgv_Cust_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3) //Select
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
            if (e.ColumnIndex == 4) //Edit
            {
                DataGridViewRow selectedRow = dgv_Cust.Rows[e.RowIndex];
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                string name = selectedRow.Cells[1].Value.ToString();
                string phone = selectedRow.Cells[2].Value.ToString();

                Cust cust = new Cust(id, name, phone);
                fCust_edit fcust_Edit = new fCust_edit(cust);
                fcust_Edit.ShowDialog();
                dgv_Cust.Refresh();
            }
        }

        private void b_ChoseCust_Click(object sender, EventArgs e)
        {
            returnCust = selectedCust;
            Close();
        }

        private void b_Add_Click(object sender, EventArgs e)
        {
            int id = CustDAO.Instance.CountCust() +1;
            Cust cust = new Cust(id);
            fCust_edit fcust_Edit = new fCust_edit(cust);
            fcust_Edit.ShowDialog();
        }
    }


}
